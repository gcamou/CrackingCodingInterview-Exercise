using System;

public static class Helper
{
    public static int[] GenerateArray(long lenght)
    {
        Random random = new Random();

        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 10);
        }

        return array;
    }

    public static Node GenerateNode(Node node, int level, int depth)
    {
        if (depth < level)
            return node;

        node.Left = new Node() { Value = node.Value + " Left  - Level " + level.ToString() };
        node.Right = new Node() { Value = node.Value + " Right - Level " + level.ToString() };

        GenerateNode(node.Left, level + 1, depth);
        GenerateNode(node.Right, level + 1, depth);

        return node;
    }

    public static void PrintNode(Node node)
    {
        Console.WriteLine(node.Value);

        if (node.Left == null)
            return;

        PrintNode(node.Left);
        PrintNode(node.Right);
    }
}