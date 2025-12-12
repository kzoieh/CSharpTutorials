
    1.CSharp runs on .NET Framework.
    2. .NET Framework is a software development framework.
    3. .NET framework is primarily used on Windows, while .NET Core (which evolved into just .NET starting from version 5) is cross-platform.




A basic program consists of the following:
- library declarations
- a namespace Declaration
- class Declaration & Definition
- class Members(like variables, methods, etc.)
- Main method
- Statements or Expressions



using System;

    using System: allows access to built-in classes like Console.
    Library for basic keywords, operations and actions 
    Like using<stdc++.h> in C++ 
 
namespace ProjectName.LogicFiles

    Namespace defines a logical group/ container in which my class, interfaces, enums live.
    Usually it is a good practice to describe the heirarchy of folders in the name of namespace like: ProjectName.LogicFiles
    For example : MyProject.Models
    Multiple files in a project can have same namespace name, this represent that they belong to same logical group, like Model/Controllers.
    For Controllers it is important that the name ends with Controller eg. HomeController : Controller.
    HomeController is a Class that inherits Controller Class.
    It also helps us to access a lot of classes/variables/methods by just using single statement. {using MyProject.Models}
    We can also use any random name like namespace xyz but using heirarchy is a good practice.
    These practices help to organise code to meaningful groups.

    Naming Nomenclature
    ------------------------------------
    0. Use PascalCase.
    1. A-Z, a-z, 0-9, _ (underscore - not preffered), . (period)
    2. Cannot start with number
    3 No space and special characters
    4. No use of Keywords
    [namesapce name must be a valid Identifier :
     eg. Operator is a C# keyword, we can use : namespace @Operator <- will work
     But highly Discouraged.]
    
    Multiple files can have same namespace name to define logical group,
    but is important to notice that compiler is not logically making groups, 
    everything is used like a library.

{
    class FileName
    
    /*
     The class name is an indentifier 
     In C#, an identifier can be a class name(FileName), method name(Main), variable name, or label.
     ([A-Z], [a-z], [0-9]), '_' (underscore - do not contain two consecutive underscores)
     Identifiers should not start with digits([0-9]).
     Identifiers must not contain whitespace characters.
     Identifiers are not allowed to use as keywords unless they include @ as a prefix.
     C# identifiers allow Unicode Characters, cannot contain more than 512 characters..
     */
     
    {
        public string Variable { get; set; }
        static void Main(string[] args)
        {
            //Every C# program starts execution from the Main method. The Entry point of a program
        }        
    }
}
