using System;

namespace BackendLibrary
{
    public class Calender
    {
        private DateTime dt;
        private PriorityType pt;
        private string toDo;

        public Calender()
        {
            dt = DateTime.Now;
            pt = PriorityType.Important;
            toDo = string.Empty;
        }

        public Calender(DateTime dt, PriorityType pt, string toDo)
        {
            this.dt = dt;
            this.pt = pt;
            this.toDo = toDo;
        }

        public Calender(Calender calender)
        {
            dt = calender.dt;
            pt = calender.pt;
            toDo = calender.toDo;
        }
        
        
    }
}