using System.Runtime.CompilerServices;
using EmployeeManagement.Employees;

namespace EmployeeManagement.Project;

public class Project
{
    private int projectId;
    private string location;
    private Employee manager;
    private double currentCost;
    private List<Budget> budget;
    
    public void AddBuget(Budget budget) => this.budget.Add(budget);

    public double GetTotalBudget()
    {
        double total = 0;
        foreach (var value in budget)
        {
            total += value.Value;
        }
        return total;
    }
}