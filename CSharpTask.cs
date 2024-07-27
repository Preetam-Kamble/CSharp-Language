using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Event(int eventId, string title, string description, DateTime startTime, DateTime endTime)
        {
            EventId = eventId;
            Title = title;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
        }
    }

    public class Scheduler
    {
        private List<Event> events;
        public Scheduler()
        {
            events = new List<Event>();
        }

        public bool AddEvent(Event newEvent)
        {
            if (CheckOverLap(newEvent.StartTime, newEvent.EndTime))
            {
                Console.WriteLine("Event not added because event overlaps with an existing event");
                return false;
            }

            events.Add(newEvent);
            Console.WriteLine("Event added successfully");
            return true;
        }

        public bool RemoveEvent(int eventId) // remove event besed on EventId
        {
            var eventToRemove = events.FirstOrDefault(e => e.EventId == eventId); // if the EventId matches with given Id then given id event will get remove
            if (eventToRemove != null)
            {
                events.Remove(eventToRemove);
                Console.WriteLine("Event removed successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Event not found");
                return false;
            }
        }

        public bool UpdateEvent(int eventId, string title, string description, DateTime startTime, DateTime endTime)
        {
            var eventToUpdate = events.FirstOrDefault(e => e.EventId == eventId);
            if (eventToUpdate != null)
            {
                eventToUpdate.Title = title;
                eventToUpdate.Description = description;
                eventToUpdate.StartTime = startTime;
                eventToUpdate.EndTime = endTime;
                Console.WriteLine("Event updated successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Event not found");
                return false;
            }
        }

        public List<Event> ListAllEvents() // In this method, we get events whatever details we have added inside AddEvent()
        {
            return events.ToList();
        }

        public List<Event> ListEvents(DateTime date)
        {
            return events.Where(e => e.StartTime.Date == date.Date).ToList(); // applied a condition on specific day
        }


        private bool CheckOverLap(DateTime newStartTime, DateTime newEndTime, int excludeEventId = -1)
        {
            return events.Any(e => e.EventId != excludeEventId && (newStartTime < e.EndTime && newEndTime > e.StartTime));
        }
    }

    public class EventMain
    {
        static void Main(string[] args)
        {
            Scheduler scheduler = new Scheduler();
            Console.WriteLine("These below events are not overlapping with each other:");
            scheduler.AddEvent(new Event(1, "Travel1", "Travel to Pune", new DateTime(2024,7,25,10,0,0), new DateTime(2024,7,25,11,0,0)));
            scheduler.AddEvent(new Event(2, "Travel2", "Travel to Mumbai", new DateTime(2024,7,28,10,0,0), new DateTime(2024,7,28,11,0,0)));
            scheduler.AddEvent(new Event(3, "Travel3", "Travel to Lucknow", new DateTime(2024,7,29,10,0,0), new DateTime(2024,7,29,11,0,0)));
            scheduler.AddEvent(new Event(4, "Travel4", "Travel to Punjab", new DateTime(2024,7, 26, 12, 0, 0), new DateTime(2024,7,26,13,0,0)));
            scheduler.AddEvent(new Event(5, "Travel5", "Travel to Bangalore", new DateTime(2024,7, 27, 14, 0, 0), new DateTime(2024,7,27,15,0,0)));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Overlap events will display below:");
            scheduler.AddEvent(new Event(6, "Travel4", "Travel to Hyderabad", new DateTime(2024,7,27,14,0,0), new DateTime(2024,7,27,15,0,0))); //overlaps with eventId 5
            scheduler.AddEvent(new Event(7, "Travel5", "Travel to Delhi", new DateTime(2024,7,26,12,0,0), new DateTime(2024,7,26,13,0,0))); //overlaps with eventId 4
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Output of ListAllEvents() below:");
            var events = scheduler.ListAllEvents();
            foreach(var e in events)
            {
                Console.WriteLine($"EventID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Removed events will display below:");
            scheduler.RemoveEvent(1);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Remaining events will display below after removing particular event:");
            var events1 = scheduler.ListAllEvents();
            foreach(var e in events1) // Event 1 removed, and remaining records will display here
            {
                Console.WriteLine($"EventID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Remove event is null, display below");
            scheduler.RemoveEvent(6);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Updated events will display below;");
            scheduler.UpdateEvent(2, "Travel2", "Travel to Noida", new DateTime(2024,8,1,12,30,45), new DateTime(2024,8,1,13,40,0));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Update event is null, display below:");
            scheduler.UpdateEvent(10, "Travel2", "Travel to Noida", new DateTime(2024,8,1,12,30,45), new DateTime(2024,8,1,13,40,0));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Specific day condition display below:");
            var events2 = scheduler.ListEvents(new DateTime(2024,7,29)); //Matched dates will display
            foreach(var e in events2)
            {
                Console.WriteLine($"EventID: {e.EventId}, Title: {e.Title}, Description: {e.Description}, StartTime: {e.StartTime}, EndTime: {e.EndTime}");
            }

            Console.ReadLine();

        }
    }
}
