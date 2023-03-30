using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class UserDetails:PersonalDetails,IBalance
    {
        /*•	UserID (Auto Incremented – SF1001)
•	WorkStationNumber
•	Field: _balance
•	Read only property: WalletBalance
*/
        private static int s_userID=1000;
        public string UserID{get;}
        public string WorkStationNumber{get; set;}
        private double _balance;
        public double WalletBalance{get{return _balance;}}

        public UserDetails(string name,string fatherName,Gender gender,string phone,string mailID,string workStationNumber,double WalletBalance):base( name, fatherName, gender, phone, mailID)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WorkStationNumber=workStationNumber;
            _balance=WalletBalance;
        }




        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }


        public void DeductAmount(double amount)
        {
            _balance-=amount;
        }
    }

    
}