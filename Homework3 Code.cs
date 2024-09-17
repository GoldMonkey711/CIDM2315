namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Question 1:
        Console.WriteLine("Input an integer:");
        if(int.TryParse(Console.ReadLine(), out int N)){
            if(IsPrime(N)){
                Console.WriteLine("N is prime");
            }
            else{
                Console.WriteLine("N is non-prime");
            }
        }

        //Code for Question 2:
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++)
            {
                Console.Write('#');
            }
            Console.WriteLine("");
        }

        // Code for Question 3:
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++)
            {
                if(row>=col)
                Console.Write('*');
            }
            Console.WriteLine("");
        }

    }

    // Static bool code for Question 1:
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2 || number == 3)
        {
            return true;
        }

        if (number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }
}
