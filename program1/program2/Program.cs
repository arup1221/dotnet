// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
class Substring
{
    static void Main()
    {
        Console.WriteLine("Enter your String");
        String s = Convert.ToString(Console.Read());
        Console.WriteLine("All subString are: ");
        int size = s.Length;
        for(int i =0;i<size;i++)
        {
            for(int j =i;j<size;j++)
            {
                String ans = s.Substring(i,j-i+1);
                Console.WriteLine(ans);
            }
        }

    }
}
