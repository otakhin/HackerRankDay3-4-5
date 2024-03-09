using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCampEnginDemirog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*while (true) {
                Console.WriteLine("lÜTFEN SAYİYİ GİRİNİZ");

                int sayi = Convert.ToInt32(Console.ReadLine());


                if (sayi <5 ) 
                
                {
                    
                    Console.WriteLine("Sayı değişti");
                    Console.WriteLine(sayi = 3);

                
                }
                else 
                {

                    Console.WriteLine(" Sayı sabit kaldı ");
                    Console.WriteLine(sayi);

                
                
                
                }
                Console.ReadLine ();


                if(sayi == 7) 
                {

                    int total=3;

                    for (int i = total; total < 10; i++) 
                    {


                        total += sayi;
                    
                    }
                
                    Console.WriteLine(total);
                    Console.ReadLine();

                
                }



            }*/
            string kurs1 = "Yazılım geliştirici kampı";
            string kurs2 = "Temel Kurs ";
            string kurs3 = "Java kurs";

            string[] kurslar = new string[]
            {
                "Yazılım geliştirici kampı","Temel Kurs ","Java kurs"
            };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Sayfa sonu");

            Console.ReadLine();









        }
    }
}
