using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPYouTubetutorial
{
    class Person
    {
        //field
        private string Personality;

        //Constructor
        public Person()
        {
            Personality = "Mystery";
        }

        public void AskQuestion(int answer)
        {
            if (answer == 1)
            {
                Personality = "Extrovert";
            }
            else if(answer == 2)
            {
                Personality = "Introvert";
            }
            else
            {
                Personality = "You are still a mystery";
            }
        }
        //This method returns the value of personality
        public string GetPersonality()
        {
            return Personality;
        }

    }
}
