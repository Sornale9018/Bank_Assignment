using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class CheckingAc : Account
    {
        public CheckingAc(Address address) : base(address)
        {

        }

        public override void Withdraw(double amount)
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

    }
}
