namespace MyMaxMinLib;
using System;
public class MaxMin
{
    public static double MyMax(double number1, double number2) {
        double max1 = Math.Max(number1, number2);

        Console.WriteLine("The maximum value is: " + max1);
        return max1;
    }
}