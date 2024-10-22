namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer();
        c1.cus_id = 110;
        c1.cus_name = "Alice";
        c1.cus_age = 28;
        c1.PrintInfo();

        Customer c2 = new Customer();
        c2.cus_id = 111;
        c2.cus_name = "Bob";
        c2.cus_age = 30;
        c2.PrintInfo();

        Customer cc1 = new Customer();
        cc1.new_id = 220;
        cc1.cus_name = "Alice";
        cc1.cus_age = 28;
        cc1.PrintInfo2();

        Customer cc2 = new Customer();
        cc2.new_id = 221;
        cc2.cus_name = "Bob";
        cc2.cus_age = 30;
        cc2.PrintInfo2();
    }
}

class Customer()
{
    public int cus_id;
    public int new_id;
    public string cus_name;
    public int cus_age;

    public void PrintInfo(){
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void PrintInfo2(){
        Console.WriteLine($"Customer: {new_id}, Name: {cus_name}, Age: {cus_age}");
    }
}
