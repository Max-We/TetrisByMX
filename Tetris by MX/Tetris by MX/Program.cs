using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_by_MX
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "X";

            int x1, x2, x3, x4, x5, x6, x7, x8;
            int M = 1;

            Console.SetWindowSize(21, 22);
            Console.BufferHeight = 22;
            Console.BufferWidth = 22;

            ConsoleKeyInfo cki;
            int mx, my;

            // Startwerte
            mx = Console.BufferWidth / 2;
            my = 2;
            // Block 1
            x1 = x2 = x6 = x7 = x8 = 0;
            x3 = x4 = x5 = 1;

            // Block 2
            //x1 = x3 = x4 = x5 = x6 = 0;
            //x2 = x7 = x8 = 0;


            int posX = mx;
            int posY = my;

            //Start
            if (x1 != 0)
            {
                Console.SetCursorPosition(mx - 1, my + 1);
                Console.Write(b);
            }
            if (x2 != 0)
            {
                Console.SetCursorPosition(mx, my + 1);
                Console.Write(b);
            }
            if (x3 != 0)
            {
                Console.SetCursorPosition(mx + 1, my + 1);
                Console.Write(b);
            }
            if (x4 != 0)
            {
                Console.SetCursorPosition(mx - 1, my);
                Console.Write(b);
            }
            if (x5 != 0)
            {
                Console.SetCursorPosition(mx + 1, my);
                Console.Write(b);
            }
            if (x6 != 0)
            {
                Console.SetCursorPosition(mx - 1, my - 1);
                Console.Write(b);
            }
            if (x7 != 0)
            {
                Console.SetCursorPosition(mx, my - 1);
                Console.Write(b);
            }
            if (x8 != 0)
            {
                Console.SetCursorPosition(mx + 1, my - 1);
                Console.Write(b);
            }

            // Drehen
            int counter = 0;
            cki = Console.ReadKey();
            while (Console.ReadKey() != new ConsoleKeyInfo())
            {


                switch (cki.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (counter == 0)
                        {
                            x1 = x3 = x4 = x5 = x6 = 0;
                            x2 = x7 = x8 = 0;
                            counter = 1;
                        }
                        else if (counter == 1)
                        {
                            x1 = x2 = x3 = x7 = x8 = 0;
                            x4 = x5 = x6 = 1;
                            counter = 2;

                        }
                        else if (counter == 2)
                        {
                            x3 = x4 = x5 = x6 = x8 = 0;
                            x1 = x2 = x7 = 1;
                            counter = 3;
                        }
                        else if (counter == 3)
                        {
                            x1 = x2 = x6 = x7 = x8 = 0;
                            x3 = x4 = x5 = 1;
                            counter = 0;
                        }
                        break;

                }

                Console.SetCursorPosition(mx - 1, my + 1);
                Console.Write("");
                Console.SetCursorPosition(mx, my + 1);
                Console.Write("");
                Console.SetCursorPosition(mx + 1, my + 1);
                Console.Write("");
                Console.SetCursorPosition(mx - 1, my);
                Console.Write("");
                Console.SetCursorPosition(mx + 1, my);
                Console.Write("");
                Console.SetCursorPosition(mx - 1, my - 1);
                Console.Write("");
                Console.SetCursorPosition(mx, my - 1);
                Console.Write("");
                Console.SetCursorPosition(mx + 1, my - 1);
                Console.Write("");

                Console.SetCursorPosition(mx, my);
                Console.Write(b);

                if (x1 != 0)
                {
                    Console.SetCursorPosition(mx - 1, my + 1);
                    Console.Write(b);
                }
                if (x2 != 0)
                {
                    Console.SetCursorPosition(mx, my + 1);
                    Console.Write(b);
                }
                if (x3 != 0)
                {
                    Console.SetCursorPosition(mx + 1, my + 1);
                    Console.Write(b);
                }
                if (x4 != 0)
                {
                    Console.SetCursorPosition(mx - 1, my);
                    Console.Write(b);
                }
                if (x5 != 0)
                {
                    Console.SetCursorPosition(mx + 1, my);
                    Console.Write(b);
                }
                if (x6 != 0)
                {
                    Console.SetCursorPosition(mx - 1, my - 1);
                    Console.Write(b);
                }
                if (x7 != 0)
                {
                    Console.SetCursorPosition(mx, my - 1);
                    Console.Write(b);
                }
                if (x8 != 0)
                {
                    Console.SetCursorPosition(mx + 1, my - 1);
                    Console.Write(b);
                }

            }

            Console.ReadKey();

        }
    }
}
