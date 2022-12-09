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
