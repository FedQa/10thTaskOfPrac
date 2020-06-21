using System;

namespace Task10
{
    class Program
    {
        static void Input(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"x-{i+1} element");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        static void Print(int[] x)
        {
            int l = 0;
            int N = x.Length;
            int[] temp = new int[N];
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Mas{i}:");
                
                for (int j = 0; j < N; j++)
                {
                    temp[l] = x[j];
                    Console.Write(temp[l] + " ");
                    l++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input N>=2");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 2) Console.WriteLine("Input isn't correct!");
            int[] x = new int[N];
            Console.WriteLine("Input mas:");
            Input(x);
            Print(x);

        }
    }
}
