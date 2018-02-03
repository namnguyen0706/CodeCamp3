using System;
using System.Collections.Generic;
using System.Linq;


namespace CodeCamp3
{


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // orderArray();

                // bai 2;
                // List<int> number = new List<int>(){1,2,3};
                // List<int> square = new List<int>(){1,4,9};
                // List<int> number1 = new List<int>(){};
                // List<int> square1 = new List<int>(){};
                // TestForSquare(number,square);
                // TestForSquare(number1,square1);

                // bai 3
                List<string> str = new List<string>(){"top","shop"};
                List<string> str1 = new List<string>(){"top","shop","tep","word","tup","abc"};
                List<string> str2 = new List<string>(){"top","shop","TEP","web","net","yed"};
                GetTheLastWord(str);
                GetTheLastWord(str1);
                GetTheLastWord(str2);
                
            }
            catch (Exception ex)
            {
            
                System.Console.WriteLine(ex.Message);
            }
            
        }

        // bai 1: 
        public static void orderArray()
        {
            string[] cities = {"ROME","ZURICH","AMSTERDAM","SAIGON", "LONDON","HANOI","CALIFORNIA", "PARIS"};
            
            var result = from element in cities
                     orderby element.Length
                     select element;
        
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }

        // bai 2:
        public static bool TestForSquare(List<int> number, List<int>square)
        {

            var result = from element in number
                            let x = element*element
                            select x;
            bool temp = result.SequenceEqual(square);
            if(temp)
                System.Console.WriteLine("true");
            else
                System.Console.WriteLine("false");
            return true;   
        }

        // bai 3:
        public static string GetTheLastWord(List<string> str)
        {
            var query = from element in str
                            where element.Contains("e")|| element.Contains("E")
                            select element;
            if(query.Count()==0)
            {
                System.Console.WriteLine("null");
            }else
            {
                var result = from x in query
                                orderby x 
                                select x;
                System.Console.WriteLine("the last word is: "+ result.Last());
            }
            return " ";
        }
    }
}
