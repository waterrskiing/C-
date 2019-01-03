using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* You can use default constructor without params */
            Student obj = new Student();
            /* The new created obj using default constructor will have prefix properties value */
            Console.WriteLine(obj.Id);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Email);
            /* Or you can assign values for obj properties */
            obj.Id = 1;
            obj.Name = "Nguyen Van A";
            obj.Email = "a@gmail.com";
            /* Normal way to print out properties of obj */
            Console.WriteLine(obj.Id);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Email);

            /* Or you can use the constructor with params */
            Student objS = new Student(2, "Nguyen Van B", "b@gmail.com");
            Console.WriteLine(objS.Id);
            Console.WriteLine(objS.Name);
            Console.WriteLine(objS.Email);

            /* Use method Insert() from class Student */
            obj.Insert();

            Console.ReadLine();
        }
    }
}
