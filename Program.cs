using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            ////person.setName("Kenan");
            ////person.setAge(15);
            ////Console.WriteLine(person.getName() + " Aliyev" + person.getAge() + " yashinda");
            //person.Name = "Kenan";
            //Console.WriteLine(person.Name);
            BankAccount account = new BankAccount();

            account.Deposit(100);
            account.Withdraw(50);
            account.Withdraw(200);


            Console.WriteLine(account.Balance);
            Console.WriteLine(account.AccountNumber);

        }
    }
}
