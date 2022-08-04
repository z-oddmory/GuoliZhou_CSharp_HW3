using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuoliZhou_CSharp_HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conceptual Questions
            //1.What are the six combinations of access modifier keywords and what do they do?
            //a.Public:Objects that implement public access modifiers are accessible from everywhere in a project without any restrictions.
            //b.Private: Objects that implement private access modifier are accessible only inside a class or a structure. As a result, we can’t access them outside the class they are created.
            //c.Protected:The protected keyword implies that the object is accessible inside the class and in all classes that derive from that class.
            //d.Internal:For Internal keyword, the access is limited exclusively to classes defined within the current project assembly.
            //e.Protected Internal:The protected internal access modifier is a combination of protected and internal. As a result, we can access the protected internal member only in the same assembly or in a derived class in other assemblies.

            //2.What is the difference between the static, const, and readonly keywords when applied to
            //a type member ?
            //a.A variable declared as const must be assigned a value at declaration, and this value may not then change at a later time.
            //b.A static member (variable, method, etc) belongs to the type of an object rather than to an instance of that type.
            //c.A readonly field is one where assignment to that field can only occur as part of the declaration of the class or in a constructor.

            //3. What does a constructor do?
            //In c#, Constructor is a method that will invoke automatically whenever an instance of class or struct is created. 

            //4. Why is the partial keyword useful?
            //The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace

            //5. What is a tuple?
            //A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have a data structure to hold an object with properties, but you don't want to create a separate type for it.

            //6. What does the C# record keyword do?
            //A record in C# is a class or struct that provides special syntax and behavior for working with data models.

            //7. What does overloading and overriding mean?
            //Method overriding — happens between the base class and derived class ; same method signature(access modifiers, method name, input/output); derived class can have different implementations for the same method
            //Method overloading — multiple methods in the same class, same signature(access modifiers, method name) but different input/ouput — compile time

            //8.What is the difference between a field and a property?
            //The key difference between field and property in C# is that a field is a variable of any type that is declared directly in the class while property is a member that provides a flexible mechanism to read, write or compute the value of a private field.

            //9.How do you make a method parameter optional?
            //a.By using default value; b.by using Method Overloadin; c.by using OptionalAttribute d.by Params Keyword

            //10.What is an interface and how is it different from abstract class?
            //An abstract class allows you to create functionality that subclasses can implement or override. An interface only allows you to define functionality, not implement it.

            //11.What accessibility level are members of an interface?
            //public, protected, internal, protected internal, private, private protected

            //12.True
            //13.False
            //14.False
            //15.True
            //16.False
            //17.True
            //18.True
            //19.False
            //20.True
            //21.True
            //22.False
            //23.False

        }
    }
}
