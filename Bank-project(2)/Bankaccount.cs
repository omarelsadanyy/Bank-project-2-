using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_project_2_
{
    class Bankaccount
    {
		internal int accountid;
		internal double  balance;
		internal static int id_generate = 1;
		protected internal Client owner;
		public Bankaccount()
		{
			this.balance = 0 ;
			accountid = id_generate;
			id_generate++;

		}

		public virtual Client Owner
		{
			set
			{
				this.owner = value;
			}
			get
			{
				return owner;
			}
		}


		public Bankaccount( double balance)
		{
			this.balance = balance;
			accountid = id_generate;
			id_generate++;
		}

		public virtual double  Balance
		{
			get
			{
				return balance;
			}
			set
			{
				this.balance = value;
			}
		}


		public virtual int Accountid
		{
			get
			{
				return accountid;
			}
		}
		public virtual bool withdraw(double  amount)
		{
			if (amount > balance)
			{
				Console.WriteLine("amount is not valid");
				return false;
			}
			if (amount < 0)
			{
				Console.WriteLine("invalid amount");
				return false;
			}
			balance -= amount;
			return true;
		}
		public virtual bool diposite(double amount)
		{
			if (amount < 0)
			{
				Console.WriteLine("invalid amount");
				return false;
			}
			balance += amount;
			return true;
		}
		public virtual string view()
		{

			string data;
			data = owner.view() + Environment.NewLine + "accountid : " + accountid + Environment.NewLine + "balance : " + balance;
			//owner.view();
			//Console.WriteLine("accountid : " + accountid);
			//Console.WriteLine("balance : " + balance);
			return data;
		}
	}
}
