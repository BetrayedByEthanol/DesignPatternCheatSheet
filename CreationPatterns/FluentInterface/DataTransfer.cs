using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.FluentInterface
{
    public class DataTransfer : IReadData, IWriteData, ITransferAction, ITransferableData
    {
        public string connectionString { get; set; }
        public string localPath { get; set; }
        public string stringifiedData { get; set; }

        private DataTransfer(string connection)
        {
            this.connectionString = connection;
        }

        public static ITransferableData connect(string connectionString)
        {
            return new DataTransfer(connectionString);
        }
        public ITransferAction onData(string data)
        {
            this.stringifiedData = data;
            return this;
        }
        public IReadData download(string path)
        {
            localPath = path;
            return this;
        }
        public IWriteData upload(string path)
        {
            localPath = path;
            return this;
        }
        public void toFile(string data)
        {
            // save data locally
        }
        public void toServer(string data)
        {
            // prepare data to server
        }
        public string fromFile()
        {
            // get data from file
            return "";
        }
        public string fromServer()
        {
            //get data from server
            return "";
        }
    }
}
