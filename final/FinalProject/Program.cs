using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        ActivityManager myActivityManager = new ActivityManager();

        while (true)
        {
            //Console.Clear();
            
            //Console.WriteLine($"\nYou have {_score} points");
            
            Console.Clear();
            Console.WriteLine("");
            myActivityManager.DisplayMenu();
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            string resp = Console.ReadLine();

            switch(resp)
            {
                
                
                case "1": // Accounts
                    
                    
                    myActivityManager.DisplayAccountSubMenu();    
                    
                    
                   break;
                
                case "2": // Budget
                        
                        myActivityManager.DisplayBudgetSubMenu();
                        

                    break;
                
                case "3": //save all
                    myActivityManager.SaveAccountFile(myActivityManager.getAccountList());
                    myActivityManager.SaveMonthBudgetFile(myActivityManager.GetMonthBudgetList());
                    Console.WriteLine("");
                    Console.WriteLine("Budget saved!");
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "4": //Load goals
                    myActivityManager.LoadAccounts();
                    Console.WriteLine("Account Loaded, see below: ");
                    myActivityManager.DisplayAccounts();
                    Console.WriteLine("");
                    
                    myActivityManager.LoadMonthBudget();
                    myActivityManager.DisplayMonthsBudget();
                    
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                
                case "5": //quit
                    Console.WriteLine("I see you later!");
                    return;
            }

        }

    }
    }






