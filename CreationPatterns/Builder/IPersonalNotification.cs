using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Builder
{
    public interface IPersonalNotification
    {
        public abstract void sendNotification(IEventBooking eventBooking);
    }
}
