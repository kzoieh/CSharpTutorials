using System;
//Console.WriteLine("Hello, Kasturi !");

namespace CSharpTutorials.HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Kasturi Kasturi !");
            //Console.Write("Number will be printed on same line.");
            //Console.Write(" " + 1 + 1);
            //Prints - Number will be printed on same line. 11

            Console.Write("Number will be printed on same line. ");
            Console.Write(1 + 1);
            //Prints - Number will be printed on same line. 2
        }
    }
}

/*
 * If we run the above program : Output - Hello, Kasturi !
 * 
 * 
 * Why ?
 * Top-level statements i.e. Console.WriteLine("Hello, Kasturi!"); override my Main() method
 * Top-level statements are a C# feature (introduced in C# 9) that allow you to write and run executable code directly at the file level without needing to declare a class, namespace, or static void Main/Main() method.
 * When you use top-level statements, the C# compiler automatically generates a hidden class and a hidden Main method for you.
 * 
 * 
 * So this:
 * Console.WriteLine("Hello");
 * 
 * is compiled into something like this:
 * 

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
    }
}

 * 
 * You just don’t see it.
 * 
 * 
 * When top-level statements are present, the compiler generates its own Main and uses that as the entry point and one program cant have two entry points. Console line on top will make its own main method and the main method inside the class will not be read by controller.
 * 
 * Therefore, only top-level code runs → prints "Hello, Kasturi!"


To print both the statements 
1. Change the name of method from main to something like PrintMessage(); public static void PrintMessage()
2. Call the method from main hello_world.Program.PrintMessage();

*/



//-------------------------------------------------------------------------------------------------------------------------------//





//Line 1: using "S"ystem means that we can use classes from the System namespace.
//Line 2: A blank line. C# ignores white space. However, multiple lines makes the code more readable.
//Line 3: namespace is used to organize your code, and it is a container for classes and other namespaces.
//Line 4: class is a container for data and methods, which brings functionality to your program.Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
//Line 5: Another thing that always appear in a C# program is the "M"ain method. 
//Line 6: "C"onsole is a class of the System namespace, which has a "W"rite"L"ine() method that is used to output/print text.In our example, it will output "Hello World!".If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.

//Note: C# is case-sensitive; "MyClass" and "myclass" have different meaning.
//Note: Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization).





//-------------------------------------------------------------------------------------------------------------------------------//
