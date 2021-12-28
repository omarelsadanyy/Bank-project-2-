using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_project_2_
{
    class SavingsBankaccount : Bankaccount
    {
		internal double minbalance;

		public SavingsBankaccount(double balance) : base(balance)
		{
			minbalance = 1000;
		}

		public virtual double Minbalance
		{
			get
			{
				return minbalance;
			}
			set
			{
				this.minbalance = value;
			}
		}


		public override bool withdraw(double amount)
		{
			if (balance - amount < minbalance)
			{
				Console.WriteLine("error, insufficent balance");
				return false;
			}
			return base.withdraw(amount);
		}

		public override bool diposite(double amount)
		{
			if (amount < 100)
			{
				Console.WriteLine("error amount less than  100");
				return false;
			}
			return base.diposite(amount);
		}

		public override string view()
		{
			string data;
			data = "savings bank account "+ Environment.NewLine + base.view() + Environment.NewLine + "minbalance : " + minbalance;
			
			return data;
		}
	}
}
