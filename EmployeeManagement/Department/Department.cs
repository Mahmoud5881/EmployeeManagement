namespace EmployeeManagement;

public class Department
{
    private int departId;
    private string departName;

    public void print()
    {
        Console.WriteLine($"Department ID: {departId}");
        Console.WriteLine($"Department Name: {departName}");
    }
}