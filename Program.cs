using System;
using System.Diagnostics;

namespace test;

public class Program
{
    //gets 2 vectors and returns their scalar multiplication
    public static void Main()
    {
        Console.WriteLine("scalar multiplying");
        var output = "";
        using (var process = new Process())
        {
            process.StartInfo.FileName = "fileCounter.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();

            StreamWriter writer = process.StandardInput;
            StreamReader reader = process.StandardOutput;

            writer.WriteLine("10 20");
            writer.WriteLine("20 10");

            output = reader.ReadLine();

            writer.Close();
            reader.Close();

            process.WaitForExit();
        }

        Console.WriteLine($"the output is {output}");
    }
}