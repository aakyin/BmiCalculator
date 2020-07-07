using System;

namespace BmiCalculator
{
    //Name: Alvin Akyin
    //Course: CSCI 1630
    //Date: 02/06/2020
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of Variables
            int height, weight;
            double tr, mtz;
            int age, rhr, hrr, mhr;
            double ttz = 0.0;

            //BMI Declarations
            double bmi = 0;
            double kilograms, meters;
            int inches, pounds;
            string classification = "";
           
            //Inout and Output Datas
            Console.WriteLine("BMI and Karvonen Calculator\n\n");
            Console.WriteLine("Please enter the following value for the user...\n\n");

            Console.WriteLine("Height in inches: ");
            inches = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Weight in pounds: ");
            pounds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resting heart rate: ");
            rhr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nResults...\n\n");

            //Calculation of bmi
            kilograms = pounds / 2.2046;
            meters = inches / 39.37;
            bmi = kilograms / (meters * meters);

            //Using if-else statements
            if (bmi < 18.5)
            {
                classification = "Underweight";
            }
            else if (bmi < 25.0)
            {
                classification = "normal";
            }
            else if (bmi < 30.0)
            {
                classification = "Overweight";
            }
            else
            {
                classification = "Obese";
            }

            mhr = 220 - age;
            hrr = mhr - rhr;
           
            //Output of BMI result and Classification
            Console.WriteLine("Your BMI is: "+ bmi + " -- " + classification);

            //Output Data of the following written codes
            Console.WriteLine("Exercise Intensity Heart Rates\n");
            Console.WriteLine("Intensity  Max Heart Rate\n");
            
            //Using for Loop in calculating the intensity and max heart rate
            for (tr = 0.5; tr <= 0.95; tr = tr + 0.05)
            {
                mtz = hrr * tr;
                ttz = mtz + rhr;

                Console.WriteLine(tr * 100 + "%  \t -- \t"  + ttz);

            }

        }
    }

 }
    

