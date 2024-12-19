using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_Project
{
    internal class Room 
    {
        public int Room_Number { get; set; }
        public int Capacity { get; set; }
        public List<Patient> ListOfPatients { get; set; } = new List<Patient>();

        public void AssignPatient(Patient patient)
        {
            if (ListOfPatients.Count>=Capacity)
                throw new RoomFullException("Room is full, cannot assign more patients.");
            ListOfPatients.Add(patient);

            //try
            //{
            //    if (ListOfPatients.Count >= Capacity)
            //    {
            //        throw new InvalidOperationException($"The room num[ {Room_Number} ]capacity is full for [{patient.Name}]");

            //    }
            //    ListOfPatients.Add(patient);
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine($"Operator Room :");
            //    Console.ResetColor();
            //    Console.WriteLine($"patient name [{patient.Name}] is added");
            //}
            //catch (InvalidOperationException ex)
            //{

            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Error: {ex.Message}");
            //    Console.ResetColor();
            //}


        }
    } 
}
