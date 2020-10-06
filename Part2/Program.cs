using System;
using System.Net;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pluggedIn = true;
            
            if (pluggedIn)
            {
                bool burnedOut = true;

                if (burnedOut)
                {
                    Console.WriteLine("Replace the bulb.");
                }
                else
                {
                    Console.WriteLine("Repair the lamp.");
                }
            }
            else
            {
                Console.WriteLine("Plug in the lamp.");
            }
        }
    }
}
