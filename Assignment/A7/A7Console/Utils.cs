using System.Text;

namespace BackendLibrary
{
    public class Utils
    {
        /// <summary>
        ///     Arrays handling
        /// </summary>
        public static class Arrays
        {
            /// <summary>
            ///     Java algorithm of the Arrays.ToString method to convert an array to string.
            /// </summary>
            /// <param name="a"></param>
            /// <typeparam name="T"></typeparam>
            /// <returns></returns>
            public static string ToString<T>(T[]? a)
            {
                if (a == null)
                    return "null";
                int iMax = a.Length - 1;
                if (iMax == -1)
                    return "[]";

                StringBuilder b = new StringBuilder();
                b.Append('[');
                for (int i = 0; ; i++) {
                    b.Append(a[i]);
                    if (i == iMax)
                        return b.Append(']').ToString();
                    b.Append(", ");
                }
            }
        }
    }
}