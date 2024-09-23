namespace Homework4;

class Program
{
    // Code for question 1:
    static void Main(string[] args)
    {
        Console.WriteLine("Input a number:");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input another number:");
        int num2 = Convert.ToInt16(Console.ReadLine());
        
        int LargestNum = GetLargestNum(num1, num2);

        Console.WriteLine($"a = {num1}; b = {num2}");
        Console.WriteLine($"The largest number is: {LargestNum}");

        // Code for question 2;
        int N = 5;
        Console.WriteLine("left or right?");
        string input_shape = Console.ReadLine();
        Question2(N, input_shape);
    }
    // Static int code for question 1:
    static int GetLargestNum(int a, int b){
        return a > b ? a : b;
    }
    // Static void code for question 2:
    static void Question2(int N, string shape){
        if(shape=="left"){
            for(int row = 0; row<5; row++){
                for(int col = 0; col<5; col++){
                    if(row>=col){
                        Console.Write('*');
                    }
                }
                Console.WriteLine("");
            }
        }
        else{
            for(int row = 0; row<5; row++){
                for(int space = 0; space<4-row; space++){
                    Console.Write(' ');
                }
                
                for(int col = 0; col<=row; col++){
                    Console.Write('*');
                }
                Console.WriteLine("");
            }
        }
    }
}
