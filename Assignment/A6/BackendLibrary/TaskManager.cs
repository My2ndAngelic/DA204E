using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BackendLibrary
{
    /// <summary>
    /// Auto-generated code by IList implementation
    /// </summary>
    public class TaskManager : IList<Task>
    {
        private IList<Task> calendars;

        public TaskManager()
        {
            calendars = new List<Task>();
        }
        
        public IEnumerator<Task> GetEnumerator()
        {
            return calendars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) calendars).GetEnumerator();
        }

        public void Add(Task item)
        {
            if (item != null) 
               calendars.Add(item);
        }

        public void Clear()
        {
            calendars.Clear();
        }

        public bool Contains(Task item)
        {
            return calendars.Contains(item);
        }

        public void CopyTo(Task[] array, int arrayIndex)
        {
            calendars.CopyTo(array, arrayIndex);
        }

        public bool Remove(Task item)
        {
            return calendars.Remove(item);
        }

        public int Count
        {
            get { return Calendars.Count; }
        }

        public bool IsReadOnly
        {
            get { return Calendars.IsReadOnly; }
        }

        public IList<Task> Calendars
        {
            get { return calendars; }
            set { calendars = value; }
        }

        public int IndexOf(Task item)
        {
            return Calendars.IndexOf(item);
        }

        public void Insert(int index, Task item)
        {
            Calendars.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            Calendars.RemoveAt(index);
        }

        public Task this[int index]
        {
            get { return Calendars[index]; }
            set { Calendars[index] = value; }
        }

        /// <summary>
        /// Return list of calendar info
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> ToStrings()
        {
            return calendars.Select(c => c.ToString()).ToList();
        }
        
        public IEnumerable<string> ToStringsFile()
        {
            return calendars.Select(c => c.ToStringFile()).ToList();
        }
    }
}