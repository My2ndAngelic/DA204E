using System;

namespace BackendLibrary
{
    public class Task
    {
        private DateTime date;
        private PriorityType priority;
        private string toDo;

        public Task()
        {
            date = DateTime.Now;
            priority = PriorityType.Very_important;
            toDo = "Untitled";
        }

        public Task(DateTime date, PriorityType priority, string toDo)
        {
            this.date = date;
            this.priority = priority;
            this.toDo = CheckToDo(toDo);
        }

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

        private static string CheckToDo(string inToDo)
        {
            return string.IsNullOrEmpty(inToDo) ? "Untitled" : inToDo;
        }

        public static string PriorityTypeToString(string priorityType)
        {
            return priorityType.Replace("_", " ");
        }

        public static string PriorityTypeToString(PriorityType priorityType)
        {
            return priorityType.ToString().Replace("_", " ");
        }

        public static PriorityType PriorityTypeFromString(string priorityType)
        {
            return (PriorityType) Enum.Parse(typeof(PriorityType), priorityType.Replace(" ", "_"));
        }

        public override string ToString()
        {
            return $@"{date} {PriorityTypeToString(priority)} {toDo}";
        }

        public string ToStringFile()
        {
            return
                $@"{(int) date.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds}|{priority}|{toDo}";
        }

        public static Task FromString(string data)
        {
            return FromStrings(data.Split('|'));
        }

        public static Task FromStrings(string[] data)
        {
            return new Task(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(Convert.ToInt32(data[0])),
                (PriorityType) Enum.Parse(typeof(PriorityType), data[1]),
                data[2]);
        }
    }
}