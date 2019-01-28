using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
           // Console.ReadKey(true);



            long n2 = 15;
            long [] r2 = decimalToBinary(n2);
            Console.WriteLine(" : is the Binary conversion of the decimal number " + n2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadKey(true);

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int a, int b)
        {
            try
            {
                int i, j, fact = 0;
                for (i = a; i <= b; i++) //Running the loop from a=5 to b=15
                {
                    for (j = 1; j < i; j++) // Running the loop of j from 2 to i
                    {
                        if (i % j == 0) // checking if j is the factorial 
                        {
                            fact = fact + 1; // Increasing the value of # of Factorials
                        }
                    }
                    if (fact == 1) // There should be only one factorial, the number itself
                    {
                        Console.Write(i); 
                        Console.WriteLine(" Is a prime number");
                    }
                    fact = 0; // Reinitialing the value of the fact to zero for the iteration.
                }
                
               // Console.ReadKey(true);
            } 
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static int Facto (int f)
        {
            int i, fact = 1;
            for (i = 1; i <= f; i++)
            {
                fact = fact * i;
                
            }
            return fact;
        }

        public static double getSeriesResult(int n1)
        {
            try
            {
                double pos = 0.000, neg = 0.000, sum = 0.000;
                int i;

                for (i = 1; i <= n1; i++)
                {
                    if (i % 2 != 0)
                    {
                        pos = pos + (Facto(i) / (i + 1));
                    }
                    else
                    {
                        neg = neg + (Facto(i) / (i + 1));
                    }

                }
                sum = pos - neg;
                return sum;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static long [] decimalToBinary(long n)
        {
            try
            {
                int i = 0, size = 0;
                long dup;
                dup = n;
                


        while (dup > .49)
                {
                    size = size + 1;
                    dup = dup / 2;
                }
                long[] store = new long [size];

                while (n > .49)
                {

                    if (n % 2 == 0)
                        store[i] = 0;
                    else
                        store[i] = 1;
                    i++;
                    n = n / 2;
                }

                long a = store.Length;
                long[] arr = new long[a];
                int k = 0;
                for (long j = a - 1; j >= 0; j--)
                {
                    //store[j] = arr[k];
                    Console.Write(store[j]);
                    k++;
                }
                
                return arr;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return null;
        }



        public static long power(long q)
        {
            long result = 1;

            if (q == 0)
            {
                return 1;
            }

            else
            {
                for (int i = 1; i <= q; i++)
                {
                    result = result * 2;
                }
                return result;
            }
        }




        public static long binaryToDecimal(long n3)
        {
            try
            {
                long sum = 0, dup, size = 0;
                dup = n3; 

                while (dup > 0)
                {
                    size = size + 1;
                    dup = dup / 10;
                }
                
                // Console.WriteLine(size);
                long temp = 0;
                dup = n3;
               // Console.WriteLine(dup);
                
                for (int i = 0; i < size; i++)
                {
                    temp = temp * 10 + (dup % 10);
                    dup = dup/10;
                }
               
               // Console.WriteLine(temp);
                
               for (long i = size-1 ; i >= 0; i--)
                   
                {
                   sum = sum + (temp % 10)*(power(i));
                   temp = temp / 10;
                    //Console.Write("sum is +",sum);
                   // Console.WriteLine(power(i));
                  // Console.WriteLine();
                  //  sum = sum + power(i);
                  // Console.WriteLine(sum);
                }
                
                return sum;
            }
           




            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int times = 1, gap, x = n;
                string s = " ";

                for (int i = 1; i <= n; i++)

                {
                    for (gap = x - 1; gap > 0; gap--)

                    {
                        Console.Write(s);
                    }

                    for (int j = 1; j <= times; j++)

                    {


                        Console.Write("*");
                    }

                    x = x - 1;
                    times = times + 2;
                    Console.WriteLine("");
                    

                }
                //Console.ReadKey(true);
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
                int [] ar = a;
                int n = ar.Length;
                for (int j = 0; j < n; j++)
                {
                    ar[j] = ar[j] - 1;
                }

                for (int i = 0; i < n; i++)
                {
                    ar[ar[i] % n] = ar[ar[i] % n] + n;
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(i + 1 + "->" + ar[i] / n);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

