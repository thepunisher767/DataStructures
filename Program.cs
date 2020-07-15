using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a word you would like to reverse: ");
            string userInput = Console.ReadLine();
            string result = Reverse(userInput);
            Console.WriteLine(result);

        }

        private static string Reverse(string userInput)
        {
            int userInputLength = userInput.Length; //get string length
            string reverse = "";
            Stack<char> userString = new Stack<char>();
            for (int i = 0; i < userInputLength; i++)
            {
                char current = userInput[i];    //get character at index
                userString.Push(current);       //push to stack
            }
            foreach (char letter in userString)
            {
                reverse = reverse + letter;     //
            }
            return reverse;
        }
    }
}
