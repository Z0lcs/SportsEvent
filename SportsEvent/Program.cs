using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters;
using static System.Formats.Asn1.AsnWriter;
public class SportsEvent
{
    private double[] scores = new double[8];
    /// &lt;summary&gt;
    /// This method prompts the user to enter in 8 scores and stores
    /// them in the array scores.
    /// &lt;/summary&gt;
    public void ReadScores()
    {
        // TODO : Implement reading 8 scores from the user
        Console.WriteLine("Enter Eight Contestant Scores:");
        int k=0;
        for (int i = 1; i < 9; i++)
        {
            Console.Write($"Judge {i} --> ");
            scores[k++]= Convert.ToDouble(Console.ReadLine());
        }
    }
    /// &lt;summary&gt;
    /// Determines which score in scores is the lowest
    /// &lt;/summary&gt;
    /// &lt;returns&gt;The lowest score in scores&lt;/returns&gt;
    public double Lowest()
    {
        double min=scores[0];
        // TODO : Determine the lowest score
        foreach (double s in scores)
        {
            if (s < min)
            {
                min = s;
            }
        }
        return min;
    }
    /// &lt;summary&gt;
    /// Determines which score in scores is the highest
    /// &lt;/summary&gt;
    /// &lt;returns&gt;The highest score in scores&lt;/returns&gt;
    public double Highest()
    {
        // TODO : Determine the highest score
        double high = scores[0];
        foreach (double i in scores)
        {
            if (high < i)
                high = i;
        }
        return high;
    }
    /// &lt;summary&gt;
    /// Calculates the average of scores with the lowest and highest scores
    /// thrown out.
    /// &lt;/summary&gt;
    /// &lt;returns&gt;The average&lt;/returns&gt;
    public double Average()
    {
        // TODO : Calculate the average without lowest and highest score
        double avg = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            avg += scores[i];
        }
        return avg /= scores.Length;
    }
    /// &lt;summary&gt;
    /// This method prints a summary report which includes the original list of
    /// scores, the average of the scores, the lowest score, and the highest score.
    /// &lt;/summary&gt;
    public void PrintSummary()
    {
        // TODO : Print summary report
        Console.WriteLine(new string(' ', 8)+"Summary Report"+ new string(' ', 8));
        Console.WriteLine(new string('-', 30));
        Console.Write("Scores =");
        for (int i = 0;i < scores.Length;i++)
        {
            Console.Write($" {scores[i]}");
        }
        Console.WriteLine();
        Console.WriteLine($"Lowest Score = {Lowest()}");
        Console.WriteLine($"Highest Score = {Highest()}");
        Console.WriteLine($"Average Score = {Average()}");

    }
    /// &lt;summary&gt;
    /// Program entry point.
    /// &lt;/summary&gt;
    /// &lt;param name=&quot;args&quot;&gt;Command-line arguments&lt;/param&gt;
    public static void Main(string[] args)
    {
        SportsEvent app = new SportsEvent();
        app.ReadScores();
        app.PrintSummary();
    }
}