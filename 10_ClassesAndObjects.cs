using System;
using System.Xml.Linq;

namespace CSharpTutorials.ClassesAndObjects
{
    public class Dish
    {

        public string dishName;
        int calories;
        int carbs = 0;
        int protien = 0;
        int fibre = 0;
        int fat = 0;
        int sugar = 0;
     
        //CONSTRUCTOR
        public Dish(string dishName, int calories, int carbs, int protien, int fibre)
        {
            this.dishName = dishName;
            this.calories = calories;
            this.carbs = carbs;
            this.protien = protien;
            this.fibre = fibre;
        }

        public String GetDetails()
        {
            return "Dish name : " + dishName +
                   "\nIt contain : " + calories +
                   " Kcal Calories.";
        }
    }

    //Can write main here too
    //public static void Main(string[] args)
    //{
    //    Dish overnightOats = new Dish("Overnight Oats",230100,17, 18);
    //    Console.WriteLine(overnightOats.GetDetails());
    //}

    class ClassesAndObjects
    {
        static void Main(string[] args)
        {
            //OBJECT ORIENTED PROGRAMMING 

            //CLASS
            //--------------------------------------------
            //A class in C# is a user-defined type that encapsulates data and behavior. It can contain fields, properties, methods, events and constructors. A class itself does not occupy memory until objects are created from it.

            /*
             Class declarations can include these components, in order:

                1. Modifiers: Define the accessibility of a class. By default, a class is internal. -> public, private, static
                2. Keyword class: Used to declare a class -> class ClassesAndObjects
                3. Class Identifier: The name of the class, conventionally starting with a capital letter. -> class ClassesAndObjects
                4. Base Class (Optional):Specifiesaparentclass to inherit from,  usingthe : symbol.
                5. Interfaces (Optional):Acommaseparatedlist of interfaces   implemented by the    class,   also preceded     by : A class can  implement multiple   interfaces.
                6. Body: Enclosed within { }, containing members like fields, properties, methods, constructors and events.
             */

            //OBJECTS
            //---------------------------------------------
            //Object in C# is something you create from a class, which represents a real-world entity and lets you use the data and actions defined in that class.

            /*
             In C# an object consists of :

                1. State: It is represented by attributes of an object and reflects the properties of an object.
                2. Behaviour: It is represented by the methods of an object and also reflects the response of an object with other objects.
                3. Identity: It gives a unique name to an object and enables one object to interact with other objects.Declaring Objects (Also called instantiating a class)

              Also called as the blueprint of class in C#
             */

            //When an object is created, the class is instantiated.

            //https://www.geeksforgeeks.org/c-sharp/class-and-object-in-c-sharp/

            //What is override - public override String ToString()
            //ToString() is overridden to return a formatted string of object details.


            /*
             
             When we declare a reference variable in C# (like Dog tuffy or Dog freedo), no memory for the object is allocated at that time. The variable only holds a null reference until we explicitly create an object using the new keyword.

            Initialization of Object
               The new keyword instantiates a class by allocating memory for a new object and returning a reference to that memory. The new operator also invokes the class constructor.

            When we create an object of the Dog class and pass the parameters in the constructor. So it allocates memory for these different objects and their address points with the class's object as shown in the image.
            */

            Dish overnightOats = new Dish("Overnight Oats", 230, 100, 17, 18);
            Console.WriteLine(overnightOats.GetDetails());
        }

    }
}
