/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab10A
*/

using System;

class Lab10A
{
    public static int maximum (int x,int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
    public static int minimum(int x, int y) 
    {
        if (x < y)
        {
            return x;
        }
        else 
        { 
            return y;
        }
    }
    public static float avaerage(int x,int y)
    {
        float avg = ((float)x + (float)y) / 2;
        return avg;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        int num1= int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int num2= int.Parse(Console.ReadLine());
        int min = minimum(num2, num1);
        Console.WriteLine("Min is " + min);
        int max = maximum(num1, num2);
        Console.WriteLine("Max is "+max);
        float avg= avaerage(num1, num2);
        Console.WriteLine("Average is "+avg);
        
    }
}
