using System;
using System.Collections.Generic;
namespace LibraryManagment
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<UserDetail> userList = new List<UserDetail>();
            Console.WriteLine("Choose the following:\n1.Registration\n2.Login\n3.Exit");
            int choose = int.Parse(Console.ReadLine());
            string choice;
            int select;
            
            do
            {
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter User name : ");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Enter Gender: ");
                            Gender gender;
                            bool temp1 = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
                            while (!temp1)
                            {
                                Console.WriteLine("Entred wrong gender,Enter again");
                                temp1 = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
                            }
                            Console.WriteLine("Enter department: ");
                            string department = (Console.ReadLine());
                            Console.WriteLine("Enter Phone: ");
                            long phone = long.Parse(Console.ReadLine());
                            Console.WriteLine("Enter MailId: ");
                            string mailId = Console.ReadLine();
                            UserDetail user = new UserDetail(userName, gender, department, phone, mailId);
                            userList.Add(user);
                            Console.WriteLine($"Customerdetails added successfully. CustomerID: {user.UserId}");

                            break;
                        }
                    case 2:
                    {
                            //login process
                            Console.WriteLine("Enter userId: ");
                            string loginId = Console.ReadLine().ToUpper();
                            bool flag = true;
                            foreach (UserDetail user1 in userList)
                            {

                                if (user1.UserId == loginId)
                                {
                                    flag = false;
                                    //currentUser=user1
                                    
                                    Console.WriteLine("choose the following:\n1.Borrow book\n2.Show Borrowed history\n3.Return Books\n4.Exit ");
                                    select = int.Parse(Console.ReadLine());
                                }
                            }
                            if (flag == true)
                            {
                                Console.WriteLine("Entered wrong user ID");
                            }
                            break;

                    }
                }
                Console.WriteLine("you want to continue the process yes/no: ");
                choice = Console.ReadLine();

            } while (choice == "YES");
        }
    }
}
    
