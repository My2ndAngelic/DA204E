using System;
using System.Collections.Generic;
using System.Linq;

namespace BackendLibrary
{
    public class MiscellaneousHandlers
    {
        /// <summary>
        /// Pad 0 to the left side depending on the maximum.
        /// Example: 01 - 99, 001 - 999, 0001 - 9999.
        /// </summary>
        /// <param name="i">Number needed to be padded</param>
        /// <param name="max">Maximum range</param>
        /// <returns>String of the padded number</returns>
        public static string PadLeft(int i, int max)
        {
            int temp = i;
            if (i == 0) i = 1;
            
            int n = 0; // Maximum range
            while (Math.Pow(10, n) <= max) n++;

            int k = n; // How many needed to be padded
            while (Math.Pow(10, k) > i) k--;

            return $"{string.Join("", Enumerable.Repeat("0", n - k - 1).ToList())}{(temp > 0 ? i : temp)}";
        }

        /// <summary>
        /// Return the formatted customer info in string array
        /// </summary>
        /// <param name="customers">List of customers</param>
        /// <returns>List of customer infos in string array</returns>
        public static string[] CustomerProcessing(IEnumerable<Customer> customers)
        {
            IEnumerable<Customer> enumerable = customers.ToList();
            int i = 1;

            return enumerable.Select(t =>
                    $@"{PadLeft(i++, enumerable.Count()),10} {t.Contact.LName,-20} {t.Contact.FName,-20} {t.Contact.Phone.OfficeNumber,-20} {t.Contact.Email.Work,-20}")
                .ToArray();
        }
    }
}