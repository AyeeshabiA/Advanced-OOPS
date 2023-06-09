using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum Gender {Default,Male,Female}
    public class Beneficiary
    {
        /*a.	Registration Number (Auto Incremented BID1001)
b.	Name
c.	Age
d.	Gender (Enum [Male, Female, Others])
e.	Mobile Number
f.	City*/
        private static int s_registrationNumber=1000;
        public string RegistrationNumber{get; }
        public string Name{get; set;}
        public int Age{get; set;}

        public Gender Gender{get; set;}
        public string Phone{get; set;}
        public string City{get; set;}

        public Beneficiary(string name,int age,Gender gender,string phone,string city)
        {
            s_registrationNumber++;
            RegistrationNumber="BID"+s_registrationNumber;
            Name=name;
            Age=age;
            Gender=gender;
            Phone=phone;
            City=city;
        }
    }
}