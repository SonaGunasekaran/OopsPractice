using System;

namespace OOpsPractice
{


    class Program
    {

        public static void Main(string[] args)
        {
            int empPresent = 1;
            
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (empInput == 1)
            {
                Console.WriteLine("Employee is Present");

                
          
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }


        }
    }

}
    
    
           