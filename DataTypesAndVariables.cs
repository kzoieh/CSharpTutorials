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
             * Data Types in C# is Mainly Divided into 3 Categories:
                -Value Data Types - will directly store the variable value in memory. The derived class for these data types are System.ValueType.
                -Reference Data Types - Reference data types in C# store the memory address (reference) of the actual data, not the data itself. 
                                        They are used for complex types like string, arrays, classes, interfaces and delegates.
                -Pointer Data Type - 

              1. Value Data Types  
              ---------------------------------------------------------------------------------------------------
             
              a) Integrals - 8-bit, 16-bit, 32-bit and 64-bit value
             
             * 1. int (x, y, -x, -y) - 32 bit -> -2,147,483,648 to 2,147,483,647 - System.Int32
             * 2. long - 64 bit -> -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 - System.Int64
             * 3. sbyte	- signed integer - 8bit	-> -128 to 127	System.SByte
             * 4. byte - unsigned integer - 8bit ->	0 to 255 System.Byte

              b) Floating Point Types - By default floating data types are the double type.
              
             * 3. float 0.0F - 32bit -> ±1.5 × 10-45 to ±3.4 × 1038 - Stores fractional numbers. Sufficient for storing 7 decimal digits - System.Single
             * 4. double 0.0D - 64bit -> ±5.0 × 10-324 to ±1.7 × 10308 - Stores fractional numbers. Sufficient for storing 15 decimal digits - System.Double

              c) Deecimal Types

             * 5. decimal 0.0M - 128bits - ±1.0 × 10-28 to ±7.9228 × 1028 -  suitable for financial and monetary calculations, has 28-29 digit precision - System.Decimal
              
              d)  Boolean 

             * 6. bool true/false - 8bits - Stores true or false values - System.Boolean
              
              e) Character Types
              
             * 7. char 'a' - 16bits -> U +0000 to U +ffff - Stores a single character/letter, surrounded by single quotes

              2. Reference Data Types
              ---------------------------------------------------------------------------------------------------
             
             * 1. string/String -  "a bc" - 16bits per character - Stores a sequence of characters, surrounded by double quotes - System.String
               
             * 2 Object -
                In C#, object is the base type from which all other types (value types and reference types) are derived.
                Converting a value type to an object is called boxing and converting it back is called unboxing.
                
                object obj;
                obj = 20; //boxing
                Console.WriteLine(obj); //unboxing
        
                // to show type of object using GetType()
                // Console.WriteLine(obj.GetType()); //System.Int32

                3. Pointer Data Types
                ---------------------------------------------------------------------------------------------------

                The Pointer Data Types will contain a memory address of the variable value. 
                To get the pointer details we have a two symbols ampersand (&) and asterisk (*).
                ampersand (&): It is known as Address Operator. It is used to determine the address of a variable.
                asterisk (*): It also known as Indirection Operator. It is used to access the value of an address.

                // Valid syntax 
                int* p1, p;   

                // Invalid
                int *p1, *p;  
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

            bool flag = true;
            Console.WriteLine(flag);


            //---------------------------------------------------------------------------------------------------


            string firstName = "Kasturi";
            Console.WriteLine(firstName); 
            

            object obj;
            obj = 20; 
            Console.WriteLine(obj); 
            

            //---------------------------------------------------------------------------------------------------

                
            int n = 10; 
            int* p = &n; // store variable n address location in pointer variable p
            Console.WriteLine("Value :{0}", n);
            Console.WriteLine("Address :{0}", (int)p);


            //---------------------------------------------------------------------------------------------------

            //CONSTANTS IN CSHARP

            //const makes the variable immutable

            const int myNum = 10;
            //my_num = 12; gives error
            // You cannot declare a constant variable without assigning the value. If you do, an error will occur:

            Console.WriteLine(myNum);
            

            //---------------------------------------------------------------------------------------------------
            

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





