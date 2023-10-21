


using System.Dynamic;
using Microsoft.VisualBasic;

public class BudgetItems
{
    private string _year {get; set;}
    private string _month {get; set;}
    private string _account {get; set;} 
    private double _budget {get; set;}
    private string _paymentMethod {get; set;}
    private double _balance {get; set;}

    public BudgetItems(string year, string month, string account, double budget, string paymentMethod)
    {
        _year = year;
        _month = month;
        _account = account;
        _budget = budget;
        _paymentMethod = paymentMethod;
        _balance = 0.00;
        
    }

    public string getBudgetItemDetails()
    {
        string  itemLine = $"year: {_year} Month: {_month} Account: {_account} Budget: {_budget} Payment Method {_paymentMethod}";

        return itemLine;
    }

    public void DisplayBudgetItemDetails()
    {
        string line = getBudgetItemDetails();
        Console.WriteLine(line);
    }


}

