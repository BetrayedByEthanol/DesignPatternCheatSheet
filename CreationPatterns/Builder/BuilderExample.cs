using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Builder
{
    public class BuilderExample
    {
        public void test()
        {
            IEventBooking individuellesEvent = new IndividuellesEvent();
            Notification notification = new NotificationBuilder().buildNotification(individuellesEvent);
            notification.notify();
        }

    }
}
