



public class Accounts 
{
    
    protected string _name;
    protected double _balance;
    protected double _budget;
    protected string _description; 
    //List Movements movements; 

    //List<Accounts> account_list = new List<Accounts>();
    public Accounts(string name, string description)
{
    _name = name;
    _balance = 0.00;
    _budget = 0.00;
    _description =  description;
}

    public string GetName()
    {
        return _name;
    }

    public string getDescription()
    {
        return _description;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public void setDescription(string description)
    {
        _description = description;
    }

    public void displayName()
    {
        Console.WriteLine(_name);
    }

    public void displayDiscription()
    {
        Console.WriteLine(_description);

    }

    public virtual string getAccountDetails()
    {
        string details = $"Name: {_name} Description: {_description}";

        return details;
    }

    public void displayAccountDetails()
    {
         string displayDetails = getAccountDetails();
         Console.WriteLine(displayDetails);
    }

    public virtual string parseAccountDetails()
    {
        return "";
    }

   
    



}

