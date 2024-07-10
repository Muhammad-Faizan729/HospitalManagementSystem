using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Patient
    {
        int PatientId { get; set; }
        string PatientName { get; set; }
        int PatientAge { get; set; }
        string PatientGender { get; set; }

        public Patient() { }

        public static List<Patient> patients = new List<Patient>();

        public static void AddPatient()
        {
            Console.WriteLine("Enter patient id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter patient name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter patient age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select patient gender : ");
            Console.WriteLine("\n Press 1 : Male \n Press 2 : Female");
            string gender = Console.ReadLine();
            
            switch(gender)
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
            patients.Add(new Patient { PatientId = id, PatientName = name, PatientAge = age, PatientGender = gender });
            Console.WriteLine("Patient Added to List Successfully!..\n \n ");
        }
        public static void ViewPatientById()
        {
            Console.WriteLine("Enter patient Id you want to see details : \n");
            int id = Convert.ToInt32(Console.ReadLine());

            if(patients.Count < 1)
            {
                Console.WriteLine(" No Patient Found,List is empty !... \n \n");
            }
            else
            {
                foreach(var p in patients)
                {
                    if (p.PatientId == id)
                    {
                        Console.WriteLine("..........Details of Patient ID Number : " + p.PatientId );
                        Console.WriteLine("Patient Name  :: " + p.PatientName);
                        Console.WriteLine("Patient Age :: " + p.PatientAge);
                        Console.WriteLine("Patient Patient Gender :: " + p.PatientGender);
                    }
                    else
                    {
                        Console.WriteLine("..........'There is no patient Registered by this ID'..........\n \n");
                    }
                }
            }
        }

        public static void UpdatePatientRecord()
        {
            Console.WriteLine("Enter Patient ID you want to update record : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if(patients.Count < 1)
            {
                Console.WriteLine("No Patient patient registerd till yet \n \n");
            }
            else
            {
                foreach (var p in patients)
                {
                    if(p.PatientId == id)
                    {
                        Console.WriteLine("..........Here the details of patient.........." + p.PatientId);
                        Console.WriteLine("..........Details of Patient ID Number : " + p.PatientId);
                        Console.WriteLine("Patient Name  :: " + p.PatientName);
                        Console.WriteLine("Patient Age :: " + p.PatientAge);
                        Console.WriteLine("Patient Gender :: " + p.PatientGender);
                        Console.WriteLine("\n \n");
                        Console.WriteLine("Enter new name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter age : " );
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
                        p.PatientName = name;
                        p.PatientAge = age;
                        p.PatientGender = gender;
                        Console.WriteLine("Patient record updated successfully!..");
                    }
                    else
                    {
                        Console.WriteLine("..........'There is no patient Registered by this ID'..........\n \n");
                    }
                }
            }
        }

        public static void DeletePatient()
        {
            Console.WriteLine("Enter Patient ID you want to Delete record : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (patients.Count < 0)
            {
                Console.WriteLine("No Patient patient registerd till yet");
            }
            else
            {
                foreach (var p in patients)
                {
                    if(p.PatientId == id)
                    {
                        patients.Remove(p);
                        Console.WriteLine("Patient Deleted!..");
                    }
                    else
                    {
                        Console.WriteLine("No Patient Found!..");
                    }
                }
            }
        }
    }
    
}
