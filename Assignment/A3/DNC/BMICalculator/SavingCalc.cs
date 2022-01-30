using System;
using System.Linq;

namespace SuperCalculator
{
    public class SavingCalc
    {
        private decimal deposit;
        private decimal fee;
        private decimal interest;
        private int period;

        /// <summary>
        ///     Default constructor, 0 everything
        /// </summary>
        public SavingCalc()
        {
            deposit = 0;
            period = 0;
            interest = 0;
            fee = 0;
        }

        /// <summary>
        ///     Constructor for testing purpose, check if everything >= 0, otherwise default to 0
        /// </summary>
        /// <param name="deposit">Monthly deposit</param>
        /// <param name="fee">Monthly fee</param>
        /// <param name="interest">Annually interest</param>
        /// <param name="period">Total number of period</param>
        public SavingCalc(decimal deposit, decimal fee, decimal interest, int period)
        {
            this.deposit = deposit >= 0 ? deposit : 0;
            this.fee = fee >= 0 ? fee : 0;
            this.interest = interest >= 0 ? interest : 0;
            this.period = period >= 0 ? period : 0;
        }

        /// <summary>
        ///     Get the amount paid
        /// </summary>
        /// <returns>Total amount paid in decimal</returns>
        public decimal GetAmountPaid()
        {
            return deposit * period;
        }

        /// <summary>
        ///     Return the final balance in the account
        ///     Source: https://stackoverflow.com/questions/11290577/lambda-expression-conversion-for-a-loop-to-display-a-list
        /// </summary>
        /// <returns>Final balance in decimal</returns>
        public decimal GetFinalBalance()
        {
            decimal balance = 0;
            for (int i = 1; i <= period; i++)
            {
                decimal interestEarned = interest * balance;
                balance += interestEarned + deposit;
            }
            return balance;
            // return deposit * (decimal) ((Math.Pow((double) (interest + 1), period * 12) - 1) / (double) interest);
            // // This will throw exception as division by 0 is not a valid operation
            // // Probably an if would solve it 
        }

        /// <summary>
        ///     Get the amount earned over the total period
        /// </summary>
        /// <returns>Amount earned in decimal</returns>
        public decimal GetAmountEarned()
        {
            decimal balance = 0;
            for (int i = 1; i <= period; i++)
            {
                decimal interestEarned = interest * balance;
                balance += interestEarned;
            }
            return balance;
        }

        public decimal GetTotalFee()
        {
            decimal balance = 0;
            for (int i = 1; i <= period; i++)
            {
                decimal interestEarned = fee * deposit;
                balance += interestEarned;
            }
            return balance;
        }

        /// <summary>
        ///     Return monthly deposit
        /// </summary>
        /// <returns>Monthly deposit in decimal</returns>
        public decimal GetDeposit()
        {
            return deposit;
        }

        public void SetDeposit(decimal deposit)
        {
            this.deposit = deposit >= 0 ? deposit : 0;
        }

        public int GetPeriod()
        {
            return period;
        }

        public void SetPeriod(int period)
        {
            this.period = period >= 0 ? period : 0;
        }

        public decimal GetInterest()
        {
            return interest;
        }

        public void SetInterest(decimal interest)
        {
            this.interest = interest >= 0 ? interest : 0;
        }

        public decimal GetFee()
        {
            return fee;
        }

        public void SetFee(decimal fee)
        {
            this.fee = fee >= 0 ? fee : 0;
        }
    }
}