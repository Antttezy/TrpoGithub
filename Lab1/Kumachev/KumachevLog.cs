using Lab1.Core;
using System.Collections.Generic;

namespace Lab1.Kumachev
{
    public class KumachevLog : LogAbstract, LogInterface
    {
        private static KumachevLog instance;

        private readonly List<string> logs = new List<string>();

        private KumachevLog()
        {

        }

        public static KumachevLog I()
        {
            if (instance == null)
            {
                instance = new KumachevLog();
            }

            return instance;
        }

        public LogInterface Log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface Write()
        {
            WriteConsole(logs.ToArray());
            return this;
        }
    }
}
