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
            gameState.Draw();
            gameState.Run(); //Run for Timer

            while (gameState.isAlive)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                gameState.PressedKey(consoleKeyInfo);
            }
        }
        
        public Program()
        {

        }
    }
}
