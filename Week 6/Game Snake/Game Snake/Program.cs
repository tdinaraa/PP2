using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Snake
{
    [Serializable]
    public class Program
    {     
        static void Main(string[] args)
        {         

            GameState gameState = new GameState();

            while (gameState.isAlive)
            {
                gameState.Draw();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                gameState.PressedKey(consoleKeyInfo);
            }
        }
        
        public Program()
        {

        }
    }
}
