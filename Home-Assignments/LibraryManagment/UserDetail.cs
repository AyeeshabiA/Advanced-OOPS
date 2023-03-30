using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment
{
    public enum Gender { Default, Male, Female, Trangender }
    public class UserDetail
    {
        
        //static user id
        private static int s_userId = 100;

        //auto property
        
        public string UserId { get; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public string Department { get; set; }
        public double Phone { get; set; }
        public string MailId { get; set; }
        

        //parameterized contructor
        //assigning paramerts to properties

        public UserDetail(string userName, Gender gender, string department,long phone, string mailId)
        {
            //increment userId
            s_userId++;
            UserId = "CUS" + s_userId;


            UserName = UserName;
            Gender = gender;
            Department = department;
            Phone = phone;
            MailId = mailId;
            

        }

    }
}