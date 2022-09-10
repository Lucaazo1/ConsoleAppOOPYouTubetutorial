using System;

namespace ConsoleAppOOPYouTubetutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input;

                Console.WriteLine("Type 1 talk to others. Type 2 if you talk to yourself :)");
                input = Console.ReadLine();
                Person myperson = new Person();
                myperson.AskQuestion(int.Parse(input));
                Console.WriteLine("You are: " + myperson.GetPersonality());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an interger value.");
                
            }
            
        }
    }
}
