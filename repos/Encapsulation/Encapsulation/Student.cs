using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Student
    {
        /* Declare properties for objects in class Student - use prop and hold tab */
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        /* By default, the constructor (ham khoi tao) has no params */
        public Student()
        {
            /* Inside the default constructor without params, you can pre-fix the values for obj properties */
            Id = 0;
            Name = "BOT";
            Email = "dump@gmail.com";
        }
        /* But you can create a constructor with params */
        public Student(int Id, string Name, string Email)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
        }
        /* Declare methods for class Student */
        public void Insert()
        {
            Console.WriteLine("Them moi sinh vien");
        }
    }
}
