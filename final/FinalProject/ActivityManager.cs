using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

public class ActivityManager
{
    private List<string> _menuOptions = new List<string>();
    private List<string> _subMenuOptions = new List<string>();

    private List<Accounts> AccountList = new List<Accounts>();
    private List<MonthBudget> MonthBudgetList = new List<MonthBudget>();
    
   
    public ActivityManager ()
    {
        _menuOptions.Add("   1. Accounts");
        _menuOptions.Add("   2. Budget");
        _menuOptions.Add("   3. Movements");
        _menuOptions.Add("   4. Reports");
        _menuOptions.Add("   5. Save All");
        _menuOptions.Add("   6. Load All");
        _menuOptions.Add("   7. Quit");

        _subMenuOptions.Add("  1. Create an Account");
        _subMenuOptions.Add("  2. Update an account");
        _subMenuOptions.Add("  3. Delete an account");
        _subMenuOptions.Add("  4. Display all  Accounts");
        _subMenuOptions.Add("  5. Return main manu");
    }


public List<Accounts> getAccountList()
{
    return AccountList;
}
    
    
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        
        foreach (string option in _menuOptions)
        {
            Console.WriteLine(option);
        }
    }



    public void DisplayAccountSubMenu()
    {
        while (true)
        {
            Console.Clear();
            //Console.WriteLine("Select an option: ");

            foreach (string option in _subMenuOptions)
            {
                Console.WriteLine(option);
            }

            Console.Write("");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            string resp1 = Console.ReadLine();

            switch(resp1)
            {
                
                
                case "1": // Create an account
                    Console.Clear();
                    
                    Console.Write("====Create an account===");
                    Console.WriteLine("");
                    createAccount();
                    Console.WriteLine("Account Created:");
                    
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.ReadLine();
                    Console.Clear();
                    
                    
                    
                    break;
                
                case "2": // Update an account
                        Console.WriteLine("===Update an Account===");
                        Console.WriteLine("Hit enter to return to the main menu...");
                        Console.ReadLine();
                        Console.Clear();

                    break;
                
                case "3": //Delete an account
                    //SaveGoals();
                    Console.WriteLine("===Delete an Account===");
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                
                case "4": // Display accounts
                    DisplayAccounts();
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                case "5": //quit
                    Console.WriteLine("Hit enter to return to the main manu");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                
                    return;
            }

        }
  
    }
   

 public void DisplayBudgetSubMenu()
    {
        while (true)
        {
            Console.Clear();
            //Console.WriteLine("Select an option: ");

            Console.WriteLine("1.   Create a month Budget ");
            Console.WriteLine("2.   Create a Month Item ");

            Console.Write("");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            string resp1 = Console.ReadLine();

            switch(resp1)
            {
                
                
                case "1": // Create an month Budget
                    Console.Clear();
                    
                    Console.Write("====Create a Month Budget===");
                    Console.WriteLine("");
                    createAccount();
                    Console.WriteLine("Account Created:");
                    
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.ReadLine();
                    Console.Clear();
                    
                    
                    
                    break;
                
                case "2": // Update an account
                        Console.WriteLine("===Update an Account===");
                        Console.WriteLine("Hit enter to return to the main menu...");
                        Console.ReadLine();
                        Console.Clear();

                    break;
                
                case "3": //Delete an account
                    //SaveGoals();
                    Console.WriteLine("===Delete an Account===");
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                
                case "4": // Display accounts
                    DisplayAccounts();
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                case "5": //quit
                    Console.WriteLine("Hit enter to return to the main manu");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                
                    return;
            }

        }
  
    }

   public void createAccount()
   {
    Console.Write("What's the name of the new account?: ");
    string name = Console.ReadLine();

    Console.Write("Provide a short description: ");
    string description = Console.ReadLine();
    
    Console.Write("Is it an Income or an expense? Type 1 for 'Incomes' or 2 for 'Expenses' ");
    string resp = Console.ReadLine();
    switch (resp)
    {
        case "1":
        Incomes myIncomes = new Incomes(name, description);
        myIncomes.displayAccountDetails();
        AccountList.Add(myIncomes);

        break;

        case "2":
        Expenses myExpenses =  new Expenses(name, description);
        myExpenses.displayAccountDetails();
        AccountList.Add(myExpenses);
        break;
    }
    
    
    



   }

    public void addAccount(Accounts newAccount)
    {
        AccountList.Add(newAccount);
    }


   public void DisplayAccounts()
   {
    
        foreach (Accounts item in AccountList)
        {
            item.displayAccountDetails();
        }
   }

    public void SaveAccountFile(List<Accounts> accountList)
    {
        //Console.WriteLine("What's the filename? ");
        //string resp = Console.ReadLine();
        //string fileName = $"{resp}.csv";    
        
        using (StreamWriter outputFile = new StreamWriter("Accounts.csv"))
        {
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("date, prompt, entry");
            
            // You can use the $ and include variables just like with Console.WriteLine
            //outputFile.WriteLine(_score);
            foreach (Accounts each in accountList)
            {
                
                string line = each.parseAccountDetails();

                outputFile.WriteLine(line);
                
            }
        }
    }
    
    public void LoadAccounts()
    {
        
        string[] lines = System.IO.File.ReadAllLines("Accounts.csv");


        for (int i = 0; i < lines.Length; i++)
        {
            // if (i == 0)
            //     {
            //         _score = int.Parse(lines[0]); // Assign a score to the first line  
            //     }
            
            string[] parts = lines[i].Split(",");
            string AccountName;
            string AccountDescription;
            string AccountType;
            
            AccountType = parts[0];
            AccountName = parts[1];
            AccountDescription = parts[2];

            

            switch (parts[0])
            {
                
                case "Incomes": //simple goal
                    Incomes myIncomesLoaded =  new Incomes(AccountName, AccountDescription);
                    AccountList.Add(myIncomesLoaded);
                    break;

                case "Expenses": // eternal goal
                    Expenses myExpensesLoaded =  new Expenses(AccountName, AccountDescription);
                    AccountList.Add(myExpensesLoaded);
                    break;

                // Check if this is the first line
                
            }
    }
    }

public void createBudgetMoth()
{
    Console.Write("Year?: ");
    string year = Console.ReadLine();

    Console.Write("Month?");
    string month = Console.ReadLine();

    MonthBudget myMonthBudget = new MonthBudget(year, month);
    MonthBudgetList.Add(myMonthBudget);
}

}