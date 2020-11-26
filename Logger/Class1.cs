using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    class Logger
    {
        private Logger()
        { }
        private static Logger instance;
        private static List<string> LogMessages = new List<string>();
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public string NewMessage(string MessageLevel, Exception ex)
        {
            return $"{MessageLevel}, Action failed by reason: {ex.StackTrace}";
        }

        public string NewMessage(string MessageLevel, string Message)
        {
            return $"{MessageLevel}, Message: {Message}";
        }
    }
}
