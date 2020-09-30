using System;

public class CalculateTotalCosts
{
	public static void SelectProject()
    {
        //Asking user to select a project
        Console.WriteLine("Welcome to Flooring Costs, please select a project:");
        Console.WriteLine("1. Teotihuacan in Mexico City, Mexico\n2. Taj Mahal in Agra, India\n3. Al-Masjid al-haram (Great Mosque) in Mecca, Saudi Arabia.\nPlease enter 1, 2 or 3:");
        //Setting the entered value to a "selection" variable
        string selection = Console.ReadLine();
        //using a switch case to determine what the program will output
        switch (selection)
        {
            case "1":
                Teotihuacan();
                break;
            case "2":
                TajMahal();
                break;
            case "3":
                GreatMosque();
                break;
        }
    }
    public static void Teotihuacan()
    {
        //calculating total area
        double totalArea = (Circle(375) / 2) + Rect(1500, 2500) + Tri(750, 500);
        //calculating total cost
        double totalCost = Math.Round(totalArea * 180, 2);
        //printing result to console
        Console.WriteLine($"The total cost for the flooring in this project is {totalCost} pesos");
    }
    public static void TajMahal()
    {
        double totalArea = Rect(90.5, 90.5) - (Tri(24, 20.8) * 4);
        double totalCost = Math.Round(totalArea * 180, 2);
        Console.WriteLine($"The total cost for the flooring in this project is {totalCost} pesos");
    }
    public static void GreatMosque()
    {
        double totalArea = Rect(180, 106) + Rect(200, 264) + Tri(84, 264);
        double totalCost = Math.Round(totalArea * 180, 2);
        Console.WriteLine($"The total cost for the flooring in this project is {totalCost} pesos");
    }
    //Creating methods for shapes to use in above calculations
    static double Rect(double length, double width)
    {
        return length * width;
    }
    static double Circle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    static double Tri(double bottom, double height)
    {
        return 0.5 * bottom * height;
    }
}
