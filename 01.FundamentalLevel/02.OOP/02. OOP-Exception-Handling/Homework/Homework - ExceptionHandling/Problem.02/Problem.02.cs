using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem._02
{
    internal class EnterNumbers
    {
        private static void Main()
        {
            int start = 0;
            int end = 0;
            start:
            try
            {
                start = int.Parse(Console.ReadLine());
                end = int.Parse(Console.ReadLine());
                ReadNumber(start, end);
            }
            catch (Exception)
            {
                Console.WriteLine("You entered invalid number ! Numbers must be between 1 and 100");
                try
                {
                    start = int.Parse(Console.ReadLine());
                    end = int.Parse(Console.ReadLine());
                    ReadNumber(start, end);
                }
                catch (Exception)
                {
                    goto start;
                }
            }

            Console.ReadLine();
        }

        private static void ReadNumber(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
