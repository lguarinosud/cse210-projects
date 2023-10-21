


public class Expenses : Accounts
{
    public Expenses(string name, string description) : base ( name, description)
{
     _name = name;
    _balance = 0.00;
    _budget = 0.00;
    _description =  description;
     
    
}

public override string getAccountDetails()
    {
        string details = $"Type: Expenses Name:{_name} Description: {_description}";

        return details;
    }

public override string parseAccountDetails()
    {
        string details = $"Expenses,{_name},{_description}";
        
        return details;
    }


}

