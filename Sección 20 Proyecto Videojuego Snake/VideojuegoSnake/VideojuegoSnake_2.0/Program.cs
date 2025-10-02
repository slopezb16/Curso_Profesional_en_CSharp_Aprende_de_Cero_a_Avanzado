using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class SnakeGame
{
    static int width = 30, height = 20;
    static int score = 0, highScore = 0;
    static int speed = 10;
    static bool gameOver = false, paused = false;
    static Random rand = new Random();

    static List<(int x, int y)> snake = new List<(int x, int y)>();
    static (int x, int y) fruit;
    static List<(int x, int y)> obstacles = new List<(int x, int y)>();

    static int dx = 1, dy = 0; // dirección inicial

    static void Main()
    {
        Console.Title = "Snake Game 2.0";
        Console.CursorVisible = false;

        LoadHighScore();
        Menu();

        while (true)
        {
            StartGame();
            GameLoop();
            GameOver();
        }
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("=== SNAKE 2.0 ===");
        Console.WriteLine("1. Jugar");
        Console.WriteLine("2. Salir");
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.D2) Environment.Exit(0);
    }

    static void StartGame()
    {
        gameOver = false;
        paused = false;
        score = 0;
        speed = 10;
        snake.Clear();
        snake.Add((width / 2, height / 2));
        dx = 1; dy = 0;

        fruit = (rand.Next(1, width - 2), rand.Next(1, height - 2));
        obstacles.Clear();

        for (int i = 0; i < 5; i++)
            obstacles.Add((rand.Next(1, width - 2), rand.Next(1, height - 2)));
    }

    static void GameLoop()
    {
        while (!gameOver)
        {
            if (Console.KeyAvailable) HandleInput(Console.ReadKey(true).Key);

            if (!paused) Update();

            Draw();
            Thread.Sleep(1000 / speed);
        }
    }

    static void HandleInput(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow: if (dy != 1) { dx = 0; dy = -1; } break;
            case ConsoleKey.DownArrow: if (dy != -1) { dx = 0; dy = 1; } break;
            case ConsoleKey.LeftArrow: if (dx != 1) { dx = -1; dy = 0; } break;
            case ConsoleKey.RightArrow: if (dx != -1) { dx = 1; dy = 0; } break;
            case ConsoleKey.P: paused = !paused; break;
            case ConsoleKey.Escape: gameOver = true; break;
        }
    }

    static void Update()
    {
        var head = snake[0];
        var newHead = (x: head.x + dx, y: head.y + dy);

        // Verificar colisiones
        if (newHead.x <= 0 || newHead.x >= width - 1 || newHead.y <= 0 || newHead.y >= height - 1
            || snake.Contains(newHead) || obstacles.Contains(newHead))
        {
            gameOver = true;
            return;
        }

        snake.Insert(0, newHead);

        if (newHead == fruit)
        {
            score += 10;
            if (score % 50 == 0) speed++; // sube nivel
            fruit = (rand.Next(1, width - 2), rand.Next(1, height - 2));
        }
        else
        {
            snake.RemoveAt(snake.Count - 1);
        }
    }

    static void Draw()
    {
        Console.Clear();

        // Bordes
        for (int x = 0; x < width; x++) Console.Write("#");
        Console.WriteLine();
        for (int y = 1; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x == 0 || x == width - 1) Console.Write("#");
                else if ((x, y) == snake[0]) { Console.ForegroundColor = ConsoleColor.Green; Console.Write("O"); Console.ResetColor(); }
                else if (snake.Contains((x, y))) { Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("o"); Console.ResetColor(); }
                else if ((x, y) == fruit) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("F"); Console.ResetColor(); }
                else if (obstacles.Contains((x, y))) { Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("X"); Console.ResetColor(); }
                else Console.Write(" ");
            }
            Console.WriteLine();
        }

        for (int x = 0; x < width; x++) Console.Write("#");
        Console.WriteLine();
        Console.WriteLine($"Score: {score}  |  HighScore: {highScore}  |  Velocidad: {speed}");
        if (paused) Console.WriteLine("== PAUSADO ==");
    }

    static void GameOver()
    {
        if (score > highScore)
        {
            highScore = score;
            SaveHighScore();
        }

        Console.Clear();
        Console.WriteLine("=== GAME OVER ===");
        Console.WriteLine($"Tu puntaje: {score}");
        Console.WriteLine($"Mejor puntaje: {highScore}");
        Console.WriteLine("Presiona ENTER para jugar de nuevo o ESC para salir.");

        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Enter) return;
            if (key == ConsoleKey.Escape) Environment.Exit(0);
        }
    }

    static void LoadHighScore()
    {
        if (File.Exists("highscore.txt"))
            highScore = int.Parse(File.ReadAllText("highscore.txt"));
    }

    static void SaveHighScore()
    {
        File.WriteAllText("highscore.txt", highScore.ToString());
    }
}