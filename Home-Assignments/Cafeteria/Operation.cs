using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class Operation
    {
        CustomList<UserDetails> userDetailsList = new CustomList<UserDetails>();
        CustomList<PersonalDetails> personalDetailsList = new CustomList<PersonalDetails>();
        CustomList<OrderDetails> orderDetailsList = new CustomList<OrderDetails>();
        CustomList<FoodDetails> foodDetailsList = new CustomList<FoodDetails>();
        CustomList<CartItem> cartItemList = new CustomList<CartItem>();
        public UserDetails currentUser;
        public void Default()
        {

            UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", Gender.Male, "8857777575", "ravi@gmail.com", "WS101", 400);
            UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", Gender.Male, "9577747744", "baskaran@gmail.com", "WS105", 500);
            userDetailsList.Add(user1);
            userDetailsList.Add(user2);


            FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
            FoodDetails food2 = new FoodDetails("Tea", 25, 100);
            FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
            FoodDetails food4 = new FoodDetails("juice", 50, 100);
            FoodDetails food5 = new FoodDetails("puff", 40, 100);
            FoodDetails food6 = new FoodDetails("milk", 10, 100);
            FoodDetails food7 = new FoodDetails("popcorn", 20, 20);

            foodDetailsList.Add(food1);
            foodDetailsList.Add(food2);
            foodDetailsList.Add(food3);
            foodDetailsList.Add(food4);
            foodDetailsList.Add(food5);
            foodDetailsList.Add(food6);
            foodDetailsList.Add(food7);


            OrderDetails order1 = new OrderDetails("SF1001", new DateTime(2022, 06, 15), 70, Status.Ordered);
            OrderDetails order2 = new OrderDetails("SF1002", new DateTime(2022, 06, 15), 100, Status.Ordered);

            orderDetailsList.Add(order1);
            orderDetailsList.Add(order2);


            CartItem item1 = new CartItem("OID1001", "FID101", 20, 1);
            CartItem item2 = new CartItem("OID1001", "FID103", 10, 1);
            CartItem item3 = new CartItem("OID1001", "FID105", 40, 1);
            CartItem item4 = new CartItem("OID1002", "FID103", 10, 1);
            CartItem item5 = new CartItem("OID1002", "FID104", 50, 1);
            CartItem item6 = new CartItem("OID1002", "FID105", 40, 1);

            cartItemList.Add(item1);
            cartItemList.Add(item2);
            cartItemList.Add(item3);
            cartItemList.Add(item4);
            cartItemList.Add(item5);
            cartItemList.Add(item6);

        }

        public void MainMenu()
        {
            int option = 0;

            do
            {
                Console.WriteLine("Select the following:\n1.Registration\n2.Login\n3.Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("User Registration:");
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Login:");
                            Login();
                            break;
                        }

                }



            } while (option < 3);



        }
        public void Registration()
        {

            Console.WriteLine("Enter  name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter father name: ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter mailID: ");
            string mailID = Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());
            Console.WriteLine("Enter work station number:");
            string workStationNumber = Console.ReadLine();
            Console.WriteLine("Enter wallet balance: ");
            double walletBalance = double.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(name, fatherName, gender, phone, mailID, workStationNumber, walletBalance);
            userDetailsList.Add(user);
            Console.WriteLine($"Registration successfully  userID: " + user.UserID);


        }
        public void Login()
        {
            Console.WriteLine("Enter customerID");
            string loginID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserDetails user in userDetailsList)
            {
                if (loginID == user.UserID)
                {
                    flag = false;
                    Console.WriteLine("Login successful");
                    currentUser = user;
                    SubMenu();
                    break;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("Invalid userID");
            }

        }
        public void SubMenu()
        {
            int choice = 0;

            do
            {
                Console.WriteLine("select the following:\n1.ShowMyProfile\n2. FoodOrder\n3. CancelOrder\n4. OrderHistory\n5. WalletRecharge\n6.ShowWalletBalance\n7.Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("ShowMyProfile:");
                            ShowMyProfile();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(" FoodOrder:");
                            FoodOrder();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("CancelOrder:");
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(" OrderHistory:");
                            OrderHistory();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(" WalletRecharge:");
                            WalletRecharge();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(" ShowWalletBalance:");
                            ShowWalletBalance();
                            break;
                        }
                }


            } while (choice < 7);
        }

        public void ShowMyProfile()
        {
            System.Console.WriteLine($"{currentUser.UserID}|{currentUser.Name}|{currentUser.FatherName}|{currentUser.Gender}|{currentUser.Phone}|{currentUser.MailID}|{currentUser.WorkStationNumber}|{currentUser.WalletBalance}");

        }
        public void FoodOrder()
        {
            List<CartItem> cartList = new List<CartItem>();
            OrderDetails order = new OrderDetails(currentUser.UserID, DateTime.Now, 0, Status.Initiated);
            int count = 0;
            string answer = "";
            do
            {
                foreach (FoodDetails food in foodDetailsList)
                {
                    System.Console.WriteLine($"{food.FoodID}|{food.FoodName}|{food.FoodPrice}|{food.AvailableQuantity}");
                }
                orderDetailsList.Add(order);
                Console.WriteLine("Enter the foodID");
                string foodID = Console.ReadLine().ToUpper();
                bool flag = true;

                foreach (FoodDetails food in foodDetailsList)
                {
                    if (foodID == food.FoodID)
                    {
                        flag = false;
                        Console.WriteLine("Enter the quantity of the food: ");
                        count = int.Parse(Console.ReadLine());
                        bool stockFlag = false;
                        if (count <= food.AvailableQuantity)
                        {
                            stockFlag = true;
                            CartItem cartItem = new CartItem();
                            cartItem.OrderQuantity+=food.AvailableQuantity;
                            cartList.Add(cartItem);

                            System.Console.WriteLine("You want to pick another product");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "no")
                            {
                                System.Console.WriteLine("Are you confirm the wish list to purchase");
                                string answer1 = Console.ReadLine().ToLower();
                                if (answer1 == "yes")
                                {
                                    double totalPrice = count * food.FoodPrice;
                                    
                                    bool balFlag = false;
                                    string answer2="";
                                    do
                                    {
                                    if (totalPrice <= currentUser.WalletBalance)
                                    {
                                        balFlag = true;
                                        CartItem cart = new CartItem(order.OrderID, food.FoodID, food.FoodPrice, count);
                                        cartItemList.Add(cart);
                                        currentUser.DeductAmount(totalPrice);
                                        foreach(FoodDetails food1 in foodDetailsList)
                                        {
                                            food1.AvailableQuantity-=count;
                                        }
                                        foreach(OrderDetails order1 in orderDetailsList)
                                        {
                                            order1.TotalPrice+=totalPrice;
                                            order1.OrderStatus=Status.Ordered;
                                        }
                                        System.Console.WriteLine("Order placed successfully!  OrderID: "+order.OrderID);
                                    }
                                    if (balFlag == false)
                                    {
                                        Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet and do purchase again.");
                                        System.Console.WriteLine("Are you willing to recharge");
                                        answer2 = Console.ReadLine();
                                        bool rechargeFlag = true;
                                        if (answer2 == "no")
                                        {
                                            rechargeFlag = false;
                                            System.Console.WriteLine("Exiting without Order due to insufficient balance");
                                        }
                                        if (rechargeFlag == true)
                                        {
                                            System.Console.WriteLine("enter recharge amount: ");
                                            double amount = double.Parse(Console.ReadLine());
                                            currentUser.WalletRecharge(amount);
                                        }
                                    }
                                    }while(answer2=="yes");
                                }


                            }
                            if (stockFlag == false)
                            {
                                Console.WriteLine($"Stock not available. Available stock is: {food.AvailableQuantity}");
                            }

                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine("Invalid food id");
                    }
                }
            } while (answer == "yes");
        }
        public void CancelOrder()
        {
            bool flag = true;
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentUser.UserID == order.UserID && order.OrderStatus == Status.Ordered)
                {
                    flag = false;
                    Console.WriteLine($"{order.UserID}|{order.OrderID}|{order.OrderDate}|{order.TotalPrice}");
                }
            }
            if (flag == true)
            {
                Console.WriteLine("you have no order");
            }
            else
            {
                Console.WriteLine("Enter order id");
                string orderID = Console.ReadLine();
                foreach (OrderDetails order in orderDetailsList)
                {


                    if (orderID == order.OrderID && Status.Ordered == order.OrderStatus)
                    {
                        foreach (FoodDetails food in foodDetailsList)
                        {
                            foreach (CartItem cart in cartItemList)
                            {
                                if (food.FoodID == cart.FoodID)
                                {
                                    food.AvailableQuantity += cart.OrderQuantity;
                                    currentUser.WalletRecharge(order.TotalPrice);
                                    order.OrderStatus = Status.Cancelled;
                                    Console.WriteLine("order cancelled");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        public void OrderHistory()
        {
            foreach (OrderDetails order in orderDetailsList)
            {
                if (currentUser.UserID == order.UserID)
                {

                    Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.OrderDate}|{order.TotalPrice}|{order.OrderStatus}");
                }
            }
        }
        public void WalletRecharge()
        {
            Console.WriteLine("Are you reacharge your wallet(yes/no): ");
            string choose = Console.ReadLine().ToLower();
            if (choose == "yes")
            {
                Console.WriteLine("Enter reacharge amount: ");
                double amount = double.Parse(Console.ReadLine());
                currentUser.WalletRecharge(amount);
                Console.WriteLine("wallent balance: " + currentUser.WalletBalance);
            }
        }
        public void ShowWalletBalance()
        {
            System.Console.WriteLine("wallet balance: " + currentUser.WalletBalance);
        }

    }

}