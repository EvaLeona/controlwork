using System;

public class MainClass
{
    public static void Main()
    {
        string[] arrays = new string[5]; 

        for (int i = 0; i < arrays.Length; i++) 
        {
            Console.WriteLine("Введите что угодно:");
            arrays[i] = Console.ReadLine();
        }

        int a = 0; 
        for (int i = 0; i < arrays.Length; i++) 
        {
            if (arrays[i].Length <= 3)
            {
                a++;
            }
        }
        string[] newarray = new string[a]; 
        a = 0;
        for (int i = 0; i < arrays.Length; i++) 
        {
            if (arrays[i].Length <= 3)
            {
                newarray[a] = arrays[i];
                a++;
                Console.WriteLine("В массиве: " + arrays[a]);
            }
        }

    }
}