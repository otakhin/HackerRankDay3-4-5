using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerRankDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int multiplesCount = 10;
            string allResult ="";
            for (int i = 1; i <= multiplesCount; i++)
            {
                

                int result = n * i;
               

                allResult +=  $"{n} x {i} = {result}\n";
            }
            Console.WriteLine(allResult);
            Console.ReadLine();




        }
    }
}
