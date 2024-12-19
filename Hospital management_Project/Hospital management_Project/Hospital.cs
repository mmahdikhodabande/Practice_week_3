using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_Project
{
    internal sealed class Hospital
    {
        private static Hospital _instance;
        public List<Doctor> ListOfDoctors { get; set; } = new List<Doctor>();
        public List<Room> ListOfRooms { get; set; } = new List<Room>();

        private Hospital() { }
        public static Hospital Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hospital();
                }
                return _instance;
            }
        }
        public void AdmitPatient(Patient patient)
        {
            //foreach (var room in ListOfRooms)
            //{
            //    if (room.ListOfPatients.Count < room.Capacity)
            //    {
            //        room.AssignPatient(patient);
            //        return;
            //    }
            //}
            Room availableRoom = ListOfRooms.FirstOrDefault(r => r.ListOfPatients.Count < r.Capacity);

            if (availableRoom != null)
            {
                availableRoom.AssignPatient(patient);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Operator Hospital : ");
                Console.ResetColor();
                Console.WriteLine($"Patient name [{patient.Name}] is /added/ the room num [{availableRoom.Room_Number}]");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Operator Hospital");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No available rooms. Admission failed.");
                Console.ResetColor();
            }
            
        }

        public void DischargePatient(Patient patient)
        {
            //foreach (var Room in ListOfRooms)
            //{
            //    if (Room.ListOfPatients.Contains(patient))
            //    {
            //        Room.ListOfPatients.Remove(patient);
            //        Console.WriteLine($"the patient name :{patient.Name} is discharge of room num :  {Room.Room_Number}");
            //        return;
            //    }
            //}
            //Console.WriteLine("");
            Room room = ListOfRooms.FirstOrDefault(n => n.ListOfPatients.Contains(patient));
            if (room != null)
            {
                room.ListOfPatients.Remove(patient);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Operator Hospital");
                Console.ResetColor();
                Console.WriteLine($"Patient name [{patient.Name}] is /removed/ from room num [{room.Room_Number}]");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Operator Hospital");
                Console.ResetColor();
                Console.WriteLine($"Patient name {patient.Name}not found in any room.");
            }
        }

        public void InitializeHospital(int room_Count, int room_capacity)
        {
            for (int i = 1; i <= room_Count; i++)
            {
                ListOfRooms.Add(
                    new Room
                    {
                        Room_Number = i,
                        Capacity = room_capacity
                    });
            }
        }
    }
}
