using System;

public static class Exercise1
{
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }

        Console.Write(array[array.Length - 1]);

        Console.WriteLine();
    }

    public static void SumAndProduct(int[] array)
    {
        int sum = 0;
        int product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        Console.WriteLine(sum + ", " + product);
    }

    public static void PrintPairs(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[i] + "," + array[j]);
            }
        }
    }

    public static void PrintUnorderedPair(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                Console.WriteLine(array[i] + "," + array[j]);
            }
        }
    }

    public static void PrintUnorderedPairs(int[] arrayA, int[] arrayB)
    {
        for (int i = 0; i < arrayA.Length; i++)
        {
            for (int j = 0; j < arrayB.Length; j++)
            {
                Console.WriteLine(arrayA[i] + "," + arrayB[j]);
            }
        }
    }

    public static void PrintUnorderedPairsWithConstantArray(int[] arrayA, int[] arrayB)
    {
        for (int i = 0; i < arrayA.Length; i++)
        {
            for (int j = 0; j < arrayB.Length; j++)
            {
                for (int k = 0; k < 100000; k++)
                {
                    Console.WriteLine(arrayA[i] + "," + arrayB[j]);
                }
            }
        }
    }

    public static void Reverse(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int last = array.Length - i - 1;
            int aux = array[i];

            array[i] = array[last];
            array[last] = aux;
        }
    }

    public static bool IsPrime(int n)
    {
        bool isPrime = false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;

            isPrime = true;
        }
        return isPrime;
    }

    public static int Factorial(int n)
    {
        if (n < 0) return -1;

        else if (n == 0) return 1;

        return n * Factorial(n - 1);
    }

    public static void Permutation(string str)
    {
        Permutation(str, "");
    }

    public static void Permutation(string str, string prefix)
    {
        if (str.Length == 0) Console.WriteLine(prefix);
        else
        {
            for (int i = 0; i < str.Length; i++)
            {
                string ren = str.Substring(0, i) + str.Substring(i + 1);
                Permutation(ren, prefix + str[i]);
            }
        }
    }

    public static int Fibonacci(int f)
    {
        if (f <= 0) return 0;
        else if (f == 1) return 1;

        return Fibonacci(f - 1) + Fibonacci(f - 2);
    }

    public static void PrintFibonacci(int f)
    {
        for (int i = 0; i < f; i++)
        {
            Console.WriteLine(i + ": " + Fibonacci(i));
        }
    }

    public static int Fibonacci(int f, int[] memo)
    {
        if (f <= 0) return 0;
        else if (f == 1) return 1;
        else if (memo[f] > 0) return memo[f];

        memo[f] = Fibonacci(f - 1, memo) + Fibonacci(f - 2, memo);

        return memo[f];
    }

    public static void PrintFibonacciWithMemo(int f)
    {
        int[] memo = new int[f + 1];

        for (int i = 0; i < f; i++)
        {
            Console.WriteLine(i + ": " + Fibonacci(i, memo));
        }
    }

    public static int PowerOfTwo(int p)
    {
        if (p < 1) return 0;
        else if (p == 1)
        {
            Console.WriteLine(1);
            return 1;
        }
        else
        {
            int prev = PowerOfTwo(p / 2);
            int curr = prev * 2;
            Console.WriteLine(curr);
            return curr;
        }
    }
}