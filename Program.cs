namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Event> events = new List<Event>();
            bool running = true;
            bool idExists;
            int cap;
            int id;
            string name;
            int choice;
            while (running)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Select the appropriate option below\n1: Add a Workshop\n2: Add a Seminar\n3: View all events\n4: Exit Menu");
                Console.Write("Enter choice (1-4): ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        do
                        {
                            Console.Write("Enter event ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            idExists = false;
                            foreach (Event e in events)
                            {
                                if (e.getEventID() == id)
                                {
                                    Console.WriteLine("ID already exists");
                                    idExists = true;
                                    break;
                                }
                            }
                        } while (idExists);

                        do
                        {
                            Console.Write("Enter event capacity: ");
                            cap = Convert.ToInt32(Console.ReadLine());
                            if (cap < 1)
                            {
                                Console.WriteLine("Capacity of event cannot be less than 1");
                            }
                        } while (cap < 1);

                        Console.Write("Enter workshop name: ");
                        name = Console.ReadLine();

                        Console.Write("Enter workshop topic: ");
                        string topic = Console.ReadLine();

                        Console.Write("Enter workshop company: ");
                        string company = Console.ReadLine();

                        Workshop workshop = new Workshop(name, id, cap, topic, company);
                        events.Add(workshop);
                        break;

                    case 2:
                        do
                        {
                            Console.Write("Enter event ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            idExists = false;
                            foreach (Event e in events)
                            {
                                if (e.getEventID() == id)
                                {
                                    Console.WriteLine("ID already exists");
                                    idExists = true;
                                    break;
                                }
                            }
                        } while (idExists);

                        do
                        {
                            Console.Write("Enter event capacity: ");
                            cap = Convert.ToInt32(Console.ReadLine());
                            if (cap < 1)
                            {
                                Console.WriteLine("Capacity of event cannot be less than 1");
                            }
                        } while (cap < 1);

                        Console.Write("Enter seminar name: ");
                        name = Console.ReadLine();

                        Console.Write("Enter seminar speaker: ");
                        string speaker = Console.ReadLine();

                        Seminar seminar = new Seminar(name, id, cap, speaker);
                        events.Add(seminar);
                        break;

                    case 3:
                        Console.WriteLine("All Events:");
                        foreach (Event e in events)
                        {
                            e.displayEvent();
                        }
                        break;

                    case 4:
                        running = false;
                        Console.WriteLine("Exiting menu... Thank you for using our services.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please enter a number between 1 and 4.");
                        break;
                }
            }
        
        }
    }
}
