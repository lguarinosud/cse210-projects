using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal 
{
    // Variables
    public List<Entry> _entries = new List<Entry>();

    //Methods

    public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

    public void DisplayAll()
        {
            foreach (Entry item in _entries)
            {
                string line = $"Date: {item._date} - Prompt: {item._promptText}\n{item._entryText}";

                Console.WriteLine(line);
            }
        }

    public void SaveToFile()
    {
        Console.WriteLine("What's the filename? ");
        string resp = Console.ReadLine();
        string fileName = $"{resp}.csv";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("date, prompt, entry");
            
            // You can use the $ and include variables just like with Console.WriteLine

            foreach (Entry each in _entries)
            {
                string line = $"{each._date}, {each._promptText}, {each._entryText}";

                outputFile.WriteLine(line);
                
            }
            
        }

    }  

    public List<List<string>> LoadFromFile()
        {
            Console.WriteLine("What's the filename? ");
            string resp = Console.ReadLine();
            string fileName = $"{resp}.csv";
            
            string[] lines = System.IO.File.ReadAllLines(fileName);
            List<List<string>> _entriesLoaded = new List<List<string>>();

            foreach (string line in lines)
                {
                    List<string> _nestedList = new List<string>();

                    string[] parts = line.Split(",");

                    string date = parts[0];
                    string prompt= parts[1];
                    string entry = parts[2];

                    _nestedList.Add(date);
                    _nestedList.Add(prompt);
                    _nestedList.Add(entry);

                    _entriesLoaded.Add(_nestedList);

                }

            return _entriesLoaded;
        
        } 

}
