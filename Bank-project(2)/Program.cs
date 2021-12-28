using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project_2_
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //addtestdata();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //static void addtestdata()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Client c = new Client("client" + i, "giza", "12345");
        //        Bankaccount account = new Bankaccount(i * 1000);
        //        account.Owner = c;
        //        c.Account = account;

        //        //account.setOwner(c);
        //        //account.Owner(c);
        //        // c.setAccount(account);
        //        List.accounts.Add(account);
        //        List.allclients.Add(c);
        //    }
        //}
    }
}
