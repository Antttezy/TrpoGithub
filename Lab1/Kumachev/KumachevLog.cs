using Lab.Core;
using System;
using System.Collections.Generic;
using System.IO;

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
            string[] logArray = logs.ToArray();
            WriteConsole(logArray);

            if (!Directory.Exists("Logs"))
            {
                Directory.CreateDirectory("Logs");
            }

            using (StreamWriter writer = File.CreateText($"Logs\\{DateTime.Now : dd.MM.yyyy_HH.mm.ss.fff}.log"))
            {
                writer.Write(FormatLog(logArray));
            }

            logs.Clear();
            return this;
        }
    }
}
