using System; //allows the use of console

//All code in C# is inside of class definitions
public class FirstProgram
{
    //The starting point of the program
    public static void Main()
    {
        //Creating a string variable and initialize it to an empty string
        //Note: This is NOT a space
        // -it is two double quotes right next to each other
        string name = "";

        //Display a prompt to the user
        Console.Write("What is your name?");
        Console.Beep();

        //Capture the user's response
        name = Console.ReadLine();

        // Display a string literal combined with the value of the string variable
        // What does the "\n" do?
        Console.Write("Hello " + name + "\n");

        // Waits for the user to press a key
        // Allows us to read what was displayed
        Console.Read();
    } // End of main
} // End of class definition
