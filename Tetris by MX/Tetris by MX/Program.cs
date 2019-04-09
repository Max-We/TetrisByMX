using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_by_MX
{
    class Program
    {
        static void Main(string[] args)
        {


            int x1, x2, x3, x4, x5, x6, x7, x8;

            Console.SetWindowSize(21, 22);
            Console.BufferHeight = 22;
            Console.BufferWidth = 21;

            ConsoleKeyInfo cki;


            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak("Willkommen bei Tetris, Los gehts");
          


            // Zeit - Mess - Modul
            Printer prints = new Printer();





            // Drehen L R
            LBlock LBlock = new LBlock();

            int counter = 0;

            DateTime t1 = DateTime.Now;
            int ms = t1.Millisecond;
            DateTime t2 = DateTime.Now;
            int ms2 = t2.Millisecond;
            LBlock.startBlock();
            cki = Console.ReadKey();

            int z = 0;

            while (true)
            {
                t2 = DateTime.Now;
                int checker = (t2.Millisecond - t1.Millisecond + 1000) % 1000;
                if (checker > 450)
                {
                    LBlock.travelDown();
                    LBlock.printL();
                    t1 = t2;
                }


                if (Console.KeyAvailable)
                {

                    cki = Console.ReadKey();

                    switch (cki.Key)
                    {

                        case ConsoleKey.D:
                            LBlock.turnRight(counter);
                            counter = LBlock.turnRight(counter);
                            break;

                        case ConsoleKey.A:
                            LBlock.turnLeft(counter);
                            counter = LBlock.turnLeft(counter);
                            break;

                        case ConsoleKey.RightArrow:
                            LBlock.moveRight();
                            break;

                        case ConsoleKey.LeftArrow:
                            LBlock.moveLeft();
                            break;
                    }

                    LBlock.printL();



                }
                if (LBlock.checkHeight() == true)
                {
                    z++;
                    if (z >2)
                    {

                    }
                }
            }
            


        }
    }
}
