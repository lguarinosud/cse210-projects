


public class MonthBudget

// THis class holds the entire budget for one month
{
private string _year {get; set;}
private string _month {get; set;}
private double _totalIncome {get; set;}
private double _totalBalance {get; set;}
private double _totalExpenses {get; set;}
private List<BudgetItems> budgetItemsList = new List<BudgetItems>();  

public MonthBudget(string year, string month)
{
    _year = year;
    _month = month;
    _totalIncome = 0.00;
    _totalBalance = 0;
    _totalExpenses = 0;
    

}

public void addItemToBudget(BudgetItems item)
// Add an accoun to the budget

{
    budgetItemsList.Add(item);
}


public void displayBudgetMonth()
{
    foreach (BudgetItems item in budgetItemsList)
    {
        item.DisplayBudgetItemDetails();
    }
}

}