using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_Project
{
    internal class Patient : Person
    {
        public Patient(string patient_Id, List<string> medicalHistory):base()
        {
            Patient_Id = patient_Id;
            MedicalHistory = medicalHistory;
        }

        public Patient()
        {
        }

        public string Patient_Id { get; set; }
        private List<string> MedicalHistory { get; set; } = new List<string>();

        public void AddToMedicalHistory(string disease)
        {
            MedicalHistory.Add(disease);
        }
        public override string Get_Details()
        {
            return base.Get_Details() + $" Patient Id : {Patient_Id}";
        }
        public void show_list_history_medical()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Operator Patient :");
            Console.ResetColor();
            Console.WriteLine("the list of history medical ["+ string.Join(" , ",MedicalHistory)+"]");
           
        }
    }
}
