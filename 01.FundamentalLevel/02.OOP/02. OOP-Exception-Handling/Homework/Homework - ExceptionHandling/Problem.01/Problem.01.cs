using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem._01
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                var srqtN = Math.Sqrt(n);
                Console.WriteLine(srqtN);
            }
            catch (Exception)
            {
                Console.WriteLine("You entered invalid number !");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }

            Console.ReadLine();
        }
    }
}
