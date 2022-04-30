using System;

namespace BackendLibrary
{
    public class Task
    {
        private DateTime date;
        private PriorityType priority;
        private string toDo;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public Task()
        {
            date = DateTime.Now;
            priority = PriorityType.Very_important;
            toDo = "Untitled";
        }

        /// <summary>
        ///     Constructor with all field exposed
        /// </summary>
        /// <param name="date"></param>
        /// <param name="priority"></param>
        /// <param name="toDo"></param>
        public Task(DateTime date, PriorityType priority, string toDo)
        {
            this.date = date;
            this.priority = priority;
            this.toDo = CheckToDo(toDo);
        }

        /// <summary>
        ///     Constructor with previous data
        /// </summary>
        /// <param name="task"></param>
        public Task(Task task)
        {
            date = task.date;
            priority = task.priority;
            toDo = task.toDo;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public string ToDo
        {
            get { return toDo; }
            set { toDo = CheckToDo(value); }
        }

        /// <summary>
        ///     Check if ToDo is empty and if it is, set it to Untitled
        /// </summary>
        /// <param name="inToDo">ToDo string</param>
        /// <returns>"Untitled" if empty or null</returns>
        private static string CheckToDo(string inToDo)
        {
            return string.IsNullOrEmpty(inToDo) ? "Untitled" : inToDo;
        }

        /// <summary>
        ///     Remove _ in the priority string
        /// </summary>
        /// <param name="priorityType">Priority type (String)</param>
        /// <returns>Priority type without _</returns>
        public static string PriorityTypeToString(string priorityType)
        {
            return priorityType.Replace("_", " ");
        }

        /// <summary>
        ///     Remove _ in the priority string
        /// </summary>
        /// <param name="priorityType">Priority type (Enum)</param>
        /// <returns>Priority type without _</returns>
        public static string PriorityTypeToString(PriorityType priorityType)
        {
            return PriorityTypeToString(priorityType.ToString());
        }

        /// <summary>
        ///     Convert priority type from string to enum
        /// </summary>
        /// <param name="priorityType">Priority type (String)</param>
        /// <returns>Priority type (Enum)</returns>
        public static PriorityType PriorityTypeFromString(string priorityType)
        {
            return (PriorityType) Enum.Parse(typeof(PriorityType), priorityType.Replace(" ", "_"));
        }

        /// <summary>
        ///     Default toString method
        /// </summary>
        /// <returns>String of all field split by space</returns>
        public override string ToString()
        {
            return $@"{date} {PriorityTypeToString(priority)} {toDo}";
        }

        /// <summary>
        ///     ToString method for the display
        /// </summary>
        /// <returns>String result to display on screen</returns>
        public string ToStringDisplay()
        {
            return $@"{date,-20} {PriorityTypeToString(priority),-15} {toDo,-50}";
        }

        /// <summary>
        ///     ToString method for the file
        ///     Format: Date (Epoch time)|PriorityType|ToDo
        /// </summary>
        /// <returns>String result to write in file</returns>
        public string ToStringFile()
        {
            return
                $@"{(int) date.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds}|{priority}|{toDo}";
        }

        /// <summary>
        ///     Split from string (unsplit) to Task (from file) by calling FromStrings
        /// </summary>
        /// <param name="data">Raw unsplit string</param>
        /// <returns>Task object</returns>
        public static Task FromString(string data)
        {
            return FromStrings(data.Split('|'));
        }

        /// <summary>
        ///     Convert from string (split into array) to Task (from file)
        /// </summary>
        /// <param name="data">Array of split strings</param>
        /// <returns>Task object</returns>
        public static Task FromStrings(string[] data)
        {
            return new Task(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(Convert.ToInt32(data[0])),
                (PriorityType) Enum.Parse(typeof(PriorityType), data[1]),
                data[2]);
        }
    }
}
