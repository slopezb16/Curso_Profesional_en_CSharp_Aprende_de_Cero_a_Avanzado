class Snake
{
    // Variables
    #region Properties
    public static int width = 20;
    public static int height = 20;
    public static int score = 0;
    public static bool gameOver = false;
    public static Random random = new Random();

    public static int snakeX;
    public static int snakeY;
    public static int fruitX;
    public static int fruitY;

    public static int[] tailX = new int[100];
    public static int[] tailY = new int[100];
    public static int tailLength = 0;
    public static int speed = 10;
    public static int direction = 0;
    #endregion

    static void Main()
    {
        // Titulo del juego
        Console.Title = "Snake Game 1.0";

        // No mostrar el cursor en la consola
        Console.CursorVisible = false;

        // Iniciar juego
        Console.WriteLine("Iniciando jeugo...");
        InitializeGame();

        //
        while (!gameOver)
        {
            if (Console.KeyAvailable)
            {
                // Metodo para verificar la tecla que esta oprimiendo
                HandleKeypress(Console.ReadKey(true).Key);
            }

            // Mover
            MoveSnake();

            // Verificar si se choco
            if (CheckCollision())
            {
                gameOver = true;
            }

            // Diibujar el juego
            Draw();

            // Controles de velocidad del juego
            Thread.Sleep(1000/speed);
        }

        // Establecer la posicion del cursor
        Console.SetCursorPosition(width / 2 - 5, height / 2);

        Console.WriteLine("Game over! Tu puntaje es de: " + score + ".");
        Console.WriteLine("");
    }

    // Iniciar juego
    static void InitializeGame()
    {
        snakeX = width / 2;
        snakeY = height / 2;

        fruitX = random.Next(1, width - 1);
        fruitY = random.Next(1, height - 1);

        score = 0;

        direction = 0;
    }

    // Control de la pulsacion de las teclas
    static void HandleKeypress(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.W:
            case ConsoleKey.UpArrow:
                if (direction != 2)
                {
                    direction = 0;
                }
                break;

            case ConsoleKey.D:
            case ConsoleKey.RightArrow:
                if (direction != 3)
                {
                    direction = 1;
                }
                break;

            case ConsoleKey.S:
            case ConsoleKey.DownArrow:
                if (direction != 0)
                {
                    direction = 2;
                }
                break;

            case ConsoleKey.A:
            case ConsoleKey.LeftArrow:
                if (direction != 1)
                {
                    direction = 3;
                }
                break;

            case ConsoleKey.Escape:
                gameOver = true;
                break;
        }
    }

    // Movimiento de la serpiente - actualizar cordenadas - Manipulacion
    static void MoveSnake()
    {
        // Almacenar las cordenadas de la cabeza
        int prevX = tailX[0];
        int prevY = tailY[0];
        int prev2X, prev2Y;

        // Actualizar la cola con la cabeza
        tailX[0] = snakeX;
        tailY[0] = snakeY;

        // Comportamiento del crecimiento de la serpiente - Cola
        for (int i = 1; i < tailLength; i++)
        {
            prev2X = tailX[i];
            prev2Y = tailY[i];
            tailX[i] = prevX;
            tailY[i] = prevY;
            prevX = prev2X;
            prevY = prev2Y;
        }

        // Direccion en la que esta
        switch (direction)
        {
            case 0:
                snakeY--;
                break;

            case 1:
                snakeX++;
                break;

            case 2:
                snakeY++;
                break;

            case 3:
                snakeX--;
                break;
        }

        // Si choca con las paredes
        if (snakeX == 0 || snakeX == width - 1 || snakeY == 0 || snakeY == height)
        {
            gameOver = true;
        }

        // Que pasa si toma una fruta
        if (snakeX == fruitX && snakeY == fruitY)
        {
            score += 10;
            tailLength++;
            fruitX = random.Next(1, width - 1);
            fruitY = random.Next(1, height - 1);
        }
    }

    // Verificar cuando la serpiente choque con su propia cola
    static bool CheckCollision()
    {
        for (int i = 0; i < tailLength; i++)
        {
            if (tailX[i] == snakeX && tailY[i] == snakeY)
            {
                return true;
            }
        }
        return false;

    }

    // Dibujar juego
    static void Draw()
    {
        Console.Clear();

        // Bordes 
        for (int i = 0; i < width + 2; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine();

        // Filas
        for (int i = 0; i < height; i++)
        {
            // Columnas
            for (int j = 0; j < width; j++)
            {
                if (j == 0) // Borde izquierdo
                {
                    Console.Write("#");
                }
                else if (j == width - 1) // Borde izquierdo
                {
                    Console.Write("#");
                }
                else if (i == snakeY && j == snakeX) // Cabeza de la serbiente
                {
                    Console.Write("O");
                }
                else if (i == fruitY && j == fruitX) // Imprimir la fruta
                {
                    Console.Write("F");
                }
                else // verificar la parte de la cola
                {
                    bool tailBit = false;
                    for (int k = 0; k < tailLength; k++)
                    {
                        if (tailX[k] == j && tailY[k] == i)
                        {
                            tailBit = true;
                            break;
                        }
                    }

                    if (tailBit)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }

        // 
        for (int i = 0; i < width + 2; i++)
        {
            Console.Write("#");
        }

        Console.WriteLine();
        Console.WriteLine("Score: " + score);
    }
}