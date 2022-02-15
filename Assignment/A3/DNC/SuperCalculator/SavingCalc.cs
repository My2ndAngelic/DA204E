using System;

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
            this.deposit = deposit;
            this.fee = fee;
            this.interest = interest;
            this.period = period;
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
        ///     Get the amount earned over the total period
        /// </summary>
        /// <returns>Amount earned in decimal</returns>
        public decimal GetAmountEarned()
        {
            return GetFinalBalance() - GetAmountPaid() - GetTotalFee();
        }

        /// <summary>
        ///     Return the final balance in the account
        /// </summary>
        /// <returns>Final balance in decimal</returns>
        public decimal GetFinalBalance()
        {
            // if (interest == 0 && fee == 0) return deposit * period; // In case of simple interest
            //
            // decimal rate = (1 + interest)*(1-fee);
            // return deposit * (decimal) (1 - Math.Pow((double) rate, period) ) / (1 - rate); // Compound interest formula
            
            decimal balance = 0;
            for (int i = 0; i < period; i++)
            {
                balance += (interest - fee) * balance + deposit;
            }
            
            return balance;
        }

        /// <summary>
        ///     Return total fee
        ///     [1]: https://math.stackexchange.com/questions/544831/compound-interest-with-monthly-fees
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalFee()
        {
            // I do not know how to calculate the fee.
            // The formula was provided from the discussion
            // This would violate the DRY principle but if it works, it works
            decimal totalFee = 0;
            decimal balance = 0;
            for (int i = 0; i < period; i++)
            {
                balance += (interest - fee) * balance + deposit;
                totalFee += balance * fee;
            }
            
            return totalFee;
            
            // decimal rate = (1+fee);
            // return deposit * (decimal) (1 - Math.Pow((double) rate, period) ) / (1 - rate) - GetAmountPaid(); // Compound interest formula
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
            this.period = period;
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