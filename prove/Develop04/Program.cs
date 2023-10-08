using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Menu myMenu = new Menu();
        
        
        
        while (true)
        {
            Console.Clear();
            myMenu.DisplayMenu();

            Console.WriteLine("Select a choice from the menu: ");
            string resp = Console.ReadLine();

            switch(resp)
            {
                case "1":
                   
                    
                    BreathingActivity breathingActivity1 = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                    
                    breathingActivity1.DisplayStartingMessage();

                    // string duration_string = Console.ReadLine();
                    // int duration = int.Parse(duration_string);
                    // breathingActivity1.SetDuration(duration);
                    breathingActivity1.Run();
                    breathingActivity1.DisplayEndingMessage();
                    break;
                
                case "2":
                    string descriptionReflection = "This activity will help you reflect on times in your life when you have shown strength and resilience. This help you recognize the power you have and how you can use it in other aspects of your life.";
                    List<string> promptList = new List<string>();
                    promptList.Add("Think of a time when you did something really difficult");
                    promptList.Add("Reflect on a time when you felt outside your comfort zone"); 
                    promptList.Add("Reflect on a difficult decision you had to make");
                    promptList.Add("In your favorite hobby or passion, think about a moment when you faced a significant challenge");
                    promptList.Add("Reflect on a moment of spiritual or emotional significance in your life");
                    promptList.Add("Consider a time when you had to adapt to a major life change");
                    promptList.Add("In your favorite hobby or passion, think about a moment when you faced a significant challenge");
                    
                    List<string> questionList = new List<string>();
                    questionList.Add("How did you fell when it was completed?");
                    questionList.Add("What is your favorite thing about this experience?");
                    questionList.Add("What did you learn from that experience?");
                    questionList.Add("how did it shape your resilience?");
                    questionList.Add("what strengths did you discover within yourself?");
                    questionList.Add("what insights did you gain about yourself during that time?");

                    ReflectingActivity reflectingActivity1 = new ReflectingActivity("Reflection",descriptionReflection, promptList, questionList);
                    
                    reflectingActivity1.DisplayStartingMessage();
                    reflectingActivity1.Run();
                    reflectingActivity1.DisplayEndingMessage();

                    break;
                
                case "3":
                    string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    List<string> prompt = new List<string>();
                    prompt.Add("Gratitude for Nature: List as many aspects of nature that you are grateful for. This could include trees, flowers, the sky, or any natural beauty that brings you joy.");
                    prompt.Add("Acts of Kindness: Reflect on acts of kindness you've either received or witnessed recently. List as many of them as you can, no matter how small.");
                    prompt.Add("Favorite Memories: Recall your favorite memories from the past. List as many as you can, and immerse yourself in the positive emotions associated with them.");
                    prompt.Add("Daily Achievements: Think about the achievements, no matter how small, from your daily life. These could be tasks completed, personal goals achieved, or even moments of personal growth.");
                    prompt.Add("Positive Relationships: List the people in your life whom you are grateful for. Consider the positive impact they've had on you and your well-being.");
                    prompt.Add("Simple Pleasures: Reflect on the simple pleasures in your daily routine that bring you happiness, such as a warm cup of tea, a cozy blanket, or a favorite song.");
                    prompt.Add("Strengths and Qualities: List your personal strengths and positive qualities. Recognize the attributes that make you a unique and capable individual.");
                    prompt.Add("Future Hopes: Envision your future and list the things you're looking forward to. Consider your aspirations and goals, no matter how distant they may be.");


                    ListingActivity listingActivity1 = new ListingActivity("Listing", description, prompt);

                    listingActivity1.DisplayStartingMessage();
                    listingActivity1.Run();
                    listingActivity1.DisplayEndingMessage();


                    
                    
                    break;
                
                case "4":
                    
                    return;
            }

        }

    }
}