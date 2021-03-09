using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Developer's Bank", 100);
            Console.WriteLine("Welcome to the " + ourBank.BankName + "'s System");

            //Console.Write("Enter Your Choice");

            bool mawa = true;

            while (mawa)
            {

                ourBank.Operation();

                string mawaa = Console.ReadLine();

                switch (mawaa)
                {
                    case "open":
                        bool bcg = true;
                        while (bcg)
                        {
                            ourBank.BankCategory();
                            string btg = Console.ReadLine();

                            switch (btg)
                            {
                                case "savings":
                                    SavingsAc a1 = new SavingsAc(new Address());
                                    ourBank.AddAccount(a1);
                                    break;

                                case "checking":
                                    CheckingAc a2 = new CheckingAc(new Address());
                                    ourBank.AddAccount(a2);
                                    break;

                                case "quit":
                                    bcg = false;
                                    break;


                            }
                        }
                       
                        break;

                    case "account":

                        bool mawaaa = true;
                        while (mawaaa)
                        {
                            ourBank.Operations();
                            string mawa2 = Console.ReadLine();

                            //mawa = false;
                            switch (mawa2)
                            {

                                case "deposit":
                                    {
                                        ourBank.Transaction(1);

                                        break;
                                    }


                                case "withdraw":
                                    {
                                        ourBank.Transaction(2);
                                        break;
                                    }
                                case "transfer":
                                    {
                                        ourBank.Transaction(3);
                                        break;
                                    }

                                case "show":
                                    ourBank.PrintAllAccount();
                                    break;

                                case "change":
                                    {
                                        Account a2 = new Account(new Address());

                                        //ourBank.AddAccount(2)
                                        ourBank.AddAccount(2, a2);
                                        break;
                                    }
                                case "quit":
                                    mawaaa = false;
                                    break;

                            }


                        }
                        break;


                    case "quit":
                        mawa = false;
                        break;











                }
            }
        }
    }
}
