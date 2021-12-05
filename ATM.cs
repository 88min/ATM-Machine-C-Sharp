using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@author 88min

namespace ATM
{
    class program
    {
        static int deposit, withdraw;
        static int [] userValue = new int [3]; //maximum, minimum, balance
        static int choice;
        static void Menu()
        {
                Console.WriteLine("\n==========WELCOME TO ATM SERVICE!==========");
                Console.WriteLine("\n            [1] Current Balance");
                Console.WriteLine("\n            [2] Withdraw ");
                Console.WriteLine("\n            [3] Deposit ");
                Console.WriteLine("\n            [4] Cancel ");
                Console.Write("\nCHOICE : ");
                choice = int.Parse(Console.ReadLine());
                Operation();
        }
        static void Operation()
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nYOUR CURRENT BALANCE : {0} \n", userValue[0]);
                    Menu();
                    break;
                case 2:
                    Console.Write("\nENTER AMOUNT TO WITHDRAW      : ");
                    withdraw = int.Parse(Console.ReadLine());

                    if (withdraw < userValue[2]) //balance reach minimum
                    {
                        Console.WriteLine("\nDEAR CUSTOMER, ENTER AMOUNT MORE THAN " + userValue[2]);              
                    }
                    else if (withdraw > userValue[0]) //withdraw value > balance = insufficient
                    {
                        Console.WriteLine("\nDEAR CUSTOMER, YOU HAVE INSUFFICIENT BALANCE.\n");        
                    }
                    else
                    {
                        userValue[0] = userValue[0] - withdraw;
                        Console.WriteLine("WITHDRAWN SUCCESSFULLY!");
                        Console.WriteLine("YOUR CURRENT BALANCE IS NOW   : {0}", userValue[0]);                                    
                    }
                    Menu();
                    break;
                case 3:
                    Console.Write("\nENTER AMOUNT TO DEPOSIT       : ");
                    deposit = int.Parse(Console.ReadLine());

                     if (deposit >= userValue[1]) //balance reach maximum value
                    {
                        Console.WriteLine("\nDEAR CUSTOMER, YOU HAVE EXCEEDED THE MAXIMUM AMOUNT.\n");  
                    }           
                    else
                    {
                        userValue[0] = userValue[0] + deposit;
                        Console.WriteLine("DEPOSITED SUCCESSFULLY!");
                        Console.WriteLine("YOUR CURRENT BALANCE IS NOW   : {0}", userValue[0]);                    
                    }
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("\nTRANSACTION HAS BEEN CANCELED.");
                    Console.WriteLine("\nDEAR CUSTOMER, THANK YOU FOR USING THE ATM SERVICE!");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("\nDEAR CUSTOMER, INVALID INPUT PLEASE TRY AGAIN.\n");
                    Menu();
                    break;
            }         
        }

        static void Setter()
        {
            Console.Write("\nYOUR MAXIMUM BALANCE AMOUNT    : "); //set maximum balance
            userValue[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("YOUR MINIMUM BALANCE AMOUNT    : "); //set minimum balance
            userValue[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("YOUR CURRENT BALANCE           : "); //set current balance
            userValue[0] = Convert.ToInt32(Console.ReadLine());
        }

        public static void Main()
        {
            Setter();
            Menu();
            Operation();   
        }
    }
}
