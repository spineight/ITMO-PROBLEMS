using System;
using System.Collections.Generic;
using System.Linq;
using Banks.Banks.Limits;

namespace Banks.Accounts
{
    public class DepositAccount : DebitAccount
    {
        public DepositAccount(int money, DateTime date, DateTime duration)
            : base(money, date)
        {
            Duration = duration;
        }

        private DateTime Duration { get; }

        public override Account Calculate(Limit limit, DateTime dateTime)
        {
            double FindPercent()
            {
                int maxBalance = 0;
                SortedDictionary<int, double> depositPercent = limit.DepositPercent;
                foreach (int balance in depositPercent.Keys
                    .Where(balance => balance <= Balance))
                {
                    maxBalance = balance;
                }

                return limit.DepositPercent[maxBalance];
            }

            dateTime = (Duration.CompareTo(dateTime) > 0) ? dateTime : Duration;

            void AddToPayment(int days) =>
                Payment += Balance * (FindPercent() / 100 / 365) * days;

            return CalculateWithMethod(dateTime, AddToPayment);
        }

        public override bool ApprovedWithDraw(Limit limit)
        {
            return false;
        }

        public override bool ApprovedTransfer(Account toAccount, double amount, Limit limit)
        {
            return false;
        }

        public override void Print()
        {
            Console.Write("\t A: deposit");
        }
    }
}