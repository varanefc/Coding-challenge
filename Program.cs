using System;
public class Account
{
   public int accountNo { get; set; }
   public  string accountName { get; set; } 
   public double balance { get; set; } 

   

   public void Deposit(double amount)
   {
      balance += amount;
   }
   public void DisplayBalance()
   {
      Console.WriteLine("Balance: " + balance);
   }
}

public class CreateAccount
{
    public static void Main(string[] args)
    {
   Account farhanAccount = new Account(); //creating an object
   Account ikranAccount = new Account();
   farhanAccount.accountNo = 667331;      // assigning account number
   ikranAccount.accountNo = 667332;
   farhanAccount.accountName = "Farhan";  //assigning names
   ikranAccount.accountName = "Ikran";
   farhanAccount.balance = 500;           //assigning balance
   ikranAccount.balance = 1000;

   
   //Printing account details
  
      Console.WriteLine("A/C NO: " + farhanAccount.accountNo + " A/C NAME: " + farhanAccount.accountName + " Balance: " + farhanAccount.balance);
       Console.WriteLine("A/C NO: " + ikranAccount.accountNo + " A/C NAME: " + ikranAccount.accountName + " Balance: " + ikranAccount.balance);
   }

}