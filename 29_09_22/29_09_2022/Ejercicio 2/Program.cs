using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dime un numero:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime otro numero:");
        int age2 = Convert.ToInt32(Console.ReadLine());
        if (age > age2)
        {
            Console.WriteLine("El " + age + " es el numero mayor");
        }
        else
        {
            Console.WriteLine("El " + age2 + " es el numero mayor");

        }
    }
}