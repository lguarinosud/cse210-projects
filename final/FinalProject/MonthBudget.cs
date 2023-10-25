


using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class MonthBudget 

// THis class holds the entire budget for one month
{
protected string _year {get; set;}
protected string _month {get; set;}
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

public MonthBudget(string year, string month, double totalIncome, double totalBalance, double totalExpenses)
{
    _year = year;
    _month = month;
    _totalIncome = totalIncome;
    _totalBalance = totalBalance;
    _totalExpenses = totalExpenses;
    
}

public  List<BudgetItems> getBudgetItemList()
{
    return budgetItemsList;
}
public void addItemToBudget(BudgetItems item)
// Add an account to the budget
{
    budgetItemsList.Add(item);

    foreach (BudgetItems each in budgetItemsList)
    {
        
      
    }
}

public string getMonth()
{
    return _month;
}
public void setMonth (string month)
{
    _month = month;
}

public string getYear()
{
    return _year;
}
public void setYear (string year)
{
    _year = year;
}
public void deleteItemBudget(int position)
{

    budgetItemsList.RemoveAt(position);

}

public void editItemBudget(int position)
{
    while (true)
    {
        string account = budgetItemsList[position].getAccount();
        double budget = budgetItemsList[position].getBudget();
        Console.Write("Edit Budget: ");
        string newBudget = Console.ReadLine();
        Console.Write($"Account \"{account}\" Do you want to replace £{budget} with £{newBudget}. yes/no/cancel");
        string resp = Console.ReadLine();

       switch (resp)
       {    
        case "yes":
            budgetItemsList[position].setbudget(double.Parse(resp));
            Console.WriteLine("");
            Console.WriteLine("Budget updated!");
            break;
        
        case "no":
            
            break;

        case "cancel":

            return;


       }
    }
}

public void displayBudgetItems()
    {
        int count = 0;
        Console.WriteLine("Accounts: ");
        count++;
        
        foreach (BudgetItems item in budgetItemsList)
        {
            string line = item.getBudgetItemDetails();
            //Console.WriteLine($"{count}.   {item.getBudgetItemDetails()}");
            Console.WriteLine($"{count}.   {line}");
        }
    }
public void displayBudgetMonth()
{
    _totalBalance = _totalIncome - _totalExpenses;
    Console.WriteLine($"| Month: {_month}/{_year} | Total Incomes: £{_totalIncome} | Total Expenses: £{_totalExpenses} | Balance: £{_totalBalance} |");
    displayBudgetItems();

}

public string getBudgetMonthDetail()
{
    
    string line = $"{_month}/{_year}";
    return "";
}

public string parseBudgetMonthDetails()
{
    string line = $"{_month},{_year},{_totalIncome},{_totalBalance},{_totalExpenses}";
    return line;
}

}