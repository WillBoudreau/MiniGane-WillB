using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MiniGane_WillB
{
    internal class Program
    {

        static string[] player;
        static void Main(string[] args)
        {
            player[0] = "-";
            Console.WriteLine("MiniGame");
            Console.WriteLine();

            //Count 1 to 10
            //for(int i =  1 ; i <= 10; i++)
            {
               // Console.WriteLine(i);
            }
            int x=10;
            int y=10;
            bool gameOver = false;
             while(gameOver != true)
            {
                ConsoleKeyInfo input;
               input = Console.ReadKey();
                if(input.Key == ConsoleKey.W)//key on keyboard
                {
                    y--;
                }
                if(input.Key == ConsoleKey.A) 
                {
                    Console.Clear();
                    x--;
                    
                }
                if(input.Key == ConsoleKey.D)
                {
                    x++;
                }
                if(input.Key == ConsoleKey.S)
                {
                    y++;
                }
                Console.SetCursorPosition(x, y);
                Console.Write(player[0]);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
