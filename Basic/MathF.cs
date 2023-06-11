using System;

public class MathF{
    static void Main(string[] args){
        #region Math function
        double number = -5.5;

        // Absolute value
        double absoluteValue = Math.Abs(number);
        Console.WriteLine("Absolute value of " + number + " is: " + absoluteValue);

        // Square root
        double squareRoot = Math.Sqrt(25);
        Console.WriteLine("Square root of 25 is: " + squareRoot);

        // Power
        double power = Math.Pow(2, 3);
        Console.WriteLine("2 raised to the power of 3 is: " + power);

        // Floor
        double floorValue = Math.Floor(3.8);
        Console.WriteLine("Floor value of 3.8 is: " + floorValue);

        // Ceiling
        double ceilingValue = Math.Ceiling(3.2);
        Console.WriteLine("Ceiling value of 3.2 is: " + ceilingValue);

        // Round
        double roundedValue = Math.Round(4.6);
        Console.WriteLine("Rounded value of 4.6 is: " + roundedValue);

        // Mathematical constant pi
        double pi = Math.PI;
        Console.WriteLine("The value of pi is: " + pi);

        // Mathematical constant e
        double e = Math.E;
        Console.WriteLine("The value of e is: " + e);
        #endregion
    }
}
