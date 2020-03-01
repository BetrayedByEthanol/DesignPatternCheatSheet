using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Chain
{
    public interface ILoginHandler
    {
        ILoginHandler nextHandler {get;}
        string handleLogin(string ip, string email, SecureString password);
    }
}
