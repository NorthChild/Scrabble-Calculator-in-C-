using System;

class ScrabbleMain
{
    static void Main(string[] args)
    {

        ScrabbleScore scorer = new ScrabbleScore();

        

        Console.WriteLine("Choose a word to count (press - to quit)");
        string word = Console.ReadLine();

        while (word != "-") {

            Console.WriteLine("The score for the word " + word + " is: " + scorer.GetScrabbleScore(word));

            Console.WriteLine("Choose a word to count (press - to quit)");
            word = Console.ReadLine();

        }



        

    }
}

