namespace Task_4;

public class BankAccount
{
   private int accountId;
   private decimal balance;
   public string OwnerName;
   private bool  isFrozen;


   public BankAccount(int accountId, string OwnerName, decimal balance)
   {
    this.accountId=accountId;
    this.OwnerName=OwnerName;
    this.balance=balance;

   }



   public void Deposit(decimal amount)
   {
    if (isFrozen = true) balance = balance + amount;
   } 
   public void Withdraw(decimal amount)
   {
    if (isFrozen = true) balance = balance - amount;
   }
   public void FreezeAccount()
   {
    isFrozen = false;
   }
   public void UnfreezeAccount()
   {
    isFrozen = true;
   }
   public void Info()
   {
    System.Console.Write($"ID : {accountId}\nName : {OwnerName}\nBalance : {balance}\n");
    if (isFrozen = true) System.Console.WriteLine("Activ account");
    if (isFrozen = false) System.Console.WriteLine("Freeze account");

   }

}
