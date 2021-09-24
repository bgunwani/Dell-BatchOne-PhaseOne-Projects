/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    interface IManageAccount
    {
        void deposit();
        void withdraw();
        void balance();
    }
    interface IBankAccount
    {
        void deposit();
        void withdraw();
        void balance();
    }

    // Multiple Inheritance
    class SavingAccount: IManageAccount, IBankAccount
    {
        public void balance()
        {
            Console.WriteLine("Balance in Saving Account.");
        }

        public void closeAccount()
        {
            Console.WriteLine("Close Saving Account.");
        }

        public void deposit()
        {
            Console.WriteLine("Deposit in Saving Account.");
        }

        public void openAccount()
        {
            Console.WriteLine("Open Saving Account.");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account.");
        }
    }

    class InterfaceExample
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.openAccount();
            savingAccount.deposit();
            savingAccount.withdraw();
            savingAccount.balance();
            savingAccount.closeAccount();
        }
    }
}
*/