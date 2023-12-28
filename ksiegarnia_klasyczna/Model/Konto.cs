using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksiegarnia_klasyczna.Model
{
    internal class Konto
    {
        // konto jako stan konta księgarnii
        // pola Konto
        // konstruktor książki
        // podstawowa logika 

        private List<Transakcja> AllTransactions = new List<Transakcja>();

        private static UInt32 accountNumberSeed = 23232323;

        private decimal Amount;

        public decimal Balance
        {
            get
            {
                decimal transactionSum = 0;
                foreach (var transaction in AllTransactions)
                {
                    transactionSum += transaction.Amount;
                }
                return transactionSum + Balance;
            }
            set { Balance = value; }
        }

        public Konto(decimal balance, decimal amount)
        {
            this.Balance = balance;
            this.Amount = amount;
        }

    }
}
