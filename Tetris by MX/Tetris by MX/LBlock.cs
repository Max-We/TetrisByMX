using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_by_MX
{
    class LBlock
    {
        private int x1, x2, x3, x4, x5, x6, x7, x8;
        private int mx = 0;
        private int my = 0;
        
        Printer print = new Printer();

        public void startBlock()
        {
            x1 = x2 = x6 = x7 = x8 = 0;
            x3 = x4 = x5 = 1;

            if (mx == 0 && my == 0)
            {
                mx = Console.BufferWidth / 2;
                my = 2;
            }
        }

        public void travelDown()
        {
            my++;
            if (my == 21)
            {
                my = 20;
            }


        }

        public bool checkHeight()
        {
            if (my == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int turnRight(int counter)
        {
            if (counter == 0)
            {
                x1 = x3 = x4 = x5 = x6 = 0;
                x2 = x7 = x8 = 1;
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

            return(counter);
        }

        public int turnLeft(int counter)
        {
            if (counter == 0)
            {
                x3 = x4 = x5 = x6 = x8 = 0;
                x1 = x2 = x7 = 1;
                counter = 3;
            }
            else if (counter == 1)
            {
                x1 = x2 = x6 = x7 = x8 = 0;
                x3 = x4 = x5 = 1;
                counter = 0;

            }
            else if (counter == 2)
            {
                x1 = x3 = x4 = x5 = x6 = 0;
                x2 = x7 = x8 = 1;
                counter = 1;
            }
            else if (counter == 3)
            {
                x1 = x2 = x3 = x7 = x8 = 0;
                x4 = x5 = x6 = 1;
                counter = 2;
            }

            return(counter);
        }

        public void moveRight()
        {
            mx++;
            if (mx == 20)
            {
                mx = 19;
            }
        }

        public void moveLeft()
        {
            mx--;
            if (mx == 0)
            {
                mx = 1;
            }
        }
        public void printL()
        {
            Printer print = new Printer();
            print.PrintL(x1, x2, x3, x4, x5, x6, x7, x8, mx, my);
        }
    }
}

