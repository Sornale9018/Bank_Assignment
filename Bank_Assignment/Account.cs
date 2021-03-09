using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private int date;
        private int month;
        private int year;
        public double balance;
        private Address address;
        static int a = 39353;
        public int count = 0;

        public Account()
        { }

        public Account(Address address)
        {

            this.address = address;
        }
        public int AccountNumber
        {

            get { return this.accountNumber; }
        }

        public int Date
        {
            set { this.date = value; }
            get { return this.date; }
        }

        public int Month
        {
            set { this.month = value; }
            get { return this.month; }
        }

        public int Year
        {
            set { this.year = value; }
            get { return this.year; }
        }

        public int PrintAccountNumber()
        {
            accountNumber = a;
            Console.WriteLine("Your Account No is= " + accountNumber + "\n");
            a++;
            return 0;
        }

        public void PrintDateOfBirth()
        {
            //Console.WriteLine("Your Date of Birth is=", Date,"-",Month,"-",Year);
            Console.Write("Your Date of Birth is=");
            Console.Write(date);
            Console.Write("-");
            Console.Write(month);
            Console.Write("-");
            Console.Write(year);
            Console.WriteLine();
        }




        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance: " + balance);
                Console.WriteLine("Deposit Amount: " + amount);
                balance = amount + balance;
                Console.WriteLine("Current Balance: " + balance + "\n");

            }
            else
            {
                Console.WriteLine("Can Not Deposit");
            }
        }



        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance:	" + balance);
                Console.WriteLine("Withdraw Amount:	" + amount);
                balance -= amount;
                Console.WriteLine("Current Balance:	" + balance);
            }
            else
            {
                Console.WriteLine("Can Not Withdraw");
            }
        }




        public void Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance:	" + this.balance);
                Console.WriteLine("Transfer Amount:	" + amount);
                this.balance = this.balance - amount;
                Console.WriteLine("Current Balance:	" + this.balance + "\n");
                receiver.Deposit(amount);

            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
        }

        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Name:{0}\nBalance:{1}", this.accountName, this.balance);
            this.address.GetAddress();
        }
    }
}
