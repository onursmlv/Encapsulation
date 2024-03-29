Task: Create a Bank Account Class with Encapsulation
Create a C# console application that models a simple bank account using encapsulation. The BankAccount class should have the following properties and methods:

Class BankAccount

Private fields:

accountNumber (string): The account number (should be initialized randomly during object creation).
balance (double): The current balance of the account.

Public properties:

AccountNumber (string): A read-only property to access the account number.
Balance (double): A property to access and modify the account balance. Ensure that the balance cannot be set to a negative value.

Public methods:

Deposit(double amount): Adds the specified amount to the account balance.
Withdraw(double amount): Subtracts the specified amount from the account balance, if the balance is sufficient
