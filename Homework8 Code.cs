namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);

        Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);
    }

    public static void TotalCredits(Customer[] customer_list){
        double totalCredits = 0;
        foreach(Customer customerItem in customer_list){
            totalCredits += customerItem.customerCredit;
        }
        Console.WriteLine($"The total customer credit is: {totalCredits}");
    }

    public static void AmarilloAverageAge(Customer[] customer_list){
        double totalAmaAvgAge = 0;
        int countCustomer = 0;
        foreach(var customerItem in customer_list){
            if(customerItem.customerCity == "Amarillo"){
                totalAmaAvgAge += customerItem.customerAge;
                countCustomer++;
            }
        }
        if(countCustomer > 0){
            double amarilloAverageAge = totalAmaAvgAge/countCustomer;
            Console.WriteLine($"The average age of customers in Amarillo: {amarilloAverageAge}");
        }
    }

    public static void CanyonAge(Customer[] customer_list){
        foreach(var customerItem in customer_list){
            if(customerItem.customerCity == "Canyon"&&customerItem.customerAge > 30){
                Console.WriteLine($"The customers that are over 30 and live in Canyon: {customerItem}, {customerItem}");
            }
        }
    }
}

class Customer
{
    public string customerName {get;set;} = string.Empty;
    public int customerAge {get;set;} = 0;
    public string customerCity {get;set;} = string.Empty;
    public double customerCredit {get;set;} = 0;
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}