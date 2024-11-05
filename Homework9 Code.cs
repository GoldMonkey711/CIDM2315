namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "david");

        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }
    }
}

class Student
{
    public static List<Student> student_list = new List<Student>();
    public int StudentID{get;set;}
    public string StudentName{get;set;}
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {StudentID}, Student Name: {StudentName}");
    }
    public Student(int inputID, string inputName){
        StudentID = inputID;
        StudentName = inputName;
        student_list.Add(this);
    }
}
