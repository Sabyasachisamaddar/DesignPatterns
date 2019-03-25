using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatternsGuide.SingletonPattern
{
    class Logger
    {
        private readonly FileStream logStream;
        private StreamWriter streamWriter;
        private readonly static object _handle = new object();
        private static Logger _instance;

        protected Logger()
        {
            logStream = File.Open("logfile.log", FileMode.Create);
            streamWriter = new StreamWriter(logStream);
        }

        public void Log(string message)
        {
            streamWriter.Write(message);
            streamWriter.Write(Environment.NewLine);
        }

        ~Logger()
        {
            try
            {
                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        public static Logger Instance
        {
            get
            {
                lock (_handle)
                {
                    if (_instance == null)
                        _instance = new Logger();
                }
                return _instance;
            }
        }
    }
}
