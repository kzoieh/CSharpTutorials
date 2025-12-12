using System;

/*A constructor in C# is a special method of a class that is automatically called when an object of the class is created.
             
                    1.has the same name as the class, 
                    2.does not have a return type 
                    3.used to initialize the object’s data members.

              A class can define multiple constructors(constructor overloading).
              A constructor cannot be virtual or abstract. 
              Only a special kind of constructor can be static.
            */

/*
 Types of Constructor
 ---------------------------------------------------------------------------

Common constructor types are:

        ---------------------------------------------------------------------------

        -> Default Constructor
            - no parameter, automatically by compiler if not defined explicitely, initialize int to 0, bool to false, string/object to null.

           class Dog
           {
               public Dog()
                   {
                       Console.WriteLine("Dog Constructor was called");
                   }
            }

        ---------------------------------------------------------------------------

        -> Parameterized Constructor - has parameters

            class Dog
           {
               public Dog(string name)
                   {
                       this.name = name;
                       Console.WriteLine("Dog Constructor was called");
                   }
            }

        ---------------------------------------------------------------------------

        -> Copy Constructor - one object copies the other object

            Dog tuffy2 = new Dog(tuffy);
        ---------------------------------------------------------------------------

        -> Private Constructor - private specifier, not possible for other classes to derive from this class and also it’s not possible to create an instance of this class

                @It is the implementation of a singleton class pattern.
                @Use a private constructor when we have onlystaticmembers.
                @Using a private constructor prevents the creation of the instances of that class.

        ---------------------------------------------------------------------------

        -> Static Constructor - Static Constructor has to be invoked only once in the class and it has been invoked during the creation of the first reference to a static member in the class. A static constructor is initialized static fields or data of the class and is to be executed only once.

                @It can’t be called directly.
                @When it is executing then the user has no control.
                @It does not take access modifiers or any parameters.
                @It is called automatically to initialize the class before the first instance is created.

        ---------------------------------------------------------------------------
 */
public class Dish
{
    // private Constructor
    private Dish()
    {
        Console.WriteLine("From private constructor");
    }

    public static int countDishes;

    public static int DishCount()
    {
        return ++countDishes;
    }
}

public class Fish
{
    // private Constructor
    static Fish()
    {
        Console.WriteLine("From Static constructor");
    }

    public int countFishes;

    public Fish(int countFishes)
    {
        this.countFishes = countFishes;
        Console.WriteLine("From public constructor " + countFishes);
    }

    public int FishCount()
    {
        return ++countFishes;
    }
}

namespace CSharpTutorials.Constructors
{
    class Constructors
    {
        static void Main(string[] args)
        {
            //Dish d = new Dish();
            //'Dish.Dish()' is inaccessible due to its protection level
            // This will cause an error (private constructor)

            Dish.countDishes = 99;
            // Accessing without any instance of the class
            Console.WriteLine(Dish.countDishes);

            Dish.DishCount();
            // Accessing without any instance of the class
            Console.WriteLine(Dish.countDishes);

            //#output = 99 100

            Fish f1 = new Fish(1);
            Fish f2 = new Fish(2);
            //Fish f3 = new Fish(f2);

            //#Output
            //From Static constructor
            //From public constructor 1
            //From public constructor 2
        }
    }
}
