using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SingleTonThreadSafeUsingLock
{
    public class MemoryLogger
    {
        private int _InfoCount;
        private int _WarningCount;
        private int _ErrorCount;
        private List<LogMessage> _logs = new List<LogMessage>();
        private static readonly Object _lock = new object();

        private static MemoryLogger _instance=null;
        public IReadOnlyCollection<LogMessage> Logs => _logs;
        private void Log(string message, LogType logType)
        => _logs.Add(new LogMessage
        {
            Message = message,
            LogType = logType,
            CreatedAt = DateTime.Now
        });

        private MemoryLogger()
        {

        }

        public static MemoryLogger GetLogger
        {
            get
            {//T2 wait when T1 Finsih
                lock (_lock)
                    if (_instance == null)
                    {
                        //T1
                        _instance = new MemoryLogger();
                    }

                return _instance;
            }
        }

        public void LogInfo(string message)
        {
            ++_InfoCount;
            Log(message, LogType.INFO);
        }
        public void LogError(string message)
        {
            ++_ErrorCount;
            Log(message, LogType.ERROR);
        }
        public void LogWarning(string message)
        {
            ++_WarningCount;
            Log(message, LogType.WARNING);
        }
               public void ShowLog()
           {
            _logs.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine($"Info ({_InfoCount} ,Warning {_WarningCount} , Error {_ErrorCount}");
        }
    }
}
