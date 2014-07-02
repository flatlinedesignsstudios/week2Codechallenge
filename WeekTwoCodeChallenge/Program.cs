using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //LetterCount
        
            //CALL FUNCTIONS
            Console.WriteLine("LETTERCOUNT");
            Console.WriteLine();
            LetterCount('i', "I love biscuits and gravy. It's the best breakfast ever");
            Console.WriteLine();
            LetterCount('n', "Never gonna give you up. Never gonna let you down");
            Console.WriteLine();
            LetterCount('s', "Sally sells seashells down by the seashore. She's from sussex");
            Console.ReadKey();
        }
        static void LetterCount(char letter, string inString) 
        {
            //declair veriabls
            int lowerCount = 0;
            int upperCount = 0;
            
            //code to make changes
            for (int i = 0; i < inString.Length; i++) 
            {
                
                    if(char.ToLower(letter) == inString[i])
                    {
                        lowerCount++;
                        
                    }
                    if (char.ToUpper(letter) == inString[i])
                    {
                        upperCount++;
                    }

            }
            int Total = lowerCount + upperCount;
            Console.WriteLine("Number of lowercase " + letter + "'s" + " found: " + lowerCount);
            Console.WriteLine("Number of UPPERCASE " + letter + "'s" + " found: " + upperCount);
            Console.WriteLine("Total Number of " + letter + "'s " + "found: " + Total);


            //FizzBuzz2
            for (int i = 0; i < 21; i++)
            {


                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        static void FizzBuzz(int number)
        {
            Console.ReadKey();
        }

        //TextStats

        
        static void TextStats(string input) 
        {
            {
                var numChar = input.Length;
                var numCharSplit = input.Split(' ');
                var numWords = numCharSplit.Length;
                int numVowels = 0;
                int numConsonant = 0;
                int numSpecChar = 0;

                var biggestWord = "";
                var shortestWord = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

                for (int i = 0; i < numCharSplit.Length; i++)
                {

                    if (numCharSplit[i].Length > biggestWord.Length)
                    {
                        biggestWord = numCharSplit[i];
                    }
                }

                for (int i = 0; i < numCharSplit.Length; i++)
                {
                    if (numCharSplit[i].Length < shortestWord.Length)
                    {
                        shortestWord = numCharSplit[i];
                    }
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "i" || input[i].ToString() == "o" || input[i].ToString() == "u")
                    {
                        numVowels = numVowels + 1;
                    }
                    else if (input[i].ToString() == "." || input[i].ToString() == "," || input[i].ToString() == "?" || input[i].ToString() == "!" || input[i].ToString() == "'")
                    {
                        numSpecChar = numSpecChar + 1;
                    }

                    else if (input[i].ToString() != " ")
                    {
                        numConsonant = numConsonant + 1;
                    }
                }

                Console.WriteLine(input);
                Console.WriteLine("The number of characters is " + numChar);
                Console.WriteLine("The number of words is " + numWords);
                Console.WriteLine("The number of vowels is " + numVowels);
                Console.WriteLine("The number of consonants is " + numConsonant);
                Console.WriteLine("There are" + numSpecChar + "special characters");
                Console.WriteLine("Longest Word: " + biggestWord);
                Console.WriteLine("Shortest Word: " + shortestWord);
                Console.WriteLine();
            }
            
                
                

            
        }
    }
}
