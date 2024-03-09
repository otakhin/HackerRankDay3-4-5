using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay4
{
    internal class Person
    {

        public int age;
        public Person(int initialAge)
        { // Add some more code to run some checks on initialAge


            if (initialAge < 0) 
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else age = initialAge;
           
        }
        public void amIOld()
        {
            if(age < 13) 
            {
                Console.WriteLine("You are young");
            }
            else if(age >=13 && age < 18)
            {

                Console.WriteLine("You are teenager");
            }
            else { Console.WriteLine("You are old "); }
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age++;
        }


        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();



            }
        }
    }
}
