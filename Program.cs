﻿using System;

namespace OOpsPractice
{


    class Program
    {
        public static void Main(string[] args)
        {
            int partTime = 2;
            int fullTime = 1;
            int empHour = 0;
            int empWage = 0;
            int empPerHour = 20;
            Random random = new Random();
            int empInput = random.Next(0, 3);
            if (empInput == fullTime)
            {
                Console.WriteLine("Employee is Working Fulltime");

                empHour = 9;

            }
            else if (empInput == partTime)
            {
                Console.WriteLine("Employee is Working Partime");

                empHour = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");

                empHour = 0;
            }

            empWage = empPerHour * empHour;
            Console.WriteLine("The daily wage of the employee = " + empWage);




        }
    }

}
    
    
           