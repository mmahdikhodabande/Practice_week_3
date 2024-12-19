using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_management_system
{
    internal class Professor:Person
    {
        public int ProfessorId { get; set; }
        public string Subject { get; set; }

        public override string GetDetails()
        {
            return base.GetDetails() + $"the perofessor id is [{ProfessorId}] , subject is : [{Subject}]";
        }
    }
}
