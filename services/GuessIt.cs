using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class GuessIt
    {
        public string guess(string difficulty, int userGuess)
        {
            difficulty = difficulty.ToLower();
            int number = 0;
            if(difficulty == "easy" || difficulty =="e")
            {
                Random rand = new Random();
                number = rand.Next(1, 11); //1-10
            }
            else if(difficulty == "medium" || difficulty =="m" || difficulty =="med")
            {
                Random rand = new Random();
                number = rand.Next(1, 51); //1-10
            }
            else if(difficulty == "hard" || difficulty =="h")
            {
                Random rand = new Random();
                number = rand.Next(1, 101); //1-10
            }
            else
            {
                return "Invalid difficulty. Please choose Easy, Medium, or Hard.";
            }
            if(userGuess == number)
            {
                return "Congratulations! You guessed the correct number!";
            }
            else
            {
                return $"Sorry, the correct number was {number}. Better luck next time!";
            }
        }
    }
}