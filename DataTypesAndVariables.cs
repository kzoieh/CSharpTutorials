using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace CSharpTutorials.DataTypesAndVariables
{
    class DataTypesAndVariables
    {
        // VARIABLES, DATATYPES and TYPECASTING
        static void Main(string[] args)
        {
            Console.WriteLine("working");
            /*
             * Datatypes:
             * 
             * 1. int (x, y, -x, -y)
             * 4 bytes -  -2,147,483,648 to 2,147,483,647
             * 
             * 2. long 
             * 8 bytes - -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             * 
             * 3. float
             * 4 bytes - Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
             * 
             * 4. double (xx.yy, -xx.yy)
             * 8 bytes - Stores fractional numbers. Sufficient for storing 15 decimal digits
             * 
             * 5. char 'a'
             * 2 byte - Stores a single character/letter, surrounded by single quotes
             * 
             * 6. string "a bc"
             * 2 bytes per character - Stores a sequence of characters, surrounded by double quotes
             * 
             * 7. bool true/false
             * 1 byte - Stores true or false values 
            */

            int num;
            num = 0;
            Console.WriteLine(num);

            long longNum = 121231L;
            Console.WriteLine(longNum);

            float floatNum = 0.03453f;
            Console.WriteLine(floatNum);

            double doubleNum = 5.99D;
            Console.WriteLine(doubleNum);

            //Use float or double?

            //The precision of a floating point value indicates how many digits the value can have after the decimal point.
            //The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits.
            //Therefore it is safer to use double for most calculations.

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //e = power of 10


            string firstName = "Kasturi";
            Console.WriteLine(firstName);

            bool flag = true;
            Console.WriteLine(flag);

            //CONSTANTS IN CSHARP

            //const makes the variable immutable

            const int myNum = 10;
            //my_num = 12; gives error
            // You cannot declare a constant variable without assigning the value. If you do, an error will occur:

            Console.WriteLine(myNum);

            //CONCATANATION using +

            Console.WriteLine("Hello " + firstName);

            string lastName = "Kasturi";

            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);
            Console.WriteLine(firstName + " " + lastName);

            //Operation using + 

            Console.WriteLine(5 + myNum);

            int x, y, z;
            x = y = z = 10;
            Console.WriteLine(x + y + z);

            /*
             * VARIABLES 
             * 
             * Use camelCase
             * Variable Names can contain letters, digits and the underscore character (_)
             * Variable Names must begin with a letter or underscore
             * Variable Names should start with a lowercase letter, and cannot contain whitespace
             * Variable Names are case-sensitive ("myVar" and "myvar" are different variables)
             * Variable Reserved words (like C# keywords, such as int or double) cannot be used as names
             * 
            */

            //TYPECASTING

            /*
                * In C#, there are two types of casting:

                    *Implicit Casting (automatically) - 
                    *------------------------------------
                    *smaller to a larger type size
                    *char -> int -> long -> float -> double
                    *done automatically when passing a smaller size type to a larger size type:
                            int myInt = 9;
                            double myDouble = myInt;

                    *Explicit Casting (manually) - 
                    *------------------------------------
                    *larger to a smaller size type
                    *double -> float -> long -> int -> char
                    *done manually by placing the type in parentheses in front of the value
                            double myDouble = 9.78;
                            int myInt = (int) myDouble;

                    *Convert.ToBoolean,          \
                    *Convert.ToDouble,            \
                    *Convert.ToString,            //Explicit
                    *Convert.ToInt32 (int)       /
                    *Convert.ToInt64 (long)     /
            */

            int etcsInt = 10;
            double etcsDouble = 5.25;
            bool etcsBool = true;

            // The variable is not a good naming example, name should be meaningful.

            Console.WriteLine(Convert.ToString(etcsInt) + " String");    // convert int to string
            Console.WriteLine(Convert.ToDouble(etcsInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(etcsDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(etcsBool) + " String");   // convert bool to string
        }
    }
}



