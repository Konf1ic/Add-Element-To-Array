using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10] { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };

        Console.Write("X that you want to add: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Index position want to add: ");
        int index = int.Parse(Console.ReadLine());

        // Check index
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index not avalible!");
            return;
        }

        // Add X
        for (int i = array.Length - 1; i > index; i--)
        {
            array[i] = array[i - 1];
        }
        array[index] = x;

        Console.WriteLine("New array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
