using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n4 = 5;
            printTriangle(n4);
            int a = 5, b = 15;
            PrintPrimeNumbers(a, b);
            int n = 5;
            double result = getSeriesResult(n);
            Console.WriteLine("The Result is: " + result);
            Console.ReadLine();
            int[] aa = new int[] { 1, 3, 5, 7, 9, 1, 2, 1 };
            computeFrequency(aa);
        }

   //reflection: this took 8-10 hrs because I have 0 experience with C# and programming in general
   //I did learn a lot through out the assignment but wish there was more content available for C# basics


        public static void printTriangle(int n)
        {
            try
            {

 //for loops will print the quantity of stars and spaces on each line and limited it to 5

                int i, j, k;
                for (i = 1; i <= 5; i++)
                {
                    for (j = i; j < 5; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k < (i * 2); k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }


        public static void PrintPrimeNumbers(int a, int b)
        {


            try
            {

 //the for loops will loop through 5 and 25 with increments of 1

                bool isPrime = true;

                for (int x = 5; x <= 25; x++)
                {
                    for (int y = 5; y <= 25; y++)
 
  //if x is not = to y and x / y has no remainder then x is not prime

                        if (x != y && x % y == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        System.Console.WriteLine("\t" + x);

                    }
                    isPrime = true;

                }

            }

            catch
            {

            }
        }


        public static int getFactorial(int n)
        {
//every number other than 1 has to be multiped by n-1 which calculate the factorial
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * getFactorial(n - 1);
            }
        }
        public static double getSeriesResult(int n)
        {
            double seriesResult = 0;
            try
            {
                for (int i = 1; i<=n;i++)
                {
                //if even it will be negative
                // convertsit to a double 
                //rounds to 3 decimal places
          
                if (i % 2 == 0)
                    {
                        double temp = (double)getFactorial(i) / (i + 1);
                        seriesResult -= Convert.ToDouble(temp.ToString("N3"));

                    //if odd it will be positive
                    // converts it to a double 
                    //rounds to 3 decimal places
                }
                else
                    {
                        double temp = (double)getFactorial(i) / (i + 1);
                    seriesResult += Convert.ToDouble(temp.ToString("N3"));
                       
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return seriesResult;
        }


        public static void computeFrequency(int[] a)
        {
            try
            {
                int[] frequency;
   //array called frequency will be as long as the largest number + 1 space
                frequency = new int[a.Max()+1];
                for (int i = 0; i < frequency.Length; i++)
                {
                    frequency[i] = 0;
                }
                for (int i = 0; i < a.Length; i++)
                {
  //counts the number of times given number is listed 
                    frequency[a[i]] = frequency[a[i]] + 1;
                }
                Console.WriteLine("Number Frequency");
                for (int i = 0; i < frequency.Length; i++)
                {
  //does not print numbers that are not listed in the array
                    if (frequency[i] > 0)
                    Console.WriteLine(i + "     " + frequency[i]);
                }
                Console.ReadLine();
            
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured while computing computeFrequency()"+ex.Message);
                Console.ReadLine();
            }
        }
    



}








}