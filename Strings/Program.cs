using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.5.3
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, \'and what is the use of a book,\' thought Alice \'without pictures or conversation?\'";
            Console.WriteLine("Enter a word: ");
            string userInput = Console.ReadLine();
            bool isWithinFirstSentence = alice.ToLower().Contains(userInput.ToLower());
            Console.WriteLine(isWithinFirstSentence);

            //2.5.4
            string aliceRevised = alice.ToLower();
            while (aliceRevised.Contains(userInput.ToLower()))
            {
                int inputIndex = aliceRevised.IndexOf(userInput.ToLower());
                int length = userInput.Length;
                Console.WriteLine("Index: " + inputIndex + " Length: " + length);
                aliceRevised = aliceRevised.Remove(inputIndex, length);
                Console.WriteLine(aliceRevised);
            }
        }
    }
}
