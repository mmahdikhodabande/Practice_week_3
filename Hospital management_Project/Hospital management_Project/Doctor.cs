using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_Project
{
    internal class Doctor : Person
    {
        public Doctor(string doctor_Id, string specialization) 
        {
            Doctor_Id = doctor_Id;
            Specialization = specialization;
        }

        public string Doctor_Id { get; set; }
        public string Specialization { get; set; }


        public void Diagnose(Patient patient,string disease)
        { 
            Patient P1 = patient;
            P1.AddToMedicalHistory(disease);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Operator Doctor : ");
            Console.ResetColor();
            Console.WriteLine($"the diagnose abount [{patient.Name}] is [{disease}]");
        }
        public override string Get_Details()
        {
            return base.Get_Details() + $"doctor id : {Doctor_Id} ,Specialization doktor is {Specialization} ";
        }
    }
}
