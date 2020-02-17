using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Builder
{
    public class ClientNotification : IPersonalNotification
    {
        public void sendNotification(IEventBooking eventBooking)
        {
            throw new NotImplementedException();
        }
    }
}
