// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace AnagramFinder
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a single word: ");
//             string input = Console.ReadLine().ToLower();

//             Console.WriteLine("Enter a list of words separated by commas: ");
//             string wordListInput = Console.ReadLine().ToLower();

//             List<string> wordList = wordListInput.Split(',').Select(x => x.Trim()).ToList();

//             AnagramFinder finder = new AnagramFinder();
//             List<string> anagrams = finder.FindAnagrams(input, wordList);

//             if (anagrams.Count > 0)
//             {
//                 Console.WriteLine("The anagrams of '" + input + "' are: " + string.Join(", ", anagrams));
//             }
//             else
//             {
//                 Console.WriteLine("No anagrams were found.");
//             }
//         }
//     }

//     class AnagramFinder
//     {
//         public List<string> FindAnagrams(string input, List<string> wordList)
//         {
//             List<string> anagrams = new List<string>();

//             foreach (string word in wordList)
//             {
//                 if (IsAnagram(input, word))
//                 {
//                     anagrams.Add(word);
//                 }
//             }

//             return anagrams;
//         }

//         private bool IsAnagram(string word1, string word2)
//         {
//             if (word1.Length != word2.Length)
//             {
//                 return false;
//             }

//             char[] word1Chars = word1.ToCharArray();
//             char[] word2Chars = word2.ToCharArray();

//             Array.Sort(word1Chars);
//             Array.Sort(word2Chars);

//             for (int i = 0; i < word1Chars.Length; i++)
//             {
//                 if (word1Chars[i] != word2Chars[i])
//                 {
//                     return false;
//                 }
//             }

//             return true;
//         }
//     }
// }

// static void Main()
// {
//     Console.WriteLine("Enter your first word:");
//     string word1 = Console.ReadLine();

//     Console.WriteLine("Enter your second word:");
//     string word2 = Console.ReadLine();

//     bool areAnagrams = IsAnagramWord(word1, word2);

//     if (areAnagrams)
//     {
//         Console.WriteLine($"The words '{word1}' and '{word2}' are anagrams.");
//     }
//     else
//     {
//         Console.WriteLine($"The words '{word1}' and '{word2}' are not anagrams.");
//     }

//     Console.ReadLine();
// }

// static bool IsAnagramWord(string word1, string word2)
// {
//     // Convert the words to character arrays
//     char[] word1Chars = word1.ToCharArray();
//     char[] word2Chars = word2.ToCharArray();

//     // Sort the character arrays
//     Array.Sort(word1Chars);
//     Array.Sort(word2Chars);

//     // Compare the sorted character arrays
//     return Enumerable.SequenceEqual(word1Chars, word2Chars);
// }
