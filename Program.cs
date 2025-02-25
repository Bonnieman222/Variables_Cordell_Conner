using System;

class Program
{
    static void Main()
    {
        // Declare an integer variable named "favoriteNumber"
        int favoriteNumber;

        // Initialize boolean variables "isJumping" and "isRunning" to false on the same line
        bool isJumping = false, isRunning = false;

        // Declare a floating point variable
        float myFloatNumber;

        // Assign "favoriteNumber" to your favorite number
        favoriteNumber = 7; // Example favorite number

        // Assign a floating point value to the declared float variable
        myFloatNumber = 3.14f; // Example float value

        // Initialize a constant double named "finalGrade"
        const double finalGrade = 95.5; // Example final grade

        // Print out all variables on their own line
        Console.WriteLine("Favorite Number: " + favoriteNumber);
        Console.WriteLine("Is Jumping: " + isJumping);
        Console.WriteLine("Is Running: " + isRunning);
        Console.WriteLine("Floating Point Number: " + myFloatNumber);
        Console.WriteLine("Final Grade: " + finalGrade);

        // Keep the console window open
        Console.ReadLine();
    }
}
