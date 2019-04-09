using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_by_MX
{
    class Printer
    {



        public void PrintL(int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int mx, int my)
        {


            string b = "X";


            Console.Clear();
            if (x1 != 0)
            {
                Console.SetCursorPosition(mx - 1, my - 1);
                Console.Write(b);
            }
           
            if (x2 != 0)
            {
                Console.SetCursorPosition(mx, my - 1);
                Console.Write(b);
            }
            
            if (x3 != 0)
            {
                Console.SetCursorPosition(mx + 1, my - 1);
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
                Console.SetCursorPosition(mx - 1, my + 1);
                Console.Write(b);
            }
            
            if (x7 != 0)
            {
                Console.SetCursorPosition(mx, my + 1);
                Console.Write(b);
            }
            
            if (x8 != 0)
            {
                Console.SetCursorPosition(mx + 1, my + 1);
                Console.Write(b);
            }
            
            Console.SetCursorPosition(mx, my);
            Console.Write(b);
        }

    }
}
