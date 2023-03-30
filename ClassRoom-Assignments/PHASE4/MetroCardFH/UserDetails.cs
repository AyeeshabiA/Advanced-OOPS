using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardFH
{
    //class for user details
    /// <summary>
    /// Class<see cref="UserDetails"/> used to collect user details from user
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// static field used to auto increment and it uniquely identify an instance of
        /// <see cref="UserDetails"/> class.
        /// </summary>
        private static int s_cardNumber = 100;
        /// <summary>
        /// property fro static field
        /// <see cref="UserDetails"/> class.
        /// </summary>
        /// <value></value>
        public string CardNumber { get; }
        /// <summary>
        /// property for user name
        /// <see cref="UserDetails"/> class
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// property for phone
        /// <see cref="UserDetails"/> class
        /// </summary>
        /// <value></value>
        public string Phone { get; set; }
        /// <summary>
        /// static field for balance
        /// <see cref="UserDetails"/> class
        /// </summary>
        /// <value></value>
        private double _balance { get; set; }
        /// <summary>
        /// property for balance 
        /// <see cref="UserDetails"/> class
        /// </summary>
        /// <value></value>
        public double Balance { get { return _balance; } }
        /// <summary>
        /// constructor for user details class and initialize a value
        /// </summary>
        /// <param name="userName">initialize a user name to user name property</param>
        /// <param name="phone">initialize a phone number to phone property</param>
        /// <param name="balance">initialize a balancr to the balance property</param>

        public UserDetails(string userName, string phone, double balance)
        {
            s_cardNumber++;
            CardNumber = "CMRL" + s_cardNumber;
            UserName = userName;
            Phone = phone;
            _balance = balance;
        }
        /// <summary>
        /// constructor for file handling and initialize a value
        /// </summary>
        /// <param name="user">getting values from the constructor using user obj</param>
        public UserDetails(string user)         //constructor for file handling
        {
            string[] values = user.Split(",");
            CardNumber = values[0];
            s_cardNumber = int.Parse(values[0].Remove(0, 4));
            UserName = values[1];
            Phone = values[2];
            _balance = double.Parse(values[3]);
        }

        /// <summary>
        /// method for reacharge(adding amount from user)
        /// <see cref="UserDetails"/> class.
        /// </summary>
        /// <param name="amount">parameter used to get a value from user and pssing to recharge method  </param>
        public void Recharge(double amount)         // method for recharge
        {
            _balance += amount;
        }

        /// <summary>
        /// method for deducting amount
        /// </summary>
        /// <param name="amount">parameter used to passing a value of ticket amount</param>

        public void DeductBalance(double amount)    //method for deduct balance
        {
            _balance -= amount;
        }






    }
}