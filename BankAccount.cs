using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class BankAccount
    {

        private int _accountNumber;
        private double _balance;

        // string _accountNumber =  Guid.NewGuid().ToString();
        public int AccountNumber
        {
            get
            {
                return this._accountNumber;
            }
        }
        public double Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                if (value > 0)
                {
                    this._balance = value;
                }
            }
        }
        public BankAccount()
        {
            _accountNumber = new Random().Next(1000, 9999);
            Console.WriteLine($"Hesab yaradildi {_accountNumber} ");

        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this._balance += amount;
                Console.WriteLine($"Balansiniz pul geldi {amount}");
            }
            else
            {
                Console.WriteLine("Duzgun mebleg daxil edilmeyib");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= this._balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} mebleg pul cekildi, balansiniz {_balance}");
            }
            else
            {
                Console.WriteLine("Xeta bash verdi");
            }
        }

    }
}
