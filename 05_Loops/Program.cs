using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            //For Loop
            //for(initializes variable; condition; do something with my variable)
            int studentCount = 5;
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }


            //Foreach Loop
            
            List<string> students = new List<string>();
            students.Add("Andrea");
            students.Add("Anna");
            students.Add("Collin");
            students.Add("Danny");
            foreach(string student in students)
            {
                Console.WriteLine(student);
            }

            //Do While Loop
            int iterator = 0;
            do{
                Console.WriteLine("Hello");
                iterator++;
            }
            while (iterator < 5);



            Console.ReadKey();
        }
    }
}
