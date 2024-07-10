using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Doctor
    {
        int DoctorId { get; set; }
        string DoctorName { get; set; }
        int DoctorAge { get; set; }
        string DoctorGender { get; set; }

        public Doctor() { }

        public static List<Doctor> doctors = new List<Doctor>();

        public static void AddDoctor()
        {
            Console.WriteLine("Enter doctor id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter doctor name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter doctor age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select doctor gender : ");
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
            doctors.Add(new Doctor { DoctorId = id, DoctorName = name, DoctorAge = age, DoctorGender = gender });
            Console.WriteLine("Doctor Added to List Successfully!..\n \n ");
        }
        public static void ViewDoctorById()
        {
            Console.WriteLine("Enter doctor Id you want to see details : \n");
            int id = Convert.ToInt32(Console.ReadLine());

            if (doctors.Count < 1)
            {
                Console.WriteLine(" No doctor Found,List is empty !... \n \n");
            }
            else
            {
                foreach (var d in doctors)
                {
                    if (d.DoctorId == id)
                    {
                        Console.WriteLine("..........Details of doctor ID Number : " + d.DoctorId);
                        Console.WriteLine("Doctor Name  :: " + d.DoctorName);
                        Console.WriteLine("Doctor Age :: " + d.DoctorAge);
                        Console.WriteLine("Doctor Patient Gender :: " + d.DoctorGender);
                    }
                    else
                    {
                        Console.WriteLine("..........'There is no doctor Registered by this ID'..........\n \n");
                    }
                }
            }
        }

        public static void UpdateDoctorRecord()
        {
            Console.WriteLine("Enter Doctor ID you want to update record : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (doctors.Count < 1)
            {
                Console.WriteLine("No Doctor registerd till yet \n \n");
            }
            else
            {
                foreach (var d in doctors)
                {
                    if (d.DoctorId == id)
                    {
                        Console.WriteLine("..........Here the details of patient.........." + d.DoctorId);
                        Console.WriteLine("..........Details of Doctor ID Number : " + d.DoctorName);
                        Console.WriteLine("Doctor Name  :: " + d.DoctorName);
                        Console.WriteLine("Doctor Age :: " + d.DoctorName);
                        Console.WriteLine("Doctor Gender :: " + d.DoctorName);
                        Console.WriteLine("\n \n");
                        Console.WriteLine("Enter new name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter age : ");
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
                        d.DoctorName = name;
                        d.DoctorAge = age;
                        d.DoctorGender = gender;
                        Console.WriteLine("Doctor's record updated successfully!..");
                    }
                    else
                    {
                        Console.WriteLine("..........'There is no doctor Registered by this ID'..........\n \n");
                    }
                }
            }
        }

        public static void DeleteDoctor()
        {
            Console.WriteLine("Enter Doctor ID you want to Delete record : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (doctors.Count < 0)
            {
                Console.WriteLine("No Doctor registerd till yet");
            }
            else
            {
                foreach (var d in doctors)
                {
                    if (d.DoctorId == id)
                    {
                        doctors.Remove(d);
                        Console.WriteLine("Doctor Deleted!..");
                    }
                    else
                    {
                        Console.WriteLine("No Doctor Found!..");
                    }
                }
            }
        }
    }

}
