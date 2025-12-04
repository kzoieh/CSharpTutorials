using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

//if
//if-else
//if-else -if
//Nested if
//Switch
//Nested Switch

namespace ControlStatements
{
    class ControlStatements
    {
        public static void Main(string[] args)
        {
            //DECISION  MAKING STRUCTURES 
            //----------------------------------
            //If Else Statement
            int rank = 0;
            rank = 5;
            if (rank == 0)
            {
                Console.WriteLine("Rank not Alloted");
            }
            else
            {
                Console.WriteLine("Rank = " + rank);
            }



            //Else if Statement
            if (rank == 0)
            {
                Console.WriteLine("Rank not Alloted");
            }
            else if (rank == 1 || rank == 2 || rank == 3)
            {
                Console.WriteLine("Top Ranker");
            }
            else
            {
                Console.WriteLine("Rank = " + rank);
            }



            //Switch statements
            switch (rank)
            {
                case 0:
                    Console.WriteLine("Rank not Alloted");
                    break;
                case 1:
                    Console.WriteLine("Top Ranker");
                    break;
                case 2:
                    Console.WriteLine("Top Ranker");
                    break;
                case 3:
                    Console.WriteLine("Top Ranker");
                    break;
                default:
                    Console.WriteLine("Rank = " + rank);
                    break;
            }

            //We can make nested switch by adding switch inside switch statement



            //LOOP STRUCTURE
            //----------------------------------
            //Two Types of loop
            //1.Entry Controlled Loop
            //2.Exit Controlled Loop



            //While Loop
            int i = 6;
            while (i > 4) //(boolean condition)
            {
                Console.WriteLine("CheckWhile\n");
                i--;
            }



            //For Loop
            for (int idx = 0; idx < i; ++idx)
            {
                Console.WriteLine("CheckFL\n");
            }



            //do while loop
            do
            {
                Console.WriteLine("CheckDW\n");
                i++;
            }
            while (i < 6);



            //Infinite Loop
            //for(;;) Console.WriteLine("This is printed infinite times");

            //FOR EACK LOOP
            //foreach loop in C# is a special type of loop designed to iterate through collections like arrays, lists, and other enumerable data types. It simplifies the process of accessing each element in a collection without the need for manual indexing.

            char[] arr = { 'L', 'o', 'o', 'p' };

            // Using foreach to print 
            foreach (char ch in arr)
            {
                Console.WriteLine(ch + " ");
            }

            //Drawback
            //Connot index the container
            //cannot modify the container
            //single increment parsing only
            //No backward Iteration


            //Advantages
            //clean and concise syntax
            //enhances code readability
            //reduces the risk of off - by - one errors common in traditional loops.
            //handles index management 


            //JUMP STATEMENTS
            //----------------------------------

            //There are mainly five keywords in the Jump Statements which are mentioned below:

            //-> break
            //-> continue
            //-> goto
            //-> return
            //-> throw


            //Continue Statement 
            //Skip Operation for particular case
            for (int idx = 0; idx < 3; idx++)
            {
                if (idx == 2)
                    continue;

                Console.WriteLine("CheckContinue\n");
            }



            //Break Statement
            //terminate the loop or statement
            for (int idx = 0; idx < 3; idx++)
            {
                if (idx == 2)
                    break;

                Console.WriteLine("CheckContinue\n");
            }


            //goto Statement
            //Goto statement is used to transfer control to the labeled statement. The label is the valid identifier and is placed just before the statement from where the control is transferred.
            //switch (rank)
            //{
            //    case 0:
            //        Console.WriteLine("Rank not Alloted");
            //        break;
            //    case 1:
            //        Console.WriteLine("Top Ranker");
            //        break;
            //    case 2:
            //        Console.WriteLine("Top Ranker");
            //        break;
            //    case 3:
            //        Console.WriteLine("Top Ranker");
            //        break;
            //    default:
            //        Console.WriteLine("Rank = " + rank);
            //        goto case 0;
            //        break;
            //}
            int jump = 3;
            if (jump == 3) goto JumpHere;
            Console.WriteLine("Jump X 1");
        JumpHere:
            Console.WriteLine("Jump X 3");
            Console.WriteLine("Jump X 2");
            // Console.WriteLine("Jump X 1"); will be skipped
            // Console.WriteLine("Jump X 2"); will pe printed



            //return statement
            //as in return 0;



            //throw statement
            //throw statement is used to raise exceptions in C#. When an error occurs or a specific condition is met, weuse throw to signal that something unexpected happened. It is used as jump statement we can create custom exception and throw it when the condition is not met accordingly.
            //Examples in ExceptionHandling.cs File

        }
       
    }
}
