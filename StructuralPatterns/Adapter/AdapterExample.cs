using DesignPatternCheatSheet.StructuralPatterns.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Adapter
{
    public class AdapterExample
    {
        public void test()
        {

            Request request = new RequestAdapter();

            request.sendRequest("file url");
        }
    }
}
