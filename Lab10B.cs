/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab10B
*/

using System;

class Lab10B
{
    public static bool isValid(double width, double height) 
    {
        if (width + height > 30)
        {
            return true;
        }
        else return false;
    }
    public static double area(double width, double height) 
    {
        return width * height;
    }
    public static double perimeter(double width, double height) 
    { 
        return (width + height)*2;
    }
    public static void Main(string[] args)
    {
        bool cont = true;
        while (cont)
        {
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            if(isValid(width, height) )
            {
                double a= area(width, height);
                double p= perimeter(width, height);
                Console.WriteLine("This is a valid rectangle");
                Console.WriteLine("The area is: "+a);
                Console.WriteLine("The perimeter is: "+p);
            }
            else
            {
                Console.WriteLine("This is an invalid rectangle");
            }
            Console.Write("\nDo you want to enter another width and height (Y/N)? : ");
            char another= char.Parse(Console.ReadLine());
            if(another=='N') cont= false;
        }
        Console.WriteLine("Program Ends");
    }
}
