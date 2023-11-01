using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MiniGane_WillB
{
    internal class Program
    {

        static string[] player;
        
        static int x=30;
        static int y=30;
        static int xmax = 30;
        static int ymax = 15;
        static int xmin = -30;
        static int ymin = -15;
        static void Main(string[] args)
        {

            Console.SetWindowSize(xmax,ymax);
            Console.WriteLine("MiniGame");
            Console.ReadKey();
            player = new string[2];
            player[0] = "*";
           
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
