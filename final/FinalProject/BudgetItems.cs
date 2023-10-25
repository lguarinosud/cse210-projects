


using System.Dynamic;
using Microsoft.VisualBasic;

public class BudgetItems : MonthBudget
{
   
    private string _account {get; set;} 
    private double _budget {get; set;}
    private string _paymentMethod {get; set;}
    private double _balance {get; set;}

    public BudgetItems(string year, string month, string account, double budget, string paymentMethod, double balance) : base ( year, month)
    {
        _year = year;
        _month = month;
        _account = account;
        _budget = budget;
        _paymentMethod = paymentMethod;
        _balance = balance;
        
    }

    public string getAccount()
    {
        return _account;        
    }

    public void setAccount(string account)
    {
        _account = account;
    }
    
    public double getBudget()
    {
        return _budget;        
    }

    public void setbudget(double newBudget)
    {
        _budget = newBudget;
    }
    
    public string getBudgetItemDetails()
    {
        string  itemLine = $"Account: {_account} Budget: {_budget} Payment Method {_paymentMethod}";

        return itemLine;
    }

    public void DisplayBudgetItemDetails()
    {
        string line = getBudgetItemDetails();
        Console.WriteLine(line);
    }

    public string parseBudgetItemDetails()
    {
        string line = $"{_account},{_budget},{_paymentMethod},{_balance}";
        return line;
    }


}

