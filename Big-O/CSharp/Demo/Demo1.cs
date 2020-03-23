using System;

namespace Demo
{
    class Node
    {
        public int Value { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

    }

    public class Solution
    {
        public static void Run()
        {
            // Level 0
            Node main = new Node() { Value = 4 };

            // Left Level 1
            main.Left = new Node() { Value = 7 };
            main.Left.Left = new Node() { Value = 10 };
            main.Left.Right = new Node() { Value = 2 };

            // Right Level 1
            main.Right = new Node() { Value = 9 };
            main.Right.Left = new Node() { Value = 6 };

            // Left Right Level 2
            main.Left.Right.Left = new Node() { Value = 6 };

            // Left Right Left Level 3
            main.Left.Right.Left.Left = new Node() { Value = 2 };

            PrintTree(main, 1);

            int[,] average = new int[0, 2];

            Console.WriteLine("-------------------------------------");
            GetAverageByLevel(main, ref average, 0);
            PrintArray(average);
        }

        static void PrintTree(Node tree, int depth)
        {
            if (tree == null) return;

            for (int i = 0; i < depth; i++)
                Console.Write("-");

            Console.WriteLine(tree.Value.ToString());

            PrintTree(tree.Left, depth + 1);
            PrintTree(tree.Right, depth + 1);
        }

        static void PrintArray(int[,] array)
        {
            Console.WriteLine("******* Print Avarage *********");

            for (int i = 0; i < array.GetLength(0) - 1; i++)
                Console.Write(array[i, 0] + ", ");

            Console.WriteLine(array[array.GetLength(0) - 1, 0]);
        }

        static void GetAverageByLevel(Node tree, ref int[,] average, int level)
        {
            if (tree == null) return;

            if (average.GetLength(0) == level)
            {
                average = UpdateArrayAverage(average, tree.Value);
            }
            else
            {
                average[level, 0] = average[level, 0] * average[level, 1];

                average[level, 1] += 1;

                average[level, 0] = (average[level, 0] + tree.Value) / average[level, 1];
            }

            GetAverageByLevel(tree.Left, ref average, level + 1);
            GetAverageByLevel(tree.Right, ref average, level + 1);
        }


        static int[,] UpdateArrayAverage(int[,] average, int newValue)
        {
            int[,] newArray = new int[average.GetLength(0) + 1, 2];

            for (int i = 0; i < average.GetLength(0); i++)
            {
                newArray[i, 0] = average[i, 0];
                newArray[i, 1] = average[i, 1];
            }

            newArray[newArray.GetLength(0) - 1, 0] = newValue;
            newArray[newArray.GetLength(0) - 1, 1] = 1;

            return newArray;
        }
    }

}