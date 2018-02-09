using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatementsWolfAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Are you feeling happy or Sad? ");
             string sAnswer = Console.ReadLine();
             if (sAnswer == "Happy")
             {
                 Console.WriteLine("You are feeling Happy. "); 
             }
             else if (sAnswer == "Sad")
             {
                 Console.WriteLine("You are feeling Sad.");
             }
             else
             {
                 Console.WriteLine("Sorry, I only know Happy or Sad. "); 
             }*/

            Console.WriteLine("Do you enjoy C# programming? (Yes/No/Maybe)");
            string sInput = Console.ReadLine();
                switch (sInput)
                {
                    case "Yes":
                        Console.WriteLine("That's Great!");
                        break;
                    case "Maybe":
                        Console.WriteLine("Of course you do!");
                        break; 
                    case "No" :
                        Console.WriteLine("Too bad!");
                        break;
                 }
            
        }
    }
}
