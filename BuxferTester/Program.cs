using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuxferLib;
using BuxferLib.BuxferObjects;

namespace BuxferTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Buxfer buxfer = new Buxfer("test", "test");

            foreach (Message m in buxfer.Messages)
            {
                Console.WriteLine(m.Date.ToString("yyyy/MM/dd - HH:mm:ss") + " - " +  m.Text);
            }

            List<Account> accounts = buxfer.GetAllAccounts();
            if (accounts.Count > 0 )
                buxfer.GetTransactions(accounts[0].Id);

#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
