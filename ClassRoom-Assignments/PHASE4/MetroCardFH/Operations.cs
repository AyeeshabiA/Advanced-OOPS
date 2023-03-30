using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardFH
{
    public  class Operations
    {
        public delegate void EventManager();            //create event for delegate
        public static CustomList<UserDetails> userDetailsList = new CustomList<UserDetails>();  //list for user details
        public static CustomList<TravelDetails> travelDetailsList = new CustomList<TravelDetails>();    //list for travel details
        public static CustomList<TicketFairDetails> ticketFairDetailsList = new CustomList<TicketFairDetails>();       //list for ticket fair details
        public static UserDetails currentUser;      //global object for user details

        public static void MainMenu()           //main menu for registration and login
        {
            int option = 0;

            do
            {
                Console.WriteLine("Select the following:\n1.New User Registration\n2.Login User\n3.Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("******User Registration******");
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("******Login******");
                            Login();
                            break;
                        }

                }



            } while (option < 3);



        }
        //registration method
        public static void Registration()
        {
            Console.WriteLine("Enter user name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter balance: ");
            double balance = double.Parse(Console.ReadLine());
            //create obj for user details and store the details in the user details list
            UserDetails user = new UserDetails(userName,phone,balance);
            userDetailsList.Add(user);
            //generate card number
            Console.WriteLine($"Registration successfully  User card Number: " + user.CardNumber);
        }
        //login method 
        public static void Login()
        {
            Console.WriteLine("Enter user card number");
            string cardNumber=Console.ReadLine().ToUpper();
            bool flag=true;
            //traverse cardnumber in the user details list
            foreach (UserDetails user in userDetailsList)
            {
                //checking the card number is correct or not
                if(cardNumber==user.CardNumber)
                {
                    flag=false;
                  Console.WriteLine("Login successful");
                  //user is assgning to current user obj for current user is processing the following conditions
                  currentUser=user;
                  //creating sub menu
                  SubMenu();
                  break;
                }
               
            }
            // flag for invalid customer id
            if(flag==true)
            {
                Console.WriteLine("Invalid customerID");
            }
        }

        public static void SubMenu()
        {
            int answer=0;
            do
            {
            System.Console.WriteLine("select:\n1.BalanceCheck\n2.Recharge\n3.View Travel History\n4.Travel\n5.Exit");
            answer=int.Parse(Console.ReadLine());
            switch(answer)
            {
                case 1:
                {
                    System.Console.WriteLine("******Balance check******");
                    BalanceCheck();
                    break;
                }
                 case 2:
                {
                    System.Console.WriteLine("****** Reharge ******");
                    Recharge();
                    break;
                }
                 case 3:
                {
                    System.Console.WriteLine("******View travel history ******");
                    ViewTravelHistory();
                    break;
                }
                 case 4:
                {
                    System.Console.WriteLine("****** Travel ******");
                    Travel();
                    break;
                }

            }
            }while(answer<5);
        }
        //method for balance check in the sub menu
        public static void BalanceCheck()
        {
            System.Console.WriteLine("Balance: "+currentUser.Balance);
        }
        public static void Recharge()
        {
             Console.WriteLine("Enter reacharge amount: ");
            double amount = double.Parse(Console.ReadLine());
            //value passing to the recharge method 
            currentUser.Recharge(amount);
            Console.WriteLine("Balance: " + currentUser.Balance);
        }
        public static void ViewTravelHistory()
        {
            bool travelFlag=false;
            foreach (TravelDetails travel in travelDetailsList)
            {
                //checking card number in current user and travel details
                if (currentUser.CardNumber == travel.CardNumber)
                {
                    travelFlag = true;
                    //showing travel details to current user
                    System.Console.WriteLine($"{travel.TravelId}|{travel.CardNumber}|{travel.FromLocation}|{travel.ToLocation}|{travel.Date}|{travel.TravelCost}");
                }
            }
            if (travelFlag == false)
            {
                System.Console.WriteLine("you have no travel history");
            }
        }
        public static void Travel()
        {
            System.Console.WriteLine("****** Ticket Fair Details ******");
            foreach (TicketFairDetails ticket in ticketFairDetailsList)
            {
                //showing ticket details to the user using foreach
                System.Console.WriteLine($"{ticket.TicketID}|{ticket.FromLocation}|{ticket.ToLocation}|{ticket.TicketPrice}");
            }
            System.Console.WriteLine("Enter TicketID");
            string ticketID = Console.ReadLine();
            bool ticketFlag=false;
            bool balanceFlag=false;
            foreach (TicketFairDetails ticket in ticketFairDetailsList)
            {
                //checking ticket id correct or not
                if (ticketID == ticket.TicketID)
                {
                    ticketFlag=true;
                    //checking balance is sufficiant or not
                    if(currentUser.Balance>=ticket.TicketPrice)
                    {
                        balanceFlag=true;
                        //passing values to the deduct balance method
                        currentUser.DeductBalance(ticket.TicketPrice);
                        //adding current user travel details to the travel details list
                        TravelDetails travel = new TravelDetails(currentUser.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Now,ticket.TicketPrice);
                        travelDetailsList.Add(travel);
                        System.Console.WriteLine("Ticket booked Successfully!");
                    }
                    if(balanceFlag==false)
                    {
                        System.Console.WriteLine("Please Recharge , you have insufficiant balance");
                    }
                }
                if(ticketFlag==false)
                {
                    System.Console.WriteLine("Invalid TicketID");
                }
            }
        }
        

        public static void DefaultData()
        {

            UserDetails user1 = new UserDetails("Ravi", "98488", 1000);
            UserDetails user2 = new UserDetails("Baskaran", "99488", 1000);
            userDetailsList.Add(user1);
            userDetailsList.Add(user2);


            TravelDetails travel1 = new TravelDetails("CMRL101", "Airport", "Egmore", new DateTime(2022, 10, 10), 55);
            TravelDetails travel2 = new TravelDetails("CMRL101", "Egmore", "Koyambedu", new DateTime(2022, 10, 10), 32);
            TravelDetails travel3 = new TravelDetails("CMRL102", "Alandur", "Koyambedu", new DateTime(2022, 11, 10), 25);
            TravelDetails travel4 = new TravelDetails("CMRL102", "Egmore", "Thirumangalam", new DateTime(2022, 11, 10), 25);
            travelDetailsList.Add(travel1);
            travelDetailsList.Add(travel2);
            travelDetailsList.Add(travel3);
            travelDetailsList.Add(travel4);


            TicketFairDetails ticket1 = new TicketFairDetails("Airport", "Egmore", 55);
            TicketFairDetails ticket2 = new TicketFairDetails("Airport", "Koyambedu", 25);
            TicketFairDetails ticket3 = new TicketFairDetails("Alandur", "Koyambedu", 25);
            TicketFairDetails ticket4 = new TicketFairDetails("Koyambedu", "Egmore", 32);
            TicketFairDetails ticket5 = new TicketFairDetails("Vadapalani", "Egmore", 45);
            TicketFairDetails ticket6 = new TicketFairDetails("Arumbakkam", "Egmore", 25);
            TicketFairDetails ticket7 = new TicketFairDetails("Vadapalani", "Koyambedu", 25);
            TicketFairDetails ticket8 = new TicketFairDetails("Arumbakkam", "Koyambedu", 16);

            ticketFairDetailsList.Add(ticket1);
            ticketFairDetailsList.Add(ticket2);
            ticketFairDetailsList.Add(ticket3);
            ticketFairDetailsList.Add(ticket4);
            ticketFairDetailsList.Add(ticket5);
            ticketFairDetailsList.Add(ticket6);
            ticketFairDetailsList.Add(ticket7);
            ticketFairDetailsList.Add(ticket8);


        }

        private static event EventManager start;        //trigger the delegate 
          private static void Subscribe()
          {
            
            start=new EventManager(FileHandling.Create);
            //start+=new EventManager(Operations.DefaultData);
           start+=new EventManager(FileHandling.ReadFromCSV);
            start+=new EventManager(Operations.MainMenu);
            start+=new EventManager(FileHandling.WriteToCSV);
          }

          public static void Starter()
          {
            Subscribe();
            start();
          }
    }
}