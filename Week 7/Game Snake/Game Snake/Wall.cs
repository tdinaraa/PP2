using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Snake
{
    [Serializable]
    public class Wall
    {

        public List<Point> body = new List<Point>();
        protected char sign;

        public Wall(char sign, int level)
        {
            this.sign = sign;
            this.body.Clear();
            LoadLevel(level);
        }

        public void LoadLevel(int level)
        {
            string name = string.Format("Levels/Level{0}.txt", level);
            StreamReader sr = new StreamReader(name);

            int r = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                for (int c = 0; c < line.Length; ++c)
                {
                    if (line[c] == '#')
                    {
                        body.Add(new Point { X = c, Y = r }); //Y=r (r отвечает за координату y)
                    }
                }
                r++;
            }

            sr.Close();
        }
        public void Clear()
        {
            for (int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(' ');
            }
        }

        public void Draw()
        {
            for (int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(sign);
            }
        }
        public Wall ()
        {

        }
    }
}
