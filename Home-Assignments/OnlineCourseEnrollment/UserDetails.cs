using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseEnrollment
{
    public enum Gender{Default,Male,Female}
    public class UserDetails
    {
        /*a.	Registration ID (Auto Incremented – SYNC1001)
b.	UserName
c.	Age
d.	Gender – ( Enum – Male, Female, Transgender )
e.	Qualification
f.	MobileNumber
g.	MailID
*/      
        private int s_registrationID=1000;
        public string RegistrationID{get;}
        public string UserName{get; set;}
        public int Age{get; set;}
        public Gender Gender{get; set;}
        public string Qualification{get; set;}
        public string Phone{get; set;}
        public string MailID{get; set;}

        public UserDetails(string userName,int age,Gender gender,string qualification,string phone,string mailID)
        {
            s_registrationID++;
            RegistrationID="SYNC"+s_registrationID;
            UserName=userName;
            Age=age;
            Gender=gender;
            Qualification=qualification;
            Phone=phone;
            MailID=mailID;
        }
    }
}