using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Chain
{
    public class PasswordHandler : ILoginHandler
    {
        public ILoginHandler nextHandler { get; set; }
        public string handleLogin(string ip, string email, SecureString password)
        {
            IntPtr intPtr = IntPtr.Zero;
            IntPtr intPtr1 = IntPtr.Zero;
            SecureString secretPassword = new NetworkCredential(email, "secretpassword").SecurePassword;

            intPtr = Marshal.SecureStringToBSTR(password);
            intPtr1 = Marshal.SecureStringToBSTR(secretPassword);

            if (Marshal.PtrToStringBSTR(intPtr).Equals(Marshal.PtrToStringBSTR(intPtr1))) return new UserDataHandler().handleLogin(ip, email, password); else return "Incorrect Password";
            

        }
    }
}
