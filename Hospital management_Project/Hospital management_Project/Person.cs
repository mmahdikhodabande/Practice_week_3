using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_Project
{
    internal class Person
    {
        public Person(string name, int age, int national_Id)
        {
            Name = name;
            Age = age;
            National_Id = national_Id;
        }

        public Person()
        {
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int National_Id { get; set; }


        public virtual string Get_Details()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Operator Person( Doctor / Patient ) : ");
            Console.ResetColor();
            return $"Name is :{Name}  Age is : {Age} , National id is : {National_Id}";
        }
    }
}
