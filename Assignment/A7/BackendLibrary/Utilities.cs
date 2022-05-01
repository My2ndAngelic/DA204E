using System.Text;

namespace BackendLibrary
{
    public class Utilities
    {
        /// <summary>
        ///     Arrays handling
        /// </summary>
        public static class Arrays
        {
            /// <summary>
            ///     Java algorithm of the Arrays.DeepToString() method to convert a multidimensional array to a string.
            /// </summary>
            /// <param name="array"></param>
            /// <typeparam name="T"></typeparam>
            /// <returns></returns>
            public static string DeepToString<T>(T[,]? array)
            {
                if (array == null)
                    return "null";
                StringBuilder result = new StringBuilder(); // Java style
                result.Append('['); // Add the opening bracket
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    result.Append('['); // Add the opening bracket to the row
                    for (int j = 0; j < array.GetLength(1); j++)
                        result.Append($"{(array[i, j] == null ? "null" : array[i, j])}, "); // Add the value and a comma
                    result.Remove(result.Length - 2, 2)
                        .Append("], "); // Remove the last comma and space and add the closing bracket
                }

                result.Remove(result.Length - 2, 2)
                    .Append(']'); // Remove the last comma and space and add the closing bracket
                return result.ToString(); // Return the string
            }

            /// <summary>
            ///     Java algorithm of the Arrays.DeepToString() method to convert a jagged array to a string.
            /// </summary>
            /// <param name="array"></param>
            /// <typeparam name="T"></typeparam>
            /// <returns></returns>
            public static string DeepToString<T>(T[][]? array)
            {
                if (array == null)
                    return "null";
                StringBuilder result = new StringBuilder(); // Java style
                result.Append('['); // Add the opening bracket
                for (int i = 0; i < array.Length; i++)
                {
                    result.Append('['); // Add the opening bracket to the row
                    for (int j = 0; j < array[i].Length; j++)
                        result.Append($"{(array[i][j] == null ? "null" : array[i][j])}, "); // Add the value and a comma
                    result.Remove(result.Length - 2, 2)
                        .Append("], "); // Remove the last comma and space and add the closing bracket
                }

                result.Remove(result.Length - 2, 2)
                    .Append(']'); // Remove the last comma and space and add the closing bracket
                return result.ToString(); // Return the string
            }

            /// <summary>
            ///     Java algorithm of the Arrays.ToString() method to convert an array to string.
            /// </summary>
            /// <param name="array"></param>
            /// <typeparam name="T"></typeparam>
            /// <returns></returns>
            public static string ToString<T>(T[]? array)
            {
                if (array == null)
                    return "null";
                StringBuilder result = new StringBuilder(); // Java style
                result.Append('['); // Add the opening bracket
                for (int i = 0; i < array.Length; i++) result.Append($"{(array[i] == null ? "null" : array[i])}, ");
                result.Remove(result.Length - 2, 2)
                    .Append(']'); // Remove the last comma and space and add the closing bracket
                return result.ToString(); // Return the string
            }
        }
    }
}