// See https://aka.ms/new-console-template for more information
using System;
class ArmstrongNumbers
{
    static int CountDigits(int num)
    {
        int count  =0;
        while(num > 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }

    static bool isArmStrong(int num)
    {
        int n = num;
        int cdigit = CountDigits(num);
        int sum =0;
        while(num > 0)
        {
            int digit = num%10;
            sum += (int)Math.Pow(digit,cdigit);
            num /=10;
        }
        return n == sum;
    }
    static void Main()
    {
        Console.Write("Armstrong number between 1 and 1000");
        for(int i =0;i<1000;i++)
        {
            if(isArmStrong(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}