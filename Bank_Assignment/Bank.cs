using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;
        private SavingsAc[] mysaving;
        private CheckingAc[] mychecking;



        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.myBank = new Account[size];
            this.mysaving = new SavingsAc[size];
            this.mychecking = new CheckingAc[size];
        }

        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Account[] MyBank
        {
            get { return this.myBank; }
        }

        public void AddAccount(SavingsAc account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (mysaving[i] == null)
                {
                    Address s1 = new Address();
                    mysaving[i] = account;
                    Console.WriteLine("Enter Account Name: \n");
                    mysaving[i].AccountName = Console.ReadLine();

                    Console.WriteLine("Enter your Birth Date: ");
                    mysaving[i].Date = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your Birth Month: ");
                    mysaving[i].Month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your Birth Year: ");
                    mysaving[i].Year = Convert.ToInt32(Console.ReadLine());

                    mysaving[i].PrintDateOfBirth();

                    Console.WriteLine("Enter Your Address: \n");

                    Console.WriteLine("   Enter Your Hourse No.: ");
                    account.Address.HouseNo = Console.ReadLine();

                    Console.WriteLine("   Enter Your Road No.: ");
                    account.Address.RoadNo = Console.ReadLine();

                    Console.WriteLine("   Enter Your City: ");
                    account.Address.City = Console.ReadLine();

                    Console.WriteLine("   Enter Your Country No.: ");
                    account.Address.Country = Console.ReadLine();

                    int x = mysaving[i].PrintAccountNumber();
                    Console.WriteLine(x);
                    break;
                }
            }
        }

        public void AddAccount(CheckingAc account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (mychecking[i] == null)
                {
                    Address s1 = new Address();
                    mychecking[i] = account;
                    Console.WriteLine("Enter Account Name: \n");
                    mychecking[i].AccountName = Console.ReadLine();

                    Console.WriteLine("Enter your Birth Date: ");
                    mychecking[i].Date = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your Birth Month: ");
                    mychecking[i].Month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your Birth Year: ");
                    mychecking[i].Year = Convert.ToInt32(Console.ReadLine());

                    mychecking[i].PrintDateOfBirth();

                    Console.WriteLine("Enter Your Address: \n");

                    Console.WriteLine("   Enter Your Hourse No.: ");
                    account.Address.HouseNo = Console.ReadLine();

                    Console.WriteLine("   Enter Your Road No.: ");
                    account.Address.RoadNo = Console.ReadLine();

                    Console.WriteLine("   Enter Your City: ");
                    account.Address.City = Console.ReadLine();

                    Console.WriteLine("   Enter Your Country No.: ");
                    account.Address.Country = Console.ReadLine();

                    int x = mychecking[i].PrintAccountNumber();
                    Console.WriteLine(x);
                    break;
                }
            }
        }

        public void Deleteccount(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    Console.WriteLine("Congratulations!!! Your Account is successfully Deleted\n");

                    for (int j = i; j < myBank.Length - 1; j++)
                    {
                        myBank[j] = myBank[j + 1];
                    }
                }
            }
        }


        public void Transaction(int s, params int[] ab)
        {
            Account a2 = new Account();

            if (s == 2)
            {


                for (int i = 0; i <= mysaving.Length; i++)
                {
                    Console.WriteLine("Enter Your Account Number to Withdraw");
                    int accountNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Your Account Type: (Enter 1 or 2)");
                    Console.WriteLine("1. Saving Account\n2. Checking Account");

                    int actype = Convert.ToInt32(Console.ReadLine());
                    if (actype == 1)
                    {
                        if (accountNum == mysaving[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < mysaving.Length; i++)
                            {
                                if (mysaving[i] == null)
                                {
                                    continue;
                                }
                                else if (mysaving[i].AccountNumber == accountNum)
                                {
                                    Console.WriteLine("Enter The Amount You want to Withdraw: ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    mysaving[i].Withdraw(x);
                                    mysaving[i].count++;
                                    Console.WriteLine("Amount Withdraw successful");
                                    flag = 0;
                                    //break;
                                }

                                else
                                {
                                    flag = 1;
                                }

                            }

                        }
                    }

                    else if (actype == 2)
                    {
                        if (accountNum == mychecking[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < mychecking.Length; i++)
                            {
                                if (mychecking[i] == null)
                                {
                                    continue;
                                }
                                else if (mychecking[i].AccountNumber == accountNum)
                                {
                                    Console.WriteLine("Enter The Amount You want to Withdraw: ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    mychecking[i].Withdraw(x);
                                    mychecking[i].count++;
                                    Console.WriteLine("Account Had Withdraw");
                                    flag = 0;
                                    //break;
                                }

                                else
                                {
                                    flag = 1;
                                }

                            }

                        }


                    }
                    //break;
                }

            }


            else if (s == 1)  //deposit function
            {

                //Console.WriteLine("Enter Your Account Number to Deposit");
                //int accountNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= mysaving.Length; i++)
                {
                    Console.WriteLine("Enter Your Account Number to Deposit");
                    int accountNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Your Account Type: (Enter 1 or 2)");
                    Console.WriteLine("1. Saving Account\n2. Checking Account");

                    int actype = Convert.ToInt32(Console.ReadLine());
                    if (actype == 1)
                    {
                        if (accountNum == mysaving[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < mysaving.Length; i++)
                            {
                                if (mysaving[i] == null)
                                {
                                    continue;
                                }
                                else if (mysaving[i].AccountNumber == accountNum)
                                {
                                    Console.WriteLine("Enter The Amount You want to Deposit: ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    mysaving[i].Deposit(x);
                                    mysaving[i].count++;
                                    Console.WriteLine("Deposited");
                                    flag = 0;
                                    //break;
                                }

                                else
                                {
                                    flag = 1;
                                }

                            }

                        }
                    }

                    else if (actype == 2)
                    {
                        if (accountNum == mychecking[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < mychecking.Length; i++)
                            {
                                if (mychecking[i] == null)
                                {
                                    continue;
                                }
                                else if (mychecking[i].AccountNumber == accountNum)
                                {
                                    Console.WriteLine("Enter The Amount You want to Deposit: ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    mychecking[i].Deposit(x);
                                    mychecking[i].count++;
                                    Console.WriteLine("Deposited");
                                    flag = 0;
                                    //break;
                                }

                                else
                                {
                                    flag = 1;
                                }

                            }

                        }


                    }
                    //break;
                }

                //for (int i = 0; i <= mychecking.Length; i++)
                //{

                //break;
                //}


            }

            else if (s == 3)
            {

                for (int i = 0; i <= myBank.Length; i++)
                {
                    for (int j = 0; j <= MyBank.Length; j++)
                    {
                        Console.WriteLine("Enter Your Account Number");
                        int accountNum = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter The Account Number Where you want to Transfer");
                        int accountTNum = Convert.ToInt32(Console.ReadLine());


                        if (accountNum == myBank[i].AccountNumber || accountTNum == MyBank[j].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < myBank.Length; i++)
                            {
                                for (j = 0; j < myBank.Length; j++)
                                    if (myBank[i] == null || myBank[j] == null)
                                    {
                                        continue;
                                    }

                                    else if (myBank[i].AccountNumber == accountNum && myBank[j].AccountNumber == accountTNum)
                                    {
                                        Console.WriteLine("Enter The Amount You want to Deposit: ");

                                        double x = Convert.ToDouble(Console.ReadLine());
                                        myBank[i].Withdraw(x);
                                        myBank[j].Deposit(x);
                                        myBank[i].count++;
                                        Console.WriteLine("Deposited");
                                        flag = 0;
                                        //break;
                                    }
                                    else
                                    {
                                        flag = 1;
                                    }

                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Account not found");
                                // Console.WriteLine("Exit the System & Try Again");
                            }
                        }


                        //break;
                    }
                }
            }




        }

        public void PrintAllAccount()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
                myBank[i].PrintAccountNumber();
                Console.WriteLine("Number of Transaction: " + myBank[i].count);
            }
        }

        public void Operations()
        {
            Console.WriteLine("Choose Service from the Below Option");
            Console.WriteLine("Make a deposit");
            Console.WriteLine("Make a Withdrawal");
            Console.WriteLine("Make a transfer");
            Console.WriteLine("Show the number of transactions & balance");
            Console.WriteLine("Change User Name");
            Console.WriteLine("Exit the application");
            Console.WriteLine("/n");
            Console.WriteLine("Type deposit to deposit amount, Type withdraw to withdraw amount,Type transfer to transfer amount,Type show to Show the Number of Transaction & Balance,Type change to Change the User Name, Type quit to Exit from the System");


            Console.WriteLine("\n");


        }

        public void Operation()
        {
            Console.WriteLine("Choose Service from the Below Option");
            Console.WriteLine("1. Open A Bank Account");
            Console.WriteLine("2. Perform Transaction for an Account");
            Console.WriteLine("3. Exit the application ");
            Console.WriteLine("\n");
            Console.WriteLine("Type open to create an Account, Type account to perform Operation on Account, Type quit to Exit from the System");

            Console.WriteLine("\n");

        }


        public void AddAccount(int a, Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                Console.WriteLine("Enter the Account Number you want to Modify");
                int accountnumber = Convert.ToInt32(Console.ReadLine());

                if (myBank[i].AccountNumber == accountnumber)
                {
                    Console.WriteLine("Your User Name is" + myBank[i].AccountName);
                    Console.WriteLine("Enter the New User Name ");
                    string changeName = Console.ReadLine();
                    myBank[i].AccountName = changeName;

                    if (myBank[i].AccountName == changeName)
                    {
                        Console.WriteLine("Account Name Changed ");
                    }
                    else { Console.WriteLine("Try Again"); }


                }
                break;
            }
        }



        public void BankCategory()
        {
            Console.WriteLine("Choose Service from the Below Option");
            Console.WriteLine("1. Open A Savings Account");
            Console.WriteLine("2. Open A Checking Account");
            Console.WriteLine("3. Exit the application ");
            Console.WriteLine("\n");
            Console.WriteLine("Type savings to create a Savings Account, Type checking to create a Checking Account, Type quit to Exit from the System");

            Console.WriteLine("\n");

        }

    }
}
