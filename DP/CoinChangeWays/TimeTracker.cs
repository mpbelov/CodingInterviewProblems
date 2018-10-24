using System;
using System.Diagnostics;

namespace ExecutionTimeTracker {
    public static class TimeTracker {
        public static TimeSpan Execute(Action action) {
            var watch = Stopwatch.StartNew();
            action?.Invoke();
            watch.Stop();
            return TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds);
        }
    }
}