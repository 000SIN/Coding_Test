using System;

public class Example
{
    public static void Main()
    {
        string str;
        str = Console.ReadLine();

        if(1<=str.Length || str.Length<=1000000)
        {
            Console.WriteLine(str);
        }
    }
}