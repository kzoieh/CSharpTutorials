using System;

namespace CSharpTutorials
{
    class StringFunctions
    {
        static void Main(string[] args)
        {
            string newString = "This is a string";

            // 1. Find the length of string - str.length
            Console.WriteLine("The Length of String = " + newString.Length);

            Console.WriteLine("String in Upper Case : "  + newString.ToUpper());
            Console.WriteLine("String in Lower Case : " + newString.ToLower());

            //STRING REMAINS THE SAME

            Console.WriteLine(newString);




            //CONCATANATION

            string firstName = "Kasturi";
            string lastName = "Kasturii";

            //Does not give a space in between
            string name = string.Concat(firstName, lastName);

            //Explicit addition of " "(space)
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(name);




            //STRING INTERPOLATION 
            //---------------------------------------------------
            //Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation:

            string fullName = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(fullName);

            // Here the $ symbol is used to initiate string interpolation.
            //$"Extra words that are to be added {variable1}{variable2}"




            Console.WriteLine($"Extra words that are to be added {firstName} and more words {lastName}{lastName}");
            //Notice there will be no gap between two printed lastnames.




            Console.WriteLine(fullName[5]);
            //Index based Accessing




            // find the index position of a specific character in a string, by using the IndexOf() method:
            Console.WriteLine(fullName.IndexOf("n"));
            Console.WriteLine(fullName.IndexOf("x"));
            //return -1




            //Substring() Function -  extracts the characters from a string, starting from the specified character position/index, and returns a new string.
            string subString = fullName.Substring(fullName.IndexOf("n"));
            Console.WriteLine(subString);
            //Output - name is: Kasturi Kasturii




            //string txt = "We are the so-called "Vikings" from the north.";
            //The compiler wont recognise the double quotes 
            //It is a specail character
            //The solution is to use the backslash escape character.
            //      \'	        '	        Single quote
            //      \"	        "           Double quote
            //      \\	        \	        Backslash
            //      \n                  	New Line	
            //      \t                      Tab	
            //      \b                      Backspace

            string txt = "It\'s Alright.";
            Console.WriteLine(txt);
        }
    }
}
