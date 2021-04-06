using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainingStateChartDiagrams
{
    public enum ProcessState
    {
        Ready,
        Active,
        Waiting,
        Completed
    }

    public class OperatingSystemProcess
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public int ProcessMemory { get; set; }
        public ProcessState ProcessState { get; set; }
    }
}
