using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Builder
{
    public class HostNotification : IPersonalNotification
    {
        public  void sendNotification(IEventBooking eventBooking)
        {
            throw new NotImplementedException();
        }
    }
}
