using System;
using System.ComponentModel;
using System.IO;
namespace ExceptionHandling
{
    //A namespace cannot directly contain members such as fields, methods or statements
    //public void ProcessData(string data)
    //{
    //    if (string.IsNullOrEmpty(data))
    //    {
    //        throw new ArgumentException("Data cannot be     null    or     empty.", nameof(data));
    //    }
    //    else Console.WriteLine(data);
    //}

    class ExceptionHandling
    {
        //This becomes a method of class ExceptionHandling
        public void ProcessData(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException("Data cannot be     null    or     empty.", nameof(data));
            }
            else Console.WriteLine(data);
        }
        static void Main(string[] args)
        //static main class is the entry point for controller - cannot be public main
        {
            //EXCEPTION HANDLING 

            //-Handling runtime anamalies - exceptions

            // KEYWORDS - try, catch. finally, throw 

            /*
            try
            {

                 Code that may throw an exception
                 int result = x/y; - y can be zero based on data

            }

            catch (ExceptionType ex)
            {
                ExceptionType -> DivideByZeroException 
                Code to handle the exception - e.g. error message
                Can have multiple catch blocks

            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array index is out of range.");
            }

            catch (Exception ex)
            {
                Exception -> Handles any other exception
                Console.WriteLine("Some other exception occurred.");
            }

            finally
            {

                Code that will always execute
                It is mainly used for cleanup tasks like closing files, releasing resources, or clearing memory.
                Even if no exception occurs, the code in finally runs
            }

            int age = 15;

            if (age < 18)
            {
                throw new ArgumentException("Age must be 18 or  older.");
                The throw keyword manually raise an exception. It signal that an error or invalid condition has occurred.
                   
            }

            ArgumentException is the base class for more specific argument-related exceptions like ArgumentNullException (when an argument is null) and ArgumentOutOfRangeException (when an argument's value is outside the expected range).
            
            */

            int x = 1024;
            Console.Write("Value of y : ");
            int y = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            try
            {
                result = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (y == 0) Console.WriteLine("y cannot be zero");
                Console.WriteLine(result);
            }

            string str = "";
            //str = Console.ReadLine(); - ley suppose user did not provide the data.

            //ProcessData(str); - Throws Error
            //Calling ProcessData from a static method (Main) but ProcessData is a non-static method
            //Main is static, so it cannot directly call an instance method

            ExceptionHandling ProcessDataObject = new ExceptionHandling();
            ProcessDataObject.ProcessData(str);
            //Will throw error - try catch that for better execution
            //Or declare method like - public static void ProcessData(string data)
        }
    }
}

