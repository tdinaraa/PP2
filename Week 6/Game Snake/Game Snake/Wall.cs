using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Snake
{
    [Serializable]
    public class Wall : GameObject //wall унаследован от GameObject
    {
        public Wall(char sign, int level) : base(sign) //базовый класс
        {
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

        public Wall ()
        {

        }
    }
}
