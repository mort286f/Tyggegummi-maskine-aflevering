using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave___Tyggegummimaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gums = new int[55];

            Console.WriteLine("Maskinen er klar til brug");
            Console.WriteLine("Tryk enter for at få et tyggegummi");
            Console.ReadLine();
            Console.Clear();
            Random random = new Random();

            Dispenser dispenser = new Dispenser();


            int blueCount = 13;
            int purpleCount = 6;
            int yellowCount = 10;
            int orangeCount = 9;
            int redCount = 6;
            int greenCount = 5;
            int gumCount = blueCount + purpleCount + yellowCount + orangeCount + redCount + greenCount;

            do
            {
                int ran = random.Next(1, 7);
                Console.WriteLine();
                switch (ran)
                {
                    case 1:
                            Console.WriteLine("You got a blue bubblegum");
                        if (blueCount != 0)
                        {
                            dispenser.blue[blueCount] = null;
                            blueCount--;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 2:
                            Console.WriteLine("You got a purple bubblegum");
                        if (purpleCount != 0)
                        {
                            dispenser.purple[purpleCount] = null;
                            purpleCount--;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 3:
                            Console.WriteLine("You got a yellow bubblegum");
                        if (yellowCount != 0)
                        {
                            dispenser.yellow[yellowCount] = null;
                            yellowCount--;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 4:
                            Console.WriteLine("You got an orange bubblegum");
                        if (orangeCount != 0)
                        {
                            dispenser.orange[orangeCount] = null;
                            orangeCount--;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 5:
                            Console.WriteLine("You got a red bubblegum");
                        if (redCount != 0)
                        {
                            dispenser.red[redCount] = null;
                            redCount--;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 6:
                            Console.WriteLine("You got a green bubblegum");
                        if (greenCount != 0)
                        {
                            dispenser.green[greenCount] = null;
                            greenCount--;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.WriteLine("Machine is now empty");
                        break;
                }
            } while (gumCount != 0);
        }
    }
}
