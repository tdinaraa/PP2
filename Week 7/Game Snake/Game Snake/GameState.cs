﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;

namespace Game_Snake
{
    [Serializable]

    public class GameState
    {
        Timer DrawSnake = new Timer(350);

        public Snake s = new Snake('*');
        public Food f = new Food('$');
        public Wall w = new Wall('1', 1); //sign и начинается с первого уровня

        public int lvl = 1;
        public int maxScore = 3;
        public bool isAlive;


        public void Run ()
        {
            DrawSnake.Elapsed += DrawSnake_Elapsed;
            DrawSnake.Start();
        }


        public void DrawSnake_Elapsed (object sender, ElapsedEventArgs e)
        {
            if (isAlive==false)
            {
                DrawSnake.Stop();
                return;
            }

            s.Clear();
            s.Move();
            s.Draw();
            CheckFood();
            CheckWall();
            CheckSnake();
        }

       

        public GameState()
        {
            isAlive = true;
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
            Console.SetCursorPosition(5, 35);
            Console.Write("SNAKE GAME--- Author:");
            string name = Console.ReadLine();
        }

        public void Draw()
        {
            f.Draw();
            w.Draw();
        }

        public void CheckFood() //съел или нет
        {
            if (s.CheckCollision(f.body[0])) //snake checks with food
            {
                s.Eat(f.body[0]);
                s.score++;
                do
                {
                    f.Generate();
                }
                while (!CheckFoodSnake());

                f.Draw();


                Console.SetCursorPosition(5, 32);
                Console.Write("Score: " +s.score);
            }
        }

        bool CheckFoodSnake()
        {
            for (int i=0; i<s.body.Count; i++)
            {
                if (s.body[i].X == f.body[0].X && s.body[i].Y == f.body[0].Y)
                {
                    return false;
                }
            }
            return true;
        }

        public void CheckWall()
        {
            for (int i=0; i<w.body.Count; i++)
            {
                if (s.CheckCollision(w.body[i]))
                {
                    isAlive = false;
                    Console.SetCursorPosition(10, 37);
                    Console.Write("You died!");
                    break;
                }
            }
            
            if (s.score>maxScore)
            {
                DrawSnake.Interval -= 100;
                lvl++;
                maxScore += 3;
                Console.Clear();
                Console.SetCursorPosition(10, 35);
                Console.Write("SNAKE GAME--- Author:");


                Console.SetCursorPosition(25, 37);
                Console.Write("Level: " + lvl);
                if (lvl == 2)
                {
                    w = new Wall('2', lvl);
                }

                if (lvl == 3)
                {
                    w = new Wall('3', lvl);
                }

                Draw();
            }            
        }

        void CheckSnake()
        {
            for (int i = 1; i < s.body.Count; i++)
            {
                if (s.CheckCollision(s.body[i]))
                {
                    isAlive = false;
                    Console.SetCursorPosition(10, 35);
                    Console.Write("You died!");
                    break;
                }
            }
        }

        public void Save()
        {
            FileStream fs = new FileStream("info.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(GameState));
            xs.Serialize(fs, this);
            fs.Close();
        }


        public static GameState Load()
        {
            FileStream fs = new FileStream("info.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(GameState));
            GameState gs = xs.Deserialize(fs) as GameState;
            fs.Close();
            return gs;
        }
    

    public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    s.dx = 0;
                    s.dy = -1;                
                    break;
                case ConsoleKey.DownArrow:
                    s.dx = 0;
                    s.dy = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    s.dx = -1;
                    s.dy = 0;
                    break;
                case ConsoleKey.RightArrow:
                    s.dx = 1;
                    s.dy = 0;
                    break;
                case ConsoleKey.S:
                    Save();
                    break;
                case ConsoleKey.L:
                    Load();
                    break;
                case ConsoleKey.Spacebar:
                    DrawSnake.Enabled = !DrawSnake.Enabled;
                    break;
            }

            //CheckFood();
            //CheckWall();
            //CheckSnake();
        }


    }
}
