using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_project_2_
{
    class Client 
    {
		internal string name;
		internal string addres;
		internal string phone;
		internal Bankaccount account;
		public Client(string name, string addres, string phone)
		{
			this.name = name;
			this.addres = addres;
			this.phone = phone;
		}

		public virtual Bankaccount Account
		{
			set
			{
				this.account = value;
			}
			get
			{
				return account;
			}
		}

		public virtual string view()
		{
		string data;
		data = "name : " + name + Environment.NewLine + "phone : " + phone + Environment.NewLine + "address : " + addres;
		
		return data;
		}
	}
	//hhh
}
