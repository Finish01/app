using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Set up the process start info
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "nc",
            Arguments = "-l 80",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        // Create and start the process
        Process process = new Process
        {
            StartInfo = psi
        };
        process.Start();

        // Read the output (optional)
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        // Wait for the process to exit (optional)
        process.WaitForExit();

        // Display the output and error (optional)
        Console.WriteLine("Output:\n" + output);
        Console.WriteLine("Error:\n" + error);

        // Pause to keep the console window open (optional)
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
