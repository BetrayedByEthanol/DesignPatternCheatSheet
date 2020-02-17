using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Builder
{
    public class NotificationBuilder
    {
        public Notification buildNotification(IEventBooking eventBooking)
        {
            if (typeof(IndividuellesEvent).Equals(eventBooking))
            {
                return buildIndividuellEvent(eventBooking);
            } else if (typeof(HostedEvent).Equals(eventBooking))
            {
                return buildHostEvent(eventBooking);
            } else
            {
                return buildVIPEvent(eventBooking);
            }

        }

        private Notification buildIndividuellEvent(IEventBooking eventBooking)
        {
            Notification notification = new Notification(eventBooking);
            notification.personalNotification.Add(new StaffNotification());
            notification.personalNotification.Add(new ClientNotification());
            notification.eventBooking = eventBooking;
            return notification;
        }

        private Notification buildHostEvent(IEventBooking eventBooking)
        {
            Notification notification = new Notification(eventBooking);
            notification.personalNotification.Add(new StaffNotification());
            notification.personalNotification.Add(new ClientNotification());
            notification.personalNotification.Add(new HostNotification());
            notification.eventBooking = eventBooking;
            return notification;
        }

        private Notification buildVIPEvent(IEventBooking eventBooking)
        {
            Notification notification = new Notification(eventBooking);
            notification.personalNotification.Add(new StaffNotification());
            notification.personalNotification.Add(new ClientNotification());
            notification.personalNotification.Add(new HostNotification());
            notification.personalNotification.Add(new ManagerNotification());
            notification.eventBooking = eventBooking;
            return notification;
        }

    }
}
