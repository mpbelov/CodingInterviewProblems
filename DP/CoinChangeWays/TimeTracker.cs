namespace ExecutionTimeTracker {
    public static class TimeTracker {
        public static System.TimeSpan Execute(System.Action action) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            action();
            watch.Stop();
            return System.TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds);
        }
    }
}