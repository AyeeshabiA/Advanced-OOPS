using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardFH
{
    //class for user details
    /// <summary>
    /// Class<see cref="TravelDetails"/> used to collect user details from user
    /// </summary>
    public class TravelDetails              //propertis and field for Travel details class
    {
        /// <summary>
        /// static field used to auto increment and it uniquely identify an instance of
        /// <see cref="TravelDetails"/> class.
        /// </summary>
        private static int s_travelID = 100;      //static field for travel id
        /// <summary>
        /// property for static field 
        /// <see cref="TravelDetails"/> class.
        /// </summary>
        /// <value></value>
        public string TravelId { get; }
        /// <summary>
        /// property for card number
        /// <see cref="TravelDetails"/> class.
        /// </summary>
        /// <value></value>
        public string CardNumber { get; set; }
        /// <summary>
        /// <see cref="TravelDetails"/> class.
        /// property for from location
        /// </summary>
        /// <value></value>
        public string FromLocation { get; set; }
        /// <summary>
        /// property for to location
        /// <see cref="TravelDetails"/> class.
        /// </summary>
        /// <value></value>
        public string ToLocation { get; set; }
        /// <summary>
        /// property for date
        /// <see cref="TravelDetails"/> class.
        /// </summary>
        /// <value></value>
        public DateTime Date { get; set; }
        /// <summary>
        /// property for travel cost
        /// <see cref="TravelDetails"/> class.
        /// </summary>
        /// <value></value>
        public double TravelCost { get; set; }
        /// <summary>
        /// constructor for Travel details class and passing arguments and initialize a value
        /// </summary>
        /// <param name="cardNumber">initialize a value to card number</param>
        /// <param name="fromLocation">initialize a value at from location</param>
        /// <param name="toLocation">initialize a value at to location</param>
        /// <param name="date">initialize a value at date</param>
        /// <param name="travelCost">initialize a value at travel cost</param>

        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelCost)
        {
            s_travelID++;
            TravelId = "TID" + s_travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }
        /// <summary>
        /// constructor for file handling and initialize a value
        /// </summary>
        /// <param name="travel">used to get a values from the constructor</param>
        public TravelDetails(string travel)             //constructor for file handling
        {
            string[] values = travel.Split(",");
            TravelId = values[0];
            s_travelID = int.Parse(values[0].Remove(0, 3));
            CardNumber = values[1];
            FromLocation = values[2];
            ToLocation = values[3];
            Date = DateTime.Parse(values[4]);
            TravelCost = double.Parse(values[5]);
        }



    }
}