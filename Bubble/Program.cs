using System;
public class BubbleSrt
{
    public static void Main(string[] args)
    {
       
        
        int[] arr = new Int32[16];
        for (int i = 0; i < 16; i++)
        {
            Console.Write("BubbleSort:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            
        }

        Console.WriteLine();
        bubblesort(arr, 16);


        for (var a = 0; a < 16; a++)
            Console.Write(arr[a] + "\t");//Printing the array after sorting in descending order
            
        Console.WriteLine();

        for (int i = 15; i >= 0; i--)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.ReadKey();
    }
    //bubble sort
    static void bubblesort(int[] data, int n)
    {
        int a;
        int b;
        for (a = 0; a < n; a++)
            for (b = n - 1; b > a; b--)
                if (data[b] > data[b - 1])//Condition to arrange array in descending order
                {
                    int temp = data[b];
                    data[b] = data[b - 1];
                    data[b - 1] = temp;
                }
    }
}