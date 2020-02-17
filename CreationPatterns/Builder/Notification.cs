using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Builder
{
    public class Notification
    {
        public List<IPersonalNotification> personalNotification { get; set; }
        public IEventBooking eventBooking { get; set; }

        public Notification(IEventBooking eventBooking)
        {
            this.eventBooking = eventBooking;
            personalNotification = new List<IPersonalNotification>();
        }

        public void notify()
        {
            foreach(IPersonalNotification personalNotification in personalNotification)
            {
                personalNotification.sendNotification(eventBooking);
            }
        }
    }
}
