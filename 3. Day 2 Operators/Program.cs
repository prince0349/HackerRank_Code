using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
        
        var tip = tip_percent * meal_cost / 100;
        var tax = tax_percent * meal_cost / 100;

        var totalCost = Math.Round(tip + tax + meal_cost);
        Console.WriteLine($"The total meal cost is {totalCost} dollars.");
    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}