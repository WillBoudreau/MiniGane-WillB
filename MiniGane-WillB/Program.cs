using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace MiniGane_WillB
{
    internal class Program
    {

        static string[] player;
        static string[] border;

        static int heightLeft;
        static int width;

        static int x=30;
        static int y=30;
        static int xmax = 60;
        static int ymax = 60;
        static int xmin = 15;
        static int ymin = 15;

        static void Main(string[] args)
        {
            border = new string[] { "-" };
            player = new string[2];
            player[0] = "*";

            heightLeft = Console.WindowHeight;
            width = Console.WindowWidth;

            for(int i = 0; i < heightLeft;  i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.WriteLine("|" + 0 + i);
                    Console.WriteLine("|" + 0 + j);

                }
                
            }
            
            Console.SetWindowSize(63,63);
            Console.WriteLine("MiniGame");
            Console.ReadKey();
            
            bool gameOver = false;
            while (gameOver != true)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey();
                
                if (y > ymax)
                {
                    y = ymax;
                } 
                if(y < ymin)
                {
                    y = ymin;
                }
                if( x > xmax)
                {
                    x = xmax;
                }
                if( x < xmin)
                {
                    x = xmin;
                }
                PlayerDraw();
                if (input.Key == ConsoleKey.W)//key on keyboard
                {
                    y--;
                            
                }
                if (input.Key == ConsoleKey.A)
                {
                            
                   x--;
                            
                }
                if (input.Key == ConsoleKey.D)
                {
                            
                   x++;
                            
                }
                if (input.Key == ConsoleKey.S)
                {
                            
                    y++;
                            
                }
                if (input.Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static void PlayerDraw()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(player[0]);
        }
    }
}
