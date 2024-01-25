using Task_4;


BankAccount account = new BankAccount(10001, "Jhon Doe", 5000.00m);
account.Info();

account.Deposit(2001.00m);
account.Withdraw(100.00m);
account.Info();
account.UnfreezeAccount();
account.Deposit(2001.00m);
account.Withdraw(100.00m);
account.Info();  