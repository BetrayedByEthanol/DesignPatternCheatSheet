using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Chain
{
    public class LoginTokenHandler : ILoginHandler
    {
        public ILoginHandler nextHandler { get; set; }
        public string userdata { get; set; }

        public string handleLogin(string ip, string email, SecureString password)
        {
            return "Granting " + userdata + " rights here is your login token : asiodhasoidfhas0poidaspodnaspdasd";
        }
    }
}
