using System;

namespace MyBankAccountApp
{
    class Transactions
    {
        public decimal Amount { get; }

        public DateTime Date { get; }

        public string Notes { get; }


        public Transactions (decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note; 
        }
    }
}