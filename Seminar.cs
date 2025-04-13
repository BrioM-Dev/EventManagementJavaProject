using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Seminar: Event
    {
        private String seminarSpeaker;
        private String type;
        public Seminar(String name, int id, int cap, String speaker): base(name, id, cap)
        {   
            this.seminarSpeaker = speaker;
        }
    public override String getType()
        {
            return "Seminar";
        }

    public override void displayEvent()
        {
            base.displayEvent();
            Console.WriteLine("Speaker: " + seminarSpeaker);
        }
    }
}
