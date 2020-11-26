using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Logger
{
    public class Actions
    {
        public void Info()
        {
            Console.WriteLine("Info, Start method:" + nameof(Info));
        }
        public void Warning()
        {
            Console.WriteLine("Warning, Skipped logic in method:" + nameof(Warning));
        }
        public void Error()
        {
            throw new Exception("I broke a toilet");
        }
    }
}