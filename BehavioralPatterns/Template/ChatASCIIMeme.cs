using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Template
{
    public class ChatASCIIMeme : ChatMemeTemplate
    {
        protected override void showImage()
        {
            Console.WriteLine("This is an ASCII image");
        }
    }
}
