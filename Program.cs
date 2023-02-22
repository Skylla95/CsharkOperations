using System;
using System.Linq;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
            // this is where the magic happens :)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter a string:");
                string text = Console.ReadLine();

                Console.WriteLine("Choose an operation/ or more operation(separated with space) to perform:"); // not working in every case, yet :(
                Console.WriteLine("a. Convert to uppercase");
                Console.WriteLine("b. Reverse string");
                Console.WriteLine("c. Count vowels");
                Console.WriteLine("d. Count words");
                Console.WriteLine("e. Convert to title case");
                Console.WriteLine("f. Check if palindrome");
                Console.WriteLine("g. Find the longest and shortest words");
                Console.WriteLine("h. Suprise");
                Console.WriteLine("i. Exit");
                // the operations

                string[] operations = Console.ReadLine().Split(' ');// if the user wants multiple operations

                string result = text;

                foreach (string operation in operations)// in the multiple case
                {
                    switch (operation)
                    {
                        case "a":
                            result = result.ToUpper();
                            break;
                        case "b":
                            char[] charArray = result.ToCharArray();
                            Array.Reverse(charArray);
                            result = new string(charArray);
                            break;
                        case "c":
                            int vowelCount = 0;
                            foreach (char c in result.ToLower())
                            {
                                if ("aeiou".IndexOf(c) != -1)
                                {
                                    vowelCount++;
                                }
                            }
                            result = vowelCount.ToString();
                            break;
                        case "d":
                            int wordCount = result.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
                            result = wordCount.ToString();
                            break;
                        case "e":
                            result = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(result);
                            break;
                        case "f":
                            string reversedInput = new string(result.Reverse().ToArray());
                            if (reversedInput == result)
                            {
                                result = "This string is a palindrome.";
                            }
                            else
                            {
                                result = "This string is not a palindrome.";
                            }
                            break;
                        case "g":
                            string[] words = result.Split(' ');
                            string shortestWord = words.OrderBy(w => w.Length).FirstOrDefault();
                            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
                            result = $"Shortest word: {shortestWord}\nLongest word: {longestWord}";
                            break;
                        case "h":
                            result= "Hasbulla for president!";// my string manipulation
                            break;
                        case "i":
                            exit = true;
                            break;
                            
                                                                        
                              
                        default:
                            Console.WriteLine("Invalid operation");
                            break;

                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
