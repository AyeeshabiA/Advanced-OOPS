using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseEnrollment
{
   
    public class Operations
    {
        List<UserDetails> UserDetailsList=new List<UserDetails>();
        List<CourseDetails> CourseDetailsList=new List<CourseDetails>();
        List<EnrollmentDetails>EnrollmentDetailsList=new List<EnrollmentDetails>();
        public void DefaultData()
        {
            /*Reg ID	Name	Age	Gender	Qualification	Mobile	Mail ID
            SYNC1001	Ravichandran 	30	Male	ME	9938388333	ravi@gmail.com

            SYNC1002	Priyadharshini	25	Female	BE	9944444455	priya@gmail.com

            */
            UserDetails user1 = new UserDetails("Ravichandran",30,Gender.Male,"ME","9938388333","ravi@gmail.com");
            UserDetails user2 = new UserDetails("Priyadharshini",25,Gender.Female,"BE","9944444455","priya@gmail.com");
            UserDetailsList.Add(user1);
            UserDetailsList.Add(user2);

            foreach(UserDetails user in UserDetailsList)
            {
                Console.WriteLine($"{user.RegistrationID}|{user.UserName}|{user.Age}|{user.Gender}|{user.Qualification}|{user.Phone}|{user.MailID}");

            }

            /**/
        }
    }
}