using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;

//
// Snake 3.0 - Versión mejorada
// - Top 3 por tamaño de mapa (archivo JSON)
// - Selección de mapa (pequeño/mediano/grande)
// - Niveles dinámicos (cada X puntos velocidad++ y se añaden obstáculos)
// - Medición de tiempo de juego (Stopwatch)
// - Comentarios detallados en español
//
// NOTA: requiere System.Text.Json (.NET Core / .NET 5+). Si necesitas alternativa para .NET Framework dime.
//

class Snake3
{
    // --- Configuraciones generales ---
    static Random rand = new Random();

    // Parametrizables según mapa
    static int width, height;                   // tamaño activo del mapa
    static string mapName;                      // "Pequeño", "Mediano", "Grande"
    static string scoresFilePath;               // archivo JSON para top scores del mapa

    // Juego
    static List<(int x, int y)> snake = new List<(int x, int y)>();
    static (int x, int y) fruit;
    static List<(int x, int y)> obstacles = new List<(int x, int y)>();
    static int dx = 1, dy = 0;                  // dirección actual
    static int speed = 8;                       // ticks por segundo
    static int level = 1;
    static int score = 0;
    static bool paused = false;
    static bool gameOver = false;
    static Stopwatch stopwatch = new Stopwatch();

    // Persistencia: top scores
    class ScoreEntry
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public double TimeSeconds { get; set; }
        public DateTime Date { get; set; }
    }

    // --- PUNTO DE ENTRADA ---
    static void Main()
    {
        Console.Title = "Snake 3.0 - Arcade";
        Console.CursorVisible = false;
        PlayIntroMusic(); // 🎶 Música de inicio

        // Menú inicial: nombre y selección de mapa
        Console.Clear();

        // 🎶 Iniciar música de menú
        PlayMenuMusic();

        Console.WriteLine("=== SNAKE 3.0 (Arcade) ===\n");
        Console.Write("Ingresa tu nombre: ");
        string playerName = Console.ReadLine()?.Trim();
        if (string.IsNullOrWhiteSpace(playerName)) playerName = "Player";

        SelectMap();

        // Cargar y mostrar Top 3 del mapa seleccionado
        LoadAndShowTop3();

        // Preguntar si desea jugar
        Console.WriteLine("\nPresiona ENTER para comenzar a jugar o ESC para salir.");
        var k = Console.ReadKey(true).Key;
        if (k == ConsoleKey.Escape) return;

        // Bucle principal de partidas (permite reiniciar)
        while (true)
        {
            // Inicializar partida
            InitGame();

            // Iniciar cronómetro
            stopwatch.Restart();

            // Música mientras juegas
            PlayBackgroundMusic(); 

            // Loop de juego
            GameLoop();

            // Detener cronómetro
            stopwatch.Stop();

            // Música de game over
            PlayGameOverMusic(); 

            // Mostrar pantalla de Game Over y guardar en top3
            HandleGameOverAndSave(playerName);

            // Preguntar si jugar de nuevo
            Console.WriteLine("\nPresiona ENTER para jugar de nuevo, M para cambiar mapa, o ESC para salir.");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape) break;
            if (key == ConsoleKey.M)
            {
                SelectMap();
                LoadAndShowTop3();
                Console.WriteLine("\nPresiona ENTER para comenzar o ESC para salir.");
                var k2 = Console.ReadKey(true).Key;
                if (k2 == ConsoleKey.Escape) break;
            }
            // si ENTER -> reinicia (el while hace Start nuevamente)
        }

        Console.WriteLine("\nGracias por jugar. ¡Hasta la próxima!");
    }

    // --- Selección de mapa (tamaños predefinidos) ---
    static void SelectMap()
    {
        Console.Clear();
        Console.WriteLine("Elige un mapa:");
        Console.WriteLine("1 - Pequeño (20 x 15)");
        Console.WriteLine("2 - Mediano  (30 x 20)");
        Console.WriteLine("3 - Grande   (40 x 25)");
        ConsoleKey key;
        do
        {
            key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                width = 20; height = 15; mapName = "Pequeño"; break;
            }
            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                width = 30; height = 20; mapName = "Mediano"; break;
            }
            else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
            {
                width = 40; height = 25; mapName = "Grande"; break;
            }
        } while (true);

        // path de archivo por mapa (en la carpeta donde se ejecuta el programa)
        scoresFilePath = $"scores_{mapName.ToLower()}.json";
    }

    // --- Muestra Top 3 para el mapa actual (si existe archivo lo lee) ---
    static void LoadAndShowTop3()
    {
        Console.Clear();
        Console.WriteLine($"== TOP 3 - Mapa: {mapName} ==\n");

        List<ScoreEntry> list = new List<ScoreEntry>();
        if (File.Exists(scoresFilePath))
        {
            try
            {
                string json = File.ReadAllText(scoresFilePath);
                list = JsonSerializer.Deserialize<List<ScoreEntry>>(json) ?? new List<ScoreEntry>();
            }
            catch
            {
                list = new List<ScoreEntry>();
            }
        }

        // ordenar por score descendente
        var top3 = list.OrderByDescending(s => s.Score).ThenBy(s => s.TimeSeconds).Take(3).ToList();
        if (!top3.Any())
        {
            Console.WriteLine("Aún no hay récords para este mapa. ¡Sé el primero!");
        }
        else
        {
            int pos = 1;
            foreach (var s in top3)
            {
                Console.WriteLine($"{pos}. {s.Name} - {s.Score} pts - {s.TimeSeconds:F1}s - {s.Date:g}");
                pos++;
            }
        }
    }

    // --- Inicializar estado de la partida ---
    static void InitGame()
    {
        Console.Clear();

        // Reiniciar parámetros
        snake.Clear();
        obstacles.Clear();
        snake.Add((x: width / 2, y: height / 2)); // cabeza al centro
        dx = 1; dy = 0;
        score = 0;
        level = 1;
        speed = 8;
        paused = false;
        gameOver = false;

        // colocar fruta y obstáculos iniciales
        PlaceFruit();
        int initialObstacles = Math.Max(2, width / 10); // más grande = más obstáculos
        for (int i = 0; i < initialObstacles; i++)
            AddRandomObstacle();

        // ajustar color de fondo por nivel
        SetConsoleColorsForLevel();
    }

    // --- Bucle principal de la partida ---
    static void GameLoop()
    {
        // Mientras no termine el juego
        while (!gameOver)
        {
            // Leer entrada si hay (no bloqueante)
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                HandleInput(key);
            }

            // Si no está pausado, actualizar la lógica
            if (!paused)
            {
                Update();
            }

            // Dibujar el frame
            Draw();

            // Control de velocidad mediante sleep
            int sleepMs = Math.Max(10, 1000 / speed);
            Thread.Sleep(sleepMs);
        }
    }

    // --- Manejo de teclas ---
    static void HandleInput(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.W:
                if (dy != 1) { dx = 0; dy = -1; }
                break;

            case ConsoleKey.DownArrow:
            case ConsoleKey.S:
                if (dy != -1) { dx = 0; dy = 1; }
                break;

            case ConsoleKey.LeftArrow:
            case ConsoleKey.A:
                if (dx != 1) { dx = -1; dy = 0; }
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.D:
                if (dx != -1) { dx = 1; dy = 0; }
                break;

            case ConsoleKey.P: // Pausa
                paused = !paused;
                break;

            case ConsoleKey.Escape:
                gameOver = true; // terminar partida
                break;
        }
    }

    // --- Lógica del juego (mover serpiente, colisiones, comer fruta, niveles) ---
    static void Update()
    {
        // Tomamos la cabeza y calculamos nueva cabeza con nombres (x,y)
        var head = snake[0];
        var newHead = (x: head.x + dx, y: head.y + dy);

        // --------------- COMPORTAMIENTO: bordes ---------------
        // En esta versión, vamos a implementar *modo borde sólido* (muere al chocar).
        // Si quieres modo "infinito" (wrap-around), sustituye estas comprobaciones:
        if (newHead.x <= 0 || newHead.x >= width - 1 || newHead.y <= 0 || newHead.y >= height - 1)
        {
            // choca con pared
            gameOver = true;
            return;
        }

        // --------------- Colisión con cola u obstáculos ---------------
        if (snake.Skip(0).Any(p => p == newHead) || obstacles.Contains(newHead))
        {
            gameOver = true;
            return;
        }

        // Insertar nueva cabeza
        snake.Insert(0, newHead);

        // Comer fruta
        if (newHead == fruit)
        {
            score += 10;
            // Subir de nivel cada 50 puntos
            int newLevel = (score / 50) + 1;
            if (newLevel > level)
            {
                level = newLevel;
                speed += 2; // incremento de velocidad por nivel
                // al subir de nivel agregamos más obstáculos
                for (int i = 0; i < Math.Min(5, level); i++)
                    AddRandomObstacle();

                // cambiamos colores para percibir el nuevo nivel
                SetConsoleColorsForLevel();

                // feedback sonoro de nivel (si se desea)
                try { Console.Beep(800, 120); } catch { /* ambiente sin audio */ }
            }

            PlaceFruit(); // reubicar fruta

            // efecto sonoro al comer
            try { Console.Beep(600, 80); } catch { }
        }
        else
        {
            // si no comió, quitar la última parte de la cola (efecto movimiento)
            snake.RemoveAt(snake.Count - 1);
        }
    }

    // --- Dibujado en consola ---
    static void Draw()
    {
        // Limpiar y dibujar bordes y contenido
        Console.Clear();

        // Dibujar borde superior
        for (int x = 0; x < width; x++) Console.Write("#");
        Console.WriteLine();

        // Dibujar filas interiores
        for (int y = 1; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x == 0 || x == width - 1) // bordes laterales
                {
                    Console.Write("#");
                    continue;
                }

                // Cabeza de la serpiente
                if ((x, y) == snake[0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O");
                    Console.ResetColor();
                    continue;
                }

                // Cola
                if (snake.Skip(1).Contains((x, y)))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("o");
                    Console.ResetColor();
                    continue;
                }

                // Fruit
                if ((x, y) == fruit)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("F");
                    Console.ResetColor();
                    continue;
                }

                // Obstáculo
                if (obstacles.Contains((x, y)))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("X");
                    Console.ResetColor();
                    continue;
                }

                // Espacio vacío
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        // Borde inferior
        for (int x = 0; x < width; x++) Console.Write("#");
        Console.WriteLine();

        // Información / HUD
        Console.WriteLine($"Mapa: {mapName}  |  Score: {score}  |  Level: {level}  |  Velocidad: {speed}  |  Tiempo: {stopwatch.Elapsed.TotalSeconds:F1}s");
        if (paused) Console.WriteLine("== PAUSADO - Presiona P para continuar ==");
    }

    // --- Game Over: mostrar pantalla y guardar top 3 ---
    static void HandleGameOverAndSave(string playerName)
    {
        Console.Clear();
        Console.WriteLine("=== GAME OVER ===");
        Console.WriteLine($"Mapa: {mapName}");
        Console.WriteLine($"Score: {score}");
        Console.WriteLine($"Tiempo: {stopwatch.Elapsed.TotalSeconds:F1} s");
        Console.WriteLine($"Level alcanzado: {level}");

        // Cargar existentes
        List<ScoreEntry> list = new List<ScoreEntry>();
        if (File.Exists(scoresFilePath))
        {
            try
            {
                string json = File.ReadAllText(scoresFilePath);
                list = JsonSerializer.Deserialize<List<ScoreEntry>>(json) ?? new List<ScoreEntry>();
            }
            catch { list = new List<ScoreEntry>(); }
        }

        // Añadir la nueva entrada
        var entry = new ScoreEntry
        {
            Name = playerName,
            Score = score,
            TimeSeconds = stopwatch.Elapsed.TotalSeconds,
            Date = DateTime.Now
        };
        list.Add(entry);

        // Mantener ordenados y sólo top N (guardamos más por si quieres ver histórico; aquí guardamos 10)
        var ordered = list.OrderByDescending(s => s.Score).ThenBy(s => s.TimeSeconds).Take(10).ToList();

        // Guardar de nuevo
        try
        {
            string outJson = JsonSerializer.Serialize(ordered, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(scoresFilePath, outJson);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error guardando scores: " + ex.Message);
        }

        // Mostrar top 3 resultante
        Console.WriteLine("\n--- TOP 3 (actualizado) ---");
        var top3 = ordered.Take(3).ToList();
        if (!top3.Any()) Console.WriteLine("No hay récords aún.");
        else
        {
            int pos = 1;
            foreach (var s in top3)
            {
                Console.WriteLine($"{pos}. {s.Name} - {s.Score} pts - {s.TimeSeconds:F1}s - {s.Date:g}");
                pos++;
            }
        }
    }

    // --- Utilidades: colocar fruta y añadir obstáculos ---
    static void PlaceFruit()
    {
        // Elegir posición no ocupada por la serpiente ni obstáculo
        int fx, fy;
        do
        {
            fx = rand.Next(1, width - 1);
            fy = rand.Next(1, height - 1);
        } while (snake.Contains((fx, fy)) || obstacles.Contains((fx, fy)));

        fruit = (x: fx, y: fy);
    }

    static void AddRandomObstacle()
    {
        int ox, oy;
        int attempts = 0;
        do
        {
            ox = rand.Next(1, width - 1);
            oy = rand.Next(1, height - 1);
            attempts++;
            if (attempts > 50) return; // evita bucle infinito
        } while (snake.Contains((ox, oy)) || obstacles.Contains((ox, oy)) || (ox == fruit.x && oy == fruit.y));

        obstacles.Add((x: ox, y: oy));
    }

    // --- Ajuste de colores de consola según nivel (efecto visual simple) ---
    static void SetConsoleColorsForLevel()
    {
        // Cambia el color de fondo por rango de niveles (solo para efecto)
        // Nota: cambiar background requiere limpiar consola para que se vea el efecto
        if (level <= 2)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else if (level <= 4)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (level <= 6)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.Clear();
    }

    // Canción simple estilo Mario (intro)
    //static void PlayIntroMusic()
    //{
    //    // Notas: frecuencia en Hz, duración en ms
    //    int C = 261;  // Do
    //    int E = 329;  // Mi
    //    int G = 392;  // Sol
    //    int A = 440;  // La
    //    int B = 494;  // Si
    //    int C2 = 523; // Do alto

    //    Console.Beep(E, 200);
    //    Console.Beep(E, 200);
    //    Console.Beep(E, 200);

    //    Console.Beep(C, 200);
    //    Console.Beep(E, 200);
    //    Console.Beep(G, 400);

    //    Console.Beep(G, 200);
    //    Console.Beep(C2, 400);

    //    Console.Beep(G, 200);
    //    Console.Beep(E, 200);
    //    Console.Beep(A, 200);
    //    Console.Beep(B, 400);
    //    Console.Beep(B, 200);
    //    Console.Beep(A, 200);
    //    Console.Beep(G, 400);
    //}

    //static void PlayBackgroundMusic()
    //{
    //    new Thread(() =>
    //    {
    //        while (!gameOver)
    //        {
    //            Console.Beep(440, 150); // A
    //            Console.Beep(494, 150); // B
    //            Console.Beep(523, 150); // C
    //            Console.Beep(440, 150); // A
    //        }
    //    }).Start();
    //}

    //static void PlayIntroMusic()
    //{
    //    Console.Beep(523, 200); // C
    //    Console.Beep(659, 200); // E
    //    Console.Beep(784, 200); // G
    //    Console.Beep(1046, 400); // C alto
    //}

    //static void PlayGameOverMusic()
    //{
    //    Console.Beep(392, 400); // G
    //    Console.Beep(370, 400); // F#
    //    Console.Beep(349, 600); // F
    //}

    // --- Música de Fondo (loop mientras juegas) ---
    static void PlayBackgroundMusic()
    {
        new Thread(() =>
        {
            int[,] melody = new int[,]
            {
            {440, 200}, {494, 200}, {523, 200}, {587, 200}, // A - B - C - D
            {659, 300}, {523, 200}, {494, 200}, {440, 400}  // E - C - B - A
            };

            while (!gameOver)
            {
                for (int i = 0; i < melody.GetLength(0) && !gameOver; i++)
                {
                    Console.Beep(melody[i, 0], melody[i, 1]);
                    Thread.Sleep(20); // pequeña pausa
                }
            }
        }).Start();
    }

    // --- Música de Intro ---
    static void PlayIntroMusic()
    {
        int[,] intro = new int[,]
        {
        {523, 200}, {659, 200}, {784, 200}, {988, 400},  // C - E - G - B
        {784, 200}, {659, 200}, {523, 400},              // G - E - C
        {659, 200}, {784, 200}, {988, 200}, {1046, 500}  // E - G - B - C alto
        };

        for (int i = 0; i < intro.GetLength(0); i++)
        {
            Console.Beep(intro[i, 0], intro[i, 1]);
            Thread.Sleep(30);
        }
    }

    // --- Música de Game Over ---
    static void PlayGameOverMusic()
    {
        int[,] over = new int[,]
        {
        {659, 300}, {622, 300}, {587, 300}, {554, 400}, // E♭ - D - C# - C
        {440, 600}, {392, 800}                          // A - G (final grave)
        };

        for (int i = 0; i < over.GetLength(0); i++)
        {
            Console.Beep(over[i, 0], over[i, 1]);
            Thread.Sleep(50);
        }
    }

    // --- Música de Menú (loop mientras estés en los menús) ---
    static void PlayMenuMusic()
    {
        new Thread(() =>
        {
            int[,] menuMelody = new int[,]
            {
            // 🎵 Arpegio calmado: C - G - A - F
            {262, 400}, {0, 100},   // C
            {196, 400}, {0, 100},   // G
            {220, 400}, {0, 100},   // A
            {175, 600}, {0, 200},   // F

            // 🎵 subida ligera: C - E - G
            {262, 300}, {330, 300}, {392, 500}, {0, 300},

            // 🎵 cierra con calma en C
            {262, 600}, {0, 400}
            };

            while (!gameOver) // parar al iniciar la partida
            {
                for (int i = 0; i < menuMelody.GetLength(0) && !gameOver; i++)
                {
                    int freq = menuMelody[i, 0];
                    int dur = menuMelody[i, 1];
                    if (freq > 0)
                        Console.Beep(freq, dur);
                    else
                        Thread.Sleep(dur); // silencio (pausa)
                }
            }
        }).Start();
    }
}