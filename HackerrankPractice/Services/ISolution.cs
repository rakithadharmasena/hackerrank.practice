using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankPractice.Services
{
    public abstract class BaseSolution
    {
        public abstract void Execute();

        protected void Quit()
        {
            Console.WriteLine("Enter any key to return to main menu or r to run again\n");
            string userInput = Console.ReadLine();
            if (userInput=="r")
            {
                this.Execute();
            }
        }
    }
}
