using System.Threading.Channels;

namespace EmployeeManagement.Employees;

public class ComissionEmployee : Employee
{
    public double target;
    
    public override void Print()
    {
        Console.WriteLine($"Employee ID :{EmployeeId}" );
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
        department.Print();
        Console.WriteLine($"Social Security Number: {socialSecurityNumber}");
        Console.WriteLine($"Target: {target}");
    }
    public override double Pay() => 0.05 * target;
}