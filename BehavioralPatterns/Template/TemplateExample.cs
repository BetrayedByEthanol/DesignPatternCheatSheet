using DesignPatternCheatSheet.BehavioralPatterns.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Template
{
    public class TemplateExample
    {
        public void test()
        {
            ChatMemeTemplate ImageMeme = new ChatImageMeme();

            ImageMeme.postMeme();

            ChatMemeTemplate ASCIIMeme = new ChatASCIIMeme();

            ASCIIMeme.postMeme();
        }
    }
}
