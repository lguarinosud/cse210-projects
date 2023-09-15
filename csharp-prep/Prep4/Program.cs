using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> list_int = new List<int>();
        string number_string;
        int number_int = 0;
        int number_sum = 0;
        int count = 0;
        float number_avg;
        int number_larger = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.: ");
        
        while (true)
        {
        
            count++;
            number_string =  Console.ReadLine();
            number_int = int.Parse(number_string);

            if (number_int != 0)
                {
                    list_int.Add(number_int);
                    number_sum += number_int;
                    if (number_int > number_larger)
                        {
                            number_larger = number_int;        
                        }
                }
            else
                { 
                    number_avg = number_sum / count;
                    Console.WriteLine($"The sum is {number_sum}");
                    Console.WriteLine($"The avarage is {number_avg}");
                    Console.WriteLine($"The larger number is {number_larger}");
                
                break;

                }

        
        
        }

           


    }

}