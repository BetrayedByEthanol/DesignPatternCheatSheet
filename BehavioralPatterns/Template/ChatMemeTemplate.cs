using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.BehavioralPatterns.Template
{
    public abstract class ChatMemeTemplate
    {
        public void postMeme()
        {
            Console.WriteLine("User: ");
            showImage();
            Console.WriteLine("Message Text");
        }

        protected abstract void showImage();

    }
}
