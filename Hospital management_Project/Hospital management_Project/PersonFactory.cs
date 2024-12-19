using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_Project
{
    internal static class PersonFactory
    {
        public static Patient CreatPatient(string name, int age, int national_id)
        {
            return new Patient
            {
                Name = name,
                Age = age,
                National_Id = national_id,
                Patient_Id = Guid.NewGuid().ToString()
            };
        }

        public static Doctor CreatDoctor(string name, int age, int national_id,string specialization)
        {
            return new Doctor
            {
                Name =name,
                Age=age,
                National_Id = national_id,
                Doctor_Id = Guid.NewGuid().ToString(),
                Specialization = specialization
            };
        }
    }
}
