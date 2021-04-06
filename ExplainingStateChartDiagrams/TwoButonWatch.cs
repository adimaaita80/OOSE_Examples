using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainingStateChartDiagrams
{
    public enum WatchState
    {
        DisplayingTime,
        BlinkHours,
        BlinkMinutes,
        BlinkSeconds,
        IncrementHours,
        IncrementMinutes,
        IncrementSeconds
    }

    public class TwoButonWatch
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public WatchState WatchState { get; set; } 
    }
}
