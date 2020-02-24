using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.FluentInterface
{
    public class FluentInterfaceExample
    {
        public void test()
        {
            ITransferableData dataTransfer = DataTransfer.connect("my server connection");


            dataTransfer.onData("my data")
                .upload("my collection")
                .toServer(dataTransfer.connectionString);
        }
    }
}
