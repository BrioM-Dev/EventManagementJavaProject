using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Workshop: Event
    {
        private String workshopTopic;
        private String workshopCompany;
        public Workshop(String name, int id, int cap, String topic, String company): base(name, id, cap)
        {        
            this.workshopTopic = topic;
            this.workshopCompany = company;
        }
        
    public override String getType()
        {
            return "Workshop";
        }

    public override void displayEvent()
        {
            base.displayEvent();
            Console.WriteLine("Topic: " + workshopTopic);
            Console.WriteLine("Company: " + workshopCompany);
        }
    }
}
