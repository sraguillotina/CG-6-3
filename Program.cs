using System;

namespace Class6_AliceAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("I'm thinking of the first line from a famous children's book." +
                "\nIf you can guess a word from that line correctly, you win." +
                "\nEnter a word: ");
            //user input is assigned to string 'guess'
            string guess = Console.ReadLine();

            //Stored first line of Alice in WonderLand as firstLine string
            string firstLine = "Alice was beginning to get very tired of sitting by her sister on the bank," +
            "and of having nothing to do: once or twice she had peeped into the book her sister was reading," +
            "but it had no pictures or conversations in it, ‘and what is the use of a book,’" +
            "thought Alice ‘without pictures or conversation?’";

            //Invoked local method ConversionLowerCase to convert firstLine to lower case
            string lowerCaseAlice = ConversionLowerCase(firstLine);

            //Console prints if the user's entry ('guess' string) was found or not in the first line of
            //the book. Prints true or false.
            Console.WriteLine(AliceSearch(lowerCaseAlice, guess));

            Console.ReadLine();
        }

        //new method that converts a value to lowercase and returns as new string.
        private static string ConversionLowerCase (string input)
        {
            //returns a string converted to lower case.
            return input.ToLower(); 
        }

        /// <summary>
        /// Searches for a string in first line of Alice in Wonderland.
        /// </summary>
        /// <param name="aliceLine">Receives the code for the first line of the book.</param>
        /// <param name="userGuess">Receives the string from the user's entry.</param>
        /// <returns>True if the user's string is found. False if the string was not found.</returns>
        private static bool AliceSearch (string aliceLine, string userGuess)
        {
            if (aliceLine.Contains(userGuess))
            {
                return true;
            }
            else
                return false;
        }

        //private static bool SearchAlice (string aliceLine, string userGuess)
        //{
        //    string word = aliceLine;
        //    int start = word.IndexOf(userGuess);
        //    int end = userGuess.Length;
        //    word = word.Substring(start, end).ToString();

        //    int search = int.Parse(word);
        //    //int value1 = int.Parse(search);
            
        //    if (search < 0)
        //    {
        //        //Console.WriteLine("Congratulations");
        //        return false;
        //    }
        //    else if (search >= 0)
        //    {
        //        return true;
        //    }
        //    else
        //        return true;
            
        //}

        ////Notes: I tried to use the 'IndexOf' helper method, but was unable to figure out how to get
        ////the false (-1) value to not create exception.
        //string word = lowerCaseAlice;
        ////declared and initialized the variable start which searches for beginning character
        //var start = word.IndexOf(guess);
        ////declared and initialized the variable end which extends the search through the length
        //var end = guess.Length;
        ////Substring search 
        //word = word.Substring(start, end);
    }
}
