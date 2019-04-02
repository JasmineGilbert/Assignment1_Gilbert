using System;

namespace Assignment1_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 25;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("Q2 : The sum of the series is: " + r1);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);



            // I started the project by creating a program that required responses from end user
            // I then learmed how to develop the program as per the example Program.cs file.
            //Q1, 3 and 4, i figured out with no issue. 
            //I struggled with Q2, the harmonic/factoral pattern but I think I figured it out. 




            Console.ReadKey();

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                string primeSeries = "";
                //establish start and and end numbers
                for (int i = x; i < y; i++)
                    if (isPrime(i))
                        primeSeries += i.ToString() + ",";


                Console.WriteLine("Q1 : " + primeSeries.TrimEnd(','));


            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        private static bool isPrime(int n)
        {
            try
            {                //determine the prime numbers
                bool isPrime = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static double getSeriesResult(int n)
        {
            try
            {
                double oddSum = 0;
                double evenSum = 0;
                double factorial = 0;
                // initialize counter for either pattern 
                for (int i = 1; i <= n; i++)
                {
                    factorial = getFactorial(i);
                    //odd number
                    if (i % 2 == 1)
                        oddSum += factorial / (i + 1);

                    //even number
                    else
                        evenSum += factorial / (i + 1);
                }
                // alternate signs
                double sum = oddSum - evenSum;
                //round to three decimal places
                return Math.Round(sum, 3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }


        private static long getFactorial(int n)
        {            //calc numerator
            long factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;


            return factorial;
        }







        public static void printTriangle(int n)
        {
            try
            {
                Console.WriteLine("Q3 : ");
                // intialize counter
                for (int i = 1; i < n; i++)
                {                    //highest row start
                    for (int j = 0; j < n - i; j++)
                        Console.Write(" ");



                    for (int k = 0; k < i; k++)
                        Console.Write("*");


                    //lowest row end
                    for (int l = i - 1; l >= 1; l--)
                        Console.Write("*");



                    Console.Write("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                Console.WriteLine("Q4 : ");

                if (a != null)
                {
                    int counter = 0;                    //pull in array, count number within array
                    int[] freqArr = new int[a.Length];
                    //initialize counter
                    for (int i = 0; i < a.Length; i++)
                        freqArr[i] = -1;

                    for (int i = 0; i < a.Length; i++)
                    {
                        counter = 1;
                        for (int j = i + 1; j < a.Length; j++)
                        {
                            if (a[i] == a[j])
                            {
                                counter++;
                                freqArr[j] = 0;
                            }
                        }
                        // counter 2 for alternate line
                        if (freqArr[i] != 0)
                            freqArr[i] = counter;



                    }
                    Console.WriteLine("Number \t Frequency");

                    for (int i = 0; i < a.Length; i++)
                        if (freqArr[i] != 0)
                            Console.WriteLine(a[i] + " \t " + freqArr[i]);

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

    }
}
