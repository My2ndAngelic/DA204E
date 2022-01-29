using System.Linq;

namespace SuperCalculator
{
    internal class SavingCalc
    {
        private decimal deposit;
        private decimal fee;
        private decimal interest;
        private int year;

        public SavingCalc()
        {
            deposit = 0;
            year = 0;
            interest = 0;
            fee = 0;
        }

        /// <summary>
        ///     Get the amount paid
        /// </summary>
        /// <returns></returns>
        public decimal GetAmountPaid()
        {
            return deposit * 12 * year;
        }

        /// <summary>
        ///     Return the final balance in the account
        ///     Source: https://stackoverflow.com/questions/11290577/lambda-expression-conversion-for-a-loop-to-display-a-list
        /// </summary>
        /// <returns></returns>
        public decimal GetFinalBalance()
        {
            decimal balance = 0;
            Enumerable.Range(1, year * 12).ToList().ForEach(_ => balance += interest * balance + deposit);
            return balance;
        }

        public decimal GetDeposit()
        {
            return deposit;
        }

        public void SetDeposit(decimal deposit)
        {
            this.deposit = deposit;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public decimal GetInterest()
        {
            return interest;
        }

        public void SetInterest(decimal interest)
        {
            this.interest = interest;
        }

        public decimal GetFee()
        {
            return fee;
        }

        public void SetFee(decimal fee)
        {
            this.fee = fee;
        }
    }
}