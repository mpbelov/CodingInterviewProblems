using System;
using System.Diagnostics;

public static class TimeTracker {
    public static TimeSpan Execute(Action action) {
        var watch = Stopwatch.StartNew();
        action?.Invoke();
        watch.Stop();
        return TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds);
    }

    public static void Execute<T>(Func<T> action, T baseline) {
        var result = default(T);
        var executionTime = Execute(() => result = action());
        if (baseline == null && result == null) {
            Console.WriteLine($"Correct! {executionTime.TotalSeconds} seconds. Expected 'null' and actual was 'null'");
        } else if (result.Equals(baseline)) {
            Console.WriteLine($"Correct! {executionTime.TotalSeconds} seconds. Expected {baseline} and actual was {result}");
        } else {
            Console.WriteLine($"Wrong! {executionTime.TotalSeconds} seconds. Expected {baseline} but was {result}");
        }
    }
}

///<summary>Short alias for <see cref="TimeTracker"/> class</summary>
public static class TT {
    ///<summary>Short alias for <see cref="TimeTracker.Execute{T}"/> method</summary>
    public static void E<T>(Func<T> action, T baseline) {
        TimeTracker.Execute<T>(action, baseline);
    }
}