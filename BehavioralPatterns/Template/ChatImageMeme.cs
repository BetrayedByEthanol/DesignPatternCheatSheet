using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Template
{
    public class ChatImageMeme : ChatMemeTemplate
    {
        protected override void showImage()
        {
            Console.WriteLine("This is jpeg image");
        }
    }
}
