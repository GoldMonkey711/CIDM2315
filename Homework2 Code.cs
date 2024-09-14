namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        /* ChatGPT 4o mini, (9-13-2024), Asked gpt for help with a program that asks
        for user input and outputs a certain value based on the input, along with a program that asks
        the user to input 3 values, and output the smallest value. */

        // Code for Question 1:
        Console.WriteLine("Please input a letter grade: ");
        string input = Console.ReadLine();
        int gpa;

        switch (input){
            case "A":
                gpa = 4;
                break;
            case "B":
                gpa = 3;
                break;
            case "C":
                gpa = 2;
                break;
            case "D":
                gpa = 1;
                break;
            case "F":
                gpa = 0;
                break;
            default:
                Console.WriteLine("Wrong letter grade!");
                return;
        }

        Console.WriteLine($"GPA Point: {gpa}");

        //Code for Question 2:
        Console.WriteLine("Please input the first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please input the second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please input the third number:");
        double number3 = Convert.ToDouble(Console.ReadLine());

        double smallest = number1;

        if(number2 < smallest){
            smallest = number2;
        }
        if(number3 < smallest){
            smallest = number3;
        }

        Console.WriteLine("The smallest value is: " + smallest);
    }
}
