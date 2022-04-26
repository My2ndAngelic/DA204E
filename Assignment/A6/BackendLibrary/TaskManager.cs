﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BackendLibrary
{
    /// <summary>
    ///     Auto-generated code by IList implementation
    /// </summary>
    public class TaskManager : IList<Task>
    {
        private IList<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public IList<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }

        public IEnumerator<Task> GetEnumerator()
        {
            return tasks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) tasks).GetEnumerator();
        }

        public void Add(Task item)
        {
            if (item != null)
                tasks.Add(item);
        }
        
        public void Add(List<Task> toList)
        {
            toList.ForEach(tasks.Add);
        }

        public void Clear()
        {
            tasks.Clear();
        }

        public bool Contains(Task item)
        {
            return tasks.Contains(item);
        }

        public void CopyTo(Task[] array, int arrayIndex)
        {
            tasks.CopyTo(array, arrayIndex);
        }

        public bool Remove(Task item)
        {
            return tasks.Remove(item);
        }

        public int Count
        {
            get { return Tasks.Count; }
        }

        public bool IsReadOnly
        {
            get { return Tasks.IsReadOnly; }
        }

        public int IndexOf(Task item)
        {
            return Tasks.IndexOf(item);
        }

        public void Insert(int index, Task item)
        {
            Tasks.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            Tasks.RemoveAt(index);
        }

        public Task this[int index]
        {
            get { return Tasks[index]; }
            set { Tasks[index] = value; }
        }

        /// <summary>
        ///     Return list of calendar info for displaying
        /// </summary>
        /// <returns>List of calendar info for displaying</returns>
        public IEnumerable<string> ToStrings()
        {
            return tasks.Select(c => c.ToStringDisplay()).ToList();
        }

        /// <summary>
        ///     Return list of calendar info for file writing
        /// </summary>
        /// <returns>List of calendar info for file writing</returns>
        public IEnumerable<string> ToStringsFile()
        {
            return tasks.Select(c => c.ToStringFile()).ToList();
        }
    }
}