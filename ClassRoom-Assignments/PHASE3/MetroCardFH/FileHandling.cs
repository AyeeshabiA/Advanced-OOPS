using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MetroCardFH
{
    public class FileHandling  //class for file handling
    {
        public static void Create()  // creating folder and file 
        {
            //create folder MetroCardFH
            if(!Directory.Exists("MetroCardFH"))
            {
                Console.WriteLine("Creating folder");
                Directory.CreateDirectory("MetroCardFH");
            }

            //create file UserDetails
            if(!File.Exists("MetroCardFH/UserDetails.csv"))
            {
                Console.WriteLine("Creating file ");
                File.Create("MetroCardFH/UserDetails.csv").Close();
            }

            //create file TravelDetails
             if(!File.Exists("MetroCardFH/TravelDetails.csv"))
            {
                Console.WriteLine("Creating file ");
                File.Create("MetroCardFH/TravelDetails.csv").Close();
            }

            //craete file Ticket fair details
            if(!File.Exists("MetroCardFH/TicketFairDetails.csv"))
            {
                Console.WriteLine("Creating file ");
                File.Create("MetroCardFH/TicketFairDetails.csv").Close();
            }


        }
        //method for write to csv files
        public static void WriteToCSV()
        {
            //write csv file for User details class
            string[] users = new string[Operations.userDetailsList.Count];
            for (int i = 0; i < Operations.userDetailsList.Count; i++)
            {
                var user = Operations.userDetailsList[i];
                users[i] = user.CardNumber + "," + user.UserName + "," + user.Phone + "," + user.Balance;

            }
            File.WriteAllLines("MetroCardFH/UserDetails.csv", users);

             //write csv file for travel details class
             string[] travels = new string[Operations.travelDetailsList.Count];
            for (int i = 0; i < Operations.travelDetailsList.Count; i++)
            {
                var travel = Operations.travelDetailsList[i];
                travels[i] = travel.TravelId + "," + travel.CardNumber + "," + travel.FromLocation+ "," + travel.ToLocation + "," + travel.Date + "," +travel.TravelCost;

            }
            File.WriteAllLines("MetroCardFH/TravelDetails.csv", travels);

             //write csv file for ticket fair details class
             string[] tickets = new string[Operations.ticketFairDetailsList.Count];
            for (int i = 0; i < Operations.ticketFairDetailsList.Count; i++)
            {
                var ticket = Operations.ticketFairDetailsList[i];
                tickets[i] = ticket.TicketID + "," + ticket.FromLocation + "," + ticket.ToLocation+ "," + ticket.TicketPrice;

            }
            File.WriteAllLines("MetroCardFH/TicketFairDetails.csv", tickets);


        }

        //method for read from csv files
        public static void ReadFromCSV()
        {
            // read user details class
            string[]users=File.ReadAllLines("MetroCardFH/UserDetails.csv");
            for(int i=0;i<users.Length;i++)
            {
                Operations.userDetailsList.Add(new UserDetails(users[i]));
            }

            //read travel details class
             string[]travels=File.ReadAllLines("MetroCardFH/TravelDetails.csv");
            for(int i=0;i<travels.Length;i++)
            {
                Operations.travelDetailsList.Add(new TravelDetails(travels[i]));
            }

            //read ticket fair details class
             string[]tickets=File.ReadAllLines("MetroCardFH/TicketFairDetails.csv");
            for(int i=0;i<tickets.Length;i++)
            {
                Operations.ticketFairDetailsList.Add(new TicketFairDetails(tickets[i]));
            }
        }


    }
}