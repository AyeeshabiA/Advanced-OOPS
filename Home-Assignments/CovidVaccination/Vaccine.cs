using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum VaccineName{Default,Covishield,Covaccine}
    public class Vaccine
    {
        /*a.	VaccineID {Auto Incremented ID - CID101}
b.	VaccineName {Enum – Covishield, Covaccine}
c.	NoOfDoseAvailable*/
        private static int s_vaccineID=100;
        public string VaccineID{get;}
        public VaccineName VaccineName{get;}
        public int NoOfDoseAvailable{get; set;}


        public Vaccine(string vaccineID,VaccineName vaccineName,int noOfDoseAvailable)
        {
            s_vaccineID++;
            VaccineID="CID"+s_vaccineID;
            VaccineName=vaccineName;
            NoOfDoseAvailable=noOfDoseAvailable;

        }


    }
}