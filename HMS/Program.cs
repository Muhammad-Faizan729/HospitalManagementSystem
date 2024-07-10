using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HMS
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool NoExit = true;
            while (NoExit)
            {
                Console.WriteLine("\n Press 1 : Add Patient \n Press 2 : Display Patient By Id \n Press 3 : Update Patient Record \n Press 4 : Delete Patient \n Press : 5 Add Doctor \n Press 6 : Display Doctor By Id \n Press 7 : Update Doctor Record \n Press 8 : Delete Doctor \n Press 9 : Exit");
                string UserValue = Console.ReadLine();
                switch (UserValue)
                {
                    case "1":
                        Patient.AddPatient();
                        break;
                    case "2":
                        Patient.ViewPatientById();
                        break;
                    case "3":
                        Patient.UpdatePatientRecord();
                        break;
                    case "4":
                        Patient.DeletePatient();
                        break;
                    case "5":
                        Doctor.AddDoctor();
                        break;
                    case "6":
                        Doctor.ViewDoctorById();
                        break;
                    case "7":
                        Doctor.UpdateDoctorRecord();
                        break;
                    case "8":
                        Doctor.DeleteDoctor();
                        break;
                    case "9":
                        NoExit = false;
                        break;
                }
            }
        }
    }
}