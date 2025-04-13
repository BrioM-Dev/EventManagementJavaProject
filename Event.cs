using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Event
    {
        private String eventName;
        private int eventID;
        private int capacity;
        public Event(String name, int id, int cap)
        {
            this.eventName = name;
            this.eventID = id;
            this.capacity = cap;
        }


        public virtual String getType()
        {
            return "Event";
        }

        public int getEventID()
        {
            return eventID;
        }


        public virtual void displayEvent()
        {
            Console.WriteLine("Event details:");
            Console.WriteLine(getType());
            Console.WriteLine("Event ID: " + eventID);
            Console.WriteLine("Event name: " + eventName);
            Console.WriteLine("Event capacity: " + capacity);
        }
    }
}
