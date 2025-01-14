namespace EmployeeManagement.Project;

public class Budget
{
    private int budgetId;
    private double value;

    public double Value
    {
        get => value;
    }

    public void increaseBudget(double amount) => value += amount;
}