using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter gverdi_1: ");
                float gverdi_1 = float.Parse(Console.ReadLine());
                Console.Write("Enter gverdi_2: ");
                float gverdi_2 = float.Parse(Console.ReadLine());
                Console.Write("Enter gverdi_3: ");
                float gverdi_3 = float.Parse(Console.ReadLine());
                Console.Write("Enter Height: ");
                float Height = float.Parse(Console.ReadLine());
                Class P = new Class();
                Console.WriteLine($"Samkutxedis perimetri = {P.Cal_1(gverdi_1, gverdi_2, gverdi_3)}");
                Class F = new Class();
                Console.WriteLine($"Samkutxedis fartobi = {F.Cal_2(gverdi_1, Height)}");
            }
            catch (ArgumentNullException EX)
            {
                Console.WriteLine(EX.Message);
            }
            catch (FormatException EX)
            {
                Console.WriteLine("Sheitanet mxolod ricxvebi!!!");
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
                Console.ReadLine();
            }
        }
    }
}
