using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_management_system
{
    internal class Student:Person
    {
        public int StudentId { get; set; }
        public string Major { get; set; }
        public override string GetDetails()
        {
            return base.GetDetails() + $"student id : [{StudentId}] , major is : [{Major}]"; 
        }
    }
}
