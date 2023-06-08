using System;
namespace BankEncapsulation
{
	public class BankAccount
	{

		public BankAccount()
		{
		}

		private double balance = 0;
		public double depositAmount { get; set; }

		public double Deposit(double depositAmount)
		{
			balance = depositAmount;
			Console.WriteLine("Your money has been deposited.");
			return balance;
		}

		public double GetBalance()
		{
			Console.WriteLine($"{balance}");
			return balance;
		}


	}

	
}

