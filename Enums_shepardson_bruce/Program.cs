using System;
using System.IO;

// Define an enumeration for the months of the year
enum Months
{
    Jan = 1,  // January is assigned the value 1
    Feb,      // February will be 2, and so on
    Mar,
    Apr,
    May,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec       // December is 12
}

// Internal class containing the main program logic
internal class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Define birth date components
        int myBirhtMonth = (int)Months.Dec;  // Convert enum value for December to integer (12)
        int myBirthDay = 23;
        int myBirthYear = 2008;

        // Create a string with the full birthdate
        string myBirthdate = $"My birthday is on {myBirhtMonth}/{myBirthDay}/{myBirthYear}";

        // Write initial content to a file named "myFile.txt"
        File.WriteAllText("myFile.txt", "This is my text file!\n");

        // Read and print the contents of "myFile.txt"
        Console.WriteLine(File.ReadAllText("myFile.txt"));

        // Append more text to "myFile.txt"
        File.AppendAllText("myFile.txt", "woohoo more text added to file!\n");

        // Read and print updated contents of "myFile.txt"
        Console.WriteLine(File.ReadAllText("myFile.txt"));

        // Check if "newFile.txt" does not exist
        if (!File.Exists("newFile.txt"))
        {
            // If it doesn't exist, copy "myFile.txt" to "newFile.txt"
            File.Copy("myFile.txt", "newFile.txt");
        }
        else
        {
            // If it does exist, replace it with "myFile.txt" and create a backup named "backupFile.txt"
            File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
        }

        // Append the birthdate string to "newFile.txt"
        File.AppendAllText("newFile.txt", myBirthdate);

        // Display the contents of "myFile.txt" again
        Console.WriteLine(File.ReadAllText("myFile.txt"));
    }
}
