using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Appointment
    {
       // int AppointmentId { get; set; }
        int PatientId { get; set; }
        int DoctorId { get; set; }

        string PatientName { get; set; }
        string Problem {  get; set; }
        int BranchTesting { get; set; }
        DateTime now;

        public static List<Appointment> appointments = new List<Appointment>();

        public Appointment() { }

        public static void BookAppointment()
        {
            Console.WriteLine("Enter patient Id : ");
            int pid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter doctor Id : ");
            int did = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Patient Name : ");
            string pName = Console.ReadLine();

            Console.WriteLine("Select Problem. Press 1 : Heart. \n Press 2 : Headache. \n Press 3 : Lungs Issue. \n");
            string problems = Console.ReadLine();
            switch (problems)
            {
                case "1":
                    Console.WriteLine("Heart problem selected.");
                    problems = "Heart";
                    break;
                case "2":
                    Console.WriteLine("Headache problem selected.");
                    problems = "Headache";
                    break;
                case "3":
                    Console.WriteLine("Lungs problem selected.");
                    problems = "Lungs";
                    break;
            }

            appointments.Add(new Appointment { PatientId = pid, DoctorId = did, PatientName = pName, Problem = problems });
        }

        public static void UpdateAppointment()
        {
            Console.WriteLine("..........Appointments can be update by patient Id only..........");
            Console.WriteLine("Enter Patient ID you want to update record : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (appointments.Count < 1)
            {
                Console.WriteLine("There is no appointment registerd. \n \n");
            }
            else
            {
                foreach (var a in appointments)
                {
                    if (a.PatientId == id)
                    {
                        Console.WriteLine("..........Here the details of patient.........." + a.PatientId);
                        Console.WriteLine("..........Details of Doctor ID Number : " + a.PatientId);
                        Console.WriteLine("Doctor Name  :: " + a.PatientName);
                        Console.WriteLine("\n");
                        Console.WriteLine("Enter new name : ");
                        string name = Console.ReadLine();
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter gender : ");
                        Console.WriteLine("\n Press 1 : Male \n Press 2 : Female");
                        string gender = Console.ReadLine();
                        switch (gender)
                        {
                            case "1":
                                gender = "Male";
                                Console.WriteLine("Male Selected");
                                break;
                            case "2":
                                gender = "Female";
                                Console.WriteLine("Female Selected");
                                break;
                        }
                        a.PatientName = name;
                        Console.WriteLine("Appointment record updated successfully!..");
                    }
                    else
                    {
                        Console.WriteLine("..........'There is no doctor Registered by this ID'..........\n \n");
                    }
                }
            }
        }
    }
}
