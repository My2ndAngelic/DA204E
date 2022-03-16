using System;
using System.Collections.Generic;
using System.Linq;

namespace BackendLibrary
{
    public class MiscellaneousHandlers
    {
        public static string PadLeft(int i, long max)
        {
            int temp = i;
            if (i == 0) i = 1;
            int n = 0;
            while (Math.Pow(10, n) <= max) n++;

            int k = n;
            while (Math.Pow(10, k) > i) k--;

            return $"{string.Join("", Enumerable.Repeat("0", n - k - 1).ToList())}{(temp > 0 ? i : temp)}";
        }

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