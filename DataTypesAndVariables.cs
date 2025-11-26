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

            long l_num = 121231L;
            Console.WriteLine(l_num);

            float float_num = 0.03453f;
            Console.WriteLine(float_num);

            double double_num = 5.99D;
            Console.WriteLine(double_num);

            //Use float or double?

            //The precision of a floating point value indicates how many digits the value can have after the decimal point.
            //The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits.
            //Therefore it is safer to use double for most calculations.

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //e = power of 10


            string first_name = "Kasturi";
            Console.WriteLine(first_name);

            bool flag = true;
            Console.WriteLine(flag);

            //CONSTANTS IN CSHARP

            //const makes the variable immutable

            const int my_num = 10;
            //my_num = 12; gives error
            // You cannot declare a constant variable without assigning the value. If you do, an error will occur:

            Console.WriteLine(my_num);

            //CONCATANATION using +

            Console.WriteLine("Hello " + first_name);

            string last_name = "Kasturi";

            string full_name = first_name + " " + last_name;

            Console.WriteLine(full_name);
            Console.WriteLine(first_name + " " + last_name);

            //Operation using + 

            Console.WriteLine(5 + my_num);

            int x, y, z;
            x = y = z = 10;
            Console.WriteLine(x + y + z);

            /*
             * VARIABLES 
             * 
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

            int etcs_int = 10;
            double etcs_double = 5.25;
            bool etcs_bool = true;

            Console.WriteLine(Convert.ToString(etcs_int) + " String");    // convert int to string
            Console.WriteLine(Convert.ToDouble(etcs_int));    // convert int to double
            Console.WriteLine(Convert.ToInt32(etcs_double));  // convert double to int
            Console.WriteLine(Convert.ToString(etcs_bool) + " String");   // convert bool to string
        }
    }
}


