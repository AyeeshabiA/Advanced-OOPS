using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum Dose{Default,Dose1,Dose2,Dose3}
    public class Vaccination
    {
        /*•	VaccinationID (Auto increment – VID1001)
•	Registration Number (Beneficiary Reg. num)
•	VaccineID
•	DoseNumber – (1,2,3)
•	Vaccinated Date (DateTime.Now)*/

        private static int s_vaccinationID=1000;
        public string VaccinationID{get;}
        public string RegistrationNumber{get; set;}
        public string VaccineID{get; set;}
        public Dose DoseNumber{get;}
        public DateTime VaccinatedDate{get; set;}

        public Vaccination(string registrationNumber,string vaccineID,Dose doseNumber,DateTime vaccinatedDate)
        {
            s_vaccinationID++;
            VaccinationID="VID"+s_vaccinationID;
            RegistrationNumber=registrationNumber;
            VaccinationID=vaccineID;
            DoseNumber=doseNumber;
            VaccinatedDate=vaccinatedDate;
        }



    }
}