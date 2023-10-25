using System.Collections;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
using System;
using System.IO;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

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
        _menuOptions.Add("   3. Save All");
        _menuOptions.Add("   4. Load All");
        _menuOptions.Add("   5. Quit");

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
    
public List<MonthBudget> GetMonthBudgetList()
{
    return MonthBudgetList;
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
   


public void DisplayMonthsBudget()
{
    Console.WriteLine($"========= Month ===========");
    foreach ( MonthBudget month in MonthBudgetList)
    {
        Console.Write("dont know");
        month.displayBudgetMonth();
    }
}
 public void DisplayBudgetSubMenu()
    {
        while (true)
        {
            Console.Clear();
            //Console.WriteLine("Select an option: ");

            Console.WriteLine("1.   Create a month Budget ");
            Console.WriteLine("2.   Edit a Month Item ");
            Console.WriteLine("3.   Display a Month Item ");
            Console.WriteLine("4.   Return to main Menu ");


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
                    createBudgetMoth();
                    Console.WriteLine("Budget Month Created:");
                    Console.WriteLine("");
                    

                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.ReadLine();
                    Console.Clear();
                    
                    
                    
                    break;
                
                case "2": // Edit an  Month budget
                        Console.WriteLine("===Edit a Month Budget===");
                        int count = 0;

                        foreach (MonthBudget item in MonthBudgetList)
                        {
                            string line = $"{count}.   {item.getBudgetMonthDetail()}";
                            Console.Write(line);

                        }
                        Console.WriteLine("");
                        Console.WriteLine("Select a month: ");
                        string resp = Console.ReadLine();
                        int monthPosition = int.Parse(resp) - 1;
                        MonthBudget monthSelected = MonthBudgetList[monthPosition];
                        monthSelected.displayBudgetMonth();
                        Console.WriteLine("");
                        Console.WriteLine("1.   Month");
                        Console.WriteLine("2.   Year");
                        Console.WriteLine("3.   Account budget");
                        Console.Write("What would you like to edit?");
                        Console.WriteLine("");
                        
                        resp = Console.ReadLine();
                        
                        switch (resp)
                            {
                                case "1":
                                    string currentMonth =  monthSelected.getMonth();
                                    Console.WriteLine($"Current month: {currentMonth}");
                                    Console.Write("Enter new month: ");
                                    Console.WriteLine("");

                                    resp = Console.ReadLine();
                                    monthSelected.setMonth(resp);
                                    Console.WriteLine($"Month updated from {currentMonth} to {resp}");
                                    Console.WriteLine("");
                                break;

                                case "2": 
                                    string currentYear =  monthSelected.getYear();
                                    Console.WriteLine($"Current Year: {currentYear}");
                                    Console.Write("Enter new Year: ");
                                    Console.WriteLine("");

                                    resp = Console.ReadLine();
                                    monthSelected.setMonth(resp);
                                    Console.WriteLine($"Year updated from {currentYear} to {resp}");
                                    Console.WriteLine("");
                                    break;

                                case "3":
                                    Console.WriteLine("");
                                    monthSelected.displayBudgetItems();
                                    Console.WriteLine("");
                                    
                                    Console.Write($"What budget's account do you want to update?: ");
                                    resp = Console.ReadLine();
                                    int position = int.Parse(resp) - 1;
                                    Console.WriteLine("");
                                    
                                    monthSelected.editItemBudget(position);
                                    
                                    break;
                            }
                                    
                            

                        Console.WriteLine("Hit enter to return to the main menu...");
                        Console.ReadLine();
                        Console.Clear();

                    break;
                
                case "3": // Display month
                    DisplayMonthsBudget();
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                
                case "4": //quit
                    //Console.WriteLine("Hit enter to return to the main manu");
                    //Console.WriteLine("");
                    //Console.ReadLine();
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

  public void SaveMonthBudgetFile(List<MonthBudget> monthBudgetList)
  {
    
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("date, prompt, entry");
            
            // You can use the $ and include variables just like with Console.WriteLine
            //outputFile.WriteLine(_score);
            foreach (MonthBudget each in monthBudgetList)
            {
                
                using (StreamWriter outputFile = new StreamWriter($"{each.getMonth()}_{each.getYear()}.csv"))
                {
                    
                    string firstLine = each.parseBudgetMonthDetails();

                    outputFile.WriteLine(firstLine);
                    List<BudgetItems> budgetItemsList = new List<BudgetItems>();
                    budgetItemsList = each.getBudgetItemList();
                    foreach (BudgetItems item in budgetItemsList)
                    {
                        string line = item.parseBudgetItemDetails();
                        outputFile.WriteLine(line);
                    }
                }
        }    
            
        
  }

public void LoadMonthBudget()
{
    string[] monthFilesPathList = monthFiles();
    
    foreach (string file in monthFilesPathList)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        string year = null;
        string month = null;
        string totalIncomes = null;
        string totalBalance = null;
        string totalExpenses = null;   
        MonthBudget myMonthBudget = null;
        for (int i = 0; i < lines.Length; i++) //for each line in the file:
        {
             
            string[] parts = lines[i].Split(",");
            
            
            
            if (i == 0) //takes month budget details from the first line
            {
                     
                year = parts[0];
                month = parts[1];
                totalIncomes = parts[2];
                totalBalance = parts[3];
                totalExpenses = parts[4];
                myMonthBudget = new MonthBudget(month, year, double.Parse(totalIncomes), double.Parse(totalBalance), double.Parse(totalExpenses));
                     
            }
            
            else
                   
            {
                 //create the month budget
                string accountName = parts[0];
                double accountBudget = double.Parse(parts[1]);
                string paymentMethod = parts[2];
                double accountBalance = double.Parse(parts[3]);
                
                //Console.WriteLine($"imprimi algo por ffavor  {accountName}, {accountBudget}, {paymentMethod}, {accountBalance}");

                BudgetItems mybudgetItems = new BudgetItems(year, month, accountName, accountBudget, paymentMethod, accountBalance); //creating the month item object. 
                
                myMonthBudget.addItemToBudget(mybudgetItems);
                


                   
            }
                
        }
    
        Console.WriteLine("=============Budget Month=============");
        myMonthBudget.displayBudgetMonth();
        
        Console.WriteLine("");
        Console.WriteLine($"Month Loaded!");
        Console.WriteLine("");
    
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

    Console.Write("Month? ");
    string month = Console.ReadLine();

    MonthBudget myMonthBudget = new MonthBudget(year, month); // Creates a month budget
    MonthBudgetList.Add(myMonthBudget); //Add the month budget to the list of month
    
    
    while (true)
    {
        Console.Clear();
        Console.WriteLine("=========Budget Month=============");
        Console.WriteLine(""); 
        myMonthBudget.displayBudgetMonth(); // Display the budget with accounts
        Console.WriteLine("");
        Console.WriteLine("=========Add accounts to the month=============");
        Console.WriteLine("");
        BudgetItems myItemBudget = createItemBudget(year, month); //Creates an item of the budget
        myMonthBudget.addItemToBudget(myItemBudget);  //Add the item (account) to the list of accounts for that month)
        
        Console.WriteLine(""); 
        Console.Write("Do you want to add another account? yes/no ");
        string resp = Console.ReadLine();

        if (resp == "no")
        {
            break;
        }
    }
}   



public BudgetItems createItemBudget(string year, string month)
{
    
    Console.WriteLine("");

    int count = 0;
    foreach (Accounts item in AccountList)
    {
        count++;
        string line = item.getAccountDetails();

        string selectAccount =  $"{count}.  {line}";
        Console.WriteLine(selectAccount);
    }

    Console.Write("Choose an account by typing the account number: ");
    string respName =  Console.ReadLine();

    int respNameToList =  int.Parse(respName) - 1;
    
    string name = AccountList[respNameToList].GetName();
    
    Console.WriteLine("");
    Console.Write($"Assing a budget to account \"{name}\" for the month: ");
    string respBudget = Console.ReadLine();
    double budget = double.Parse(respBudget);
    
    Console.WriteLine("");
    Console.Write("Assing a payment method (Cash/bank account):  ");
    string respPaymenthMethod = Console.ReadLine();

    BudgetItems myBudgetItem = new BudgetItems(year, month, name, budget, respPaymenthMethod, 0);
    Console.WriteLine("");
    Console.WriteLine("Account added to budget");
    return myBudgetItem;


    
}

public string[] monthFiles()
{
    string directoryPath = "month_budget/";
    //Console.WriteLine(Directory.GetCurrentDirectory());
        // Check if the directory exists.
        if (Directory.Exists(directoryPath))
        {
            // Get a list of file paths in the directory.
            string[] filePaths = Directory.GetFiles(directoryPath);

            return filePaths;
            
        }
        
        else
        {
            Console.WriteLine($"Directory '{directoryPath}'does not exist.");
            return new string[0];
            
        }
}

}