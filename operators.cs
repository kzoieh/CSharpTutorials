using System;

namespace cSharpTutorials.operators
{
    class Operators
    {
        static void Main(string[] args)
        {
            Console.Write("Give value for x : ");
            string sx = Console.ReadLine();

            Console.Write("Give value for y : ");
            string sy = Console.ReadLine();

            //Console.ReadLine() method returns a String Datatype
            //Typecasting can be used to bring the input to desired format 

            int x = Convert.ToInt32(sx);
            int y = Convert.ToInt32(sy);

            //OPERATORS 

            // 1. Arithmatic +, -, *, /, %, ++, --

            Console.WriteLine("Sum x + y = " + (x + y));

            // 2. Assignment
            //     =          x = 5          x = 5
            //     +=         x += 3         x = x + 3
            //     -=         x -= 3         x = x - 3
            //     *=         x *= 3         x = x * 3
            //     /=         x /= 3         x = x / 3
            //     %=         x %= 3         x = x % 3
            //     &=         x &= 3         x = x & 3      Bitwise AND
            //     |=         x |= 3         x = x | 3      Bitwise OR
            //     ^=         x ^= 3         x = x ^ 3      POWER
            //     >>=        x >>= 3        x = x >> 3     RIGHT SHIFT
            //     <<=        x <<= 3        x = x << 3     LEFT SHIFT


            // 3. Comparision

            //      ==          Equal to                     x == y
            //      !=          Not equal                    x != y
            //      >           Greater than                 x > y
            //      <           Less than                    x<y
            //      >=          Greater than or equal to     x >= y
            //      <=          Less than or equal to        x <= y


            // 4. Logical 

            //      &&          Logical and Returns True if both statements are true                          x < 5 && x < 10
            //      ||          Logical or Returns True if one of the statements is true                      x < 5 || x < 4
            //      !           Logical not Reverse the result, returns False if the result is true           !(x < 5 && x < 10)


            // 5. Bitwise 

            //      &           Bitwise AND
            //      |           Bitwise OR
        }
    }
}
