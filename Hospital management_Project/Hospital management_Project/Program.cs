using Hospital_management_Project;

Hospital hospital = Hospital.Instance;
hospital.InitializeHospital(2,2);

var p1 = PersonFactory.CreatPatient("reza", 23, 0110235284);
var p2 = PersonFactory.CreatPatient("mehdi", 32, 0115854578);
p1.AddToMedicalHistory("Flu");
p1.AddToMedicalHistory("Flu");
p1.AddToMedicalHistory("Flu");
Console.WriteLine(p1.Get_Details());
p1.show_list_history_medical();

hospital.AdmitPatient(p1);
hospital.AdmitPatient(p1);
hospital.AdmitPatient(p1);
hospital.AdmitPatient(p1);

hospital.AdmitPatient(p1);


var d1 = PersonFactory.CreatDoctor("Dr.ahmadi", 45, 0110235874, "ortoped");
Console.WriteLine(d1.Get_Details());
d1.Diagnose(p1,"shekastegi pa");





Console.ReadKey();