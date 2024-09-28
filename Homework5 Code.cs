namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Code for Question 1:
        Console.WriteLine("Input a number:");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input another number:");
        int num2 = Convert.ToInt16(Console.ReadLine());
        
        int LargestNum = GetLargestNum(num1, num2);

        Console.WriteLine($"a = {num1}; b = {num2}");
        Console.WriteLine($"The largest number is: {LargestNum}");
        // Code for question 2:
        Console.WriteLine("Input first number:");
        int q2num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input second number:");
        int q2num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input third number:");
        int num3 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input fourth number:");
        int num4 = Convert.ToInt16(Console.ReadLine());

        int LargestNumQ2 = GetLargestNumQ2(q2num1, q2num2, num3, num4);

        Console.WriteLine($"a = {q2num1}; b = {q2num2}; c = {num3}; d = {num4}");
        Console.WriteLine($"The largest number is: {LargestNumQ2}");
        // Code for Question 3:
        createAccount();
    }
    // Method for Question 1:
    static int GetLargestNum(int a, int b){
        return a > b ? a : b;
    }
    // Method for Question 2:
    static int GetLargestNumQ2(int aQ2, int bQ2, int c, int d){
        int largest = aQ2;

        if(bQ2 > largest){
            largest = bQ2;
        }
        if(c > largest){
            largest = c;
        }
        if(d > largest){
            largest = d;
        }
        return largest;
    }
    // Check Age method for Question 3:
    static bool checkAge(int birthYear){
        int currentYear = 2024;
        int age = currentYear - birthYear;
        if(age>=18){
            return true;
        }
        else{
            return false;
        }
    }
    // Create Account method for Question 3:
    static void createAccount(){
        Console.WriteLine("Enter your username:");
        string input = Console.ReadLine();
        Console.WriteLine("Enter your password:");
        string input2 = Console.ReadLine();
        Console.WriteLine("Confirm password:");
        string input3 = Console.ReadLine();
        Console.WriteLine("Enter your birthyear:");
        int birthYear = Convert.ToInt16(Console.ReadLine());

        if(checkAge(birthYear)){
            if(input2 == input3){
                Console.WriteLine("Account created successfully!");
            }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else{
            Console.WriteLine("Could not create an account");
        }
    }
}
