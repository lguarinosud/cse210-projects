

using System.Runtime.CompilerServices;

public class Incomes: Accounts
{
    //List Movements movements; 
public Incomes(string name, string description) : base ( name, description)
{
     _name = name;
    _balance = 0.00;
    _budget = 0.00;
    _description =  description;
}

public override string getAccountDetails()
    {
        string details = $"Type: Incomes Name:{_name} Description: {_description}";

        return details;
    }

public override string parseAccountDetails()
    {
        string details = $"Incomes,{_name},{_description}";
        
        return details;
    }



}

