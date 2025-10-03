using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Questions

            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            ////Get first Product out of Stock

            //var firstOutOfStock = Arr.FirstOrDefault(p => p == 0);

            //Console.WriteLine(firstOutOfStock);


            ////2. Return the first product whose Price > 1000, unless there is 
            ////   no match, in which case null is returned.

            //var Product = Arr.FirstOrDefault(p => p > 1000);
            //Console.WriteLine(Product);

            ////3. Retrieve the second number greater than 5 

            //var secondGreaterThanFiveNumber = Arr.Where(n => n > 5).ElementAtOrDefault(1);
            //Console.WriteLine(secondGreaterThanFiveNumber);

            ////Uses Count to get the number of odd numbers in the array

            //var oddNumber = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine($"Odd Number Count is : {oddNumber}");

            ////5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //string[] characters = File.ReadAllLines("dictionary_english.txt");

            //var Total = characters.Sum(w => w.Length);

            //Console.WriteLine($"Total Characters in array is : {Total}");

            //// 6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var MinLength = characters.Min(w => w.Length);

            //Console.WriteLine($"Shortest word Length in array is : {MinLength}");

            ////7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var MaxLength = characters.Max(w => w.Length);

            //Console.WriteLine($"Longest word Length in Array is : {MaxLength}");

            ////Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var AvgLength = characters.Average(w => w.Length);

            //Console.WriteLine($"Average word Length in array is  {AvgLength}");

            // 1.Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int>{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //var Remainder = numbers.GroupBy(n => n % 5);  

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine($"Remainder is : {Remainder}");
            //}


            #endregion
            #region Questions Partitation

            //Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            

            var result01 = numbers.Select((num, index) => new { num, index }).Where(x => x.num >= x.index)               
                .Select(x => x.num);

            Console.WriteLine(result01);

            // 4.Get the elements of the array starting from the first element divisible by 3.
            
            var result02 = numbers
                .Where(n => n % 3 != 0);  

            Console.WriteLine(result02);


            //5.Get the elements of the array starting from the first element less than its position.

            var result03 = numbers.Select((num, index) => new { num, index }).SkipWhile(x => x.num >= x.index)             
                .Select(x => x.num);                          

            Console.WriteLine( result03);



            //1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            string[] wordsCharacter = File.ReadAllLines("dictionary_english.txt");

            bool hasEi = wordsCharacter.Any(w => w.Contains("ei"));

            Console.WriteLine(hasEi ? " wordS containing 'ei'." : "No words Containing 'ei'.");





            #endregion

            //انا حليت علي قد ما اقدر وفيه حاجا ناسيها ولمااسمع السيشن هفتكرها ان شاء الله
            //بس مش قادر اسمع السيشن دلوقتي عشانMVC
        }
    }
}
