using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number:");
                float number = float.Parse(Console.ReadLine());
                Calculate C1 = new Calculate();
                Console.WriteLine($"Square of {number}={C1.Square(number)}");
                Console.WriteLine($"Cube of {number}={C1.Cube(number)}");
            }
            catch (ArgumentNullException EX)
            {
                Console.WriteLine(EX.Message);
            }
            catch (FormatException EX)
            {
                Console.WriteLine("Enter only digit numbers!!!");
            }
            catch (OverflowException EX)
            {
                Console.WriteLine(EX.Message);
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
