using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardFH
{
    
    //class for user details
    /// <summary>
    /// Class<see cref="TicketFairDetails"/> used to collect user details from user
    /// </summary>
    public class TicketFairDetails
    {
        /// <summary>
        /// static field used to auto increment and it uniquely identify an instance of
        /// <see cref="TicketFairDetails"/> class.
        /// </summary>
         private static int s_ticketID=100;
         /// <summary>
        /// property fro static field
        /// <see cref="TicketFairDetails"/> class.
        /// </summary>
        /// <value></value>
        public string TicketID{get;}
        /// <summary>
        /// property for from location
        ///  <see cref="TicketFairDetails"/> class.
        /// </summary>
        /// <value></value>
        public string FromLocation{get; set;}
        /// <summary>
        /// property for to location
        ///  <see cref="TicketFairDetails"/> class.
        /// </summary>
        /// <value></value>
        public string ToLocation{get; set;}
        /// <summary>
        /// property for ticket price
        ///  <see cref="TicketFairDetails"/> class.
        /// </summary>
        /// <value></value>
        public double TicketPrice{get; set;}
        /// <summary>
        /// constructor for TicketFairDetails class to initialize a value
        /// </summary>
        /// <param name="fromLocation">initialize a value in from location parameter</param>
        /// <param name="toLocation">initialize a value in to location parameter</param>
        /// <param name="ticketPrice">initialize a value in ticket price  parameter</param>

        public TicketFairDetails(string fromLocation,string toLocation,double ticketPrice)
        {
            s_ticketID++;
            TicketID="MR"+s_ticketID;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            TicketPrice=ticketPrice;
        }
/// <summary>
/// constructor for file handling
/// </summary>
/// <param name="ticket">getting values from the constructor using ticket obj</param>

        public TicketFairDetails(string ticket)             //constructor for file handling
        {
            string[] values = ticket.Split(",");
            TicketID=values[0];
            s_ticketID=int.Parse(values[0].Remove(0,2));
            FromLocation=values[1];
            ToLocation=values[2];
            TicketPrice=double.Parse(values[3]);
        }


       
    }
}