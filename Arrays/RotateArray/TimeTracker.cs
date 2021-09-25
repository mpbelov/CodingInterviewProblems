using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

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
        } else if (baseline != null && result == null) {
            Console.WriteLine($"Wrong! {executionTime.TotalSeconds} seconds. Expected {baseline} but was 'null'");
        } else if (baseline == null && result != null) {
            Console.WriteLine($"Wrong! {executionTime.TotalSeconds} seconds. Expected 'null' but was {result}");
        } else if (baseline is IEnumerable baselineEnumerable && result is IEnumerable resultEnumerable) {
            var equal = true;
            var baselineEnumerator = baselineEnumerable.GetEnumerator();
            var resultEnumerator = resultEnumerable.GetEnumerator();

            bool baselineEnumeratorHasNext, resultEnumeratorHasNext;
            while ((baselineEnumeratorHasNext = baselineEnumerator.MoveNext())
                 & (resultEnumeratorHasNext = resultEnumerator.MoveNext())) { // & is explicit - we need to call both iterators
                if (!baselineEnumerator.Current.Equals(resultEnumerator.Current)) {
                    equal = false;
                    break;
                };
            }

            if (equal && !baselineEnumeratorHasNext && resultEnumeratorHasNext
                || (equal && baselineEnumeratorHasNext && !resultEnumeratorHasNext)) { // something left in one of iterators
                equal = false;
            }

            if (equal) {
                Console.WriteLine($"Correct! {executionTime.TotalSeconds} seconds. Expected {IEnumerableToString(baselineEnumerable)} and actual was {IEnumerableToString(resultEnumerable)}");
            } else {
                Console.WriteLine($"Wrong! {executionTime.TotalSeconds} seconds. Expected {IEnumerableToString(baselineEnumerable)} but was {IEnumerableToString(resultEnumerable)}");
            }
        } else if (result.Equals(baseline)) {
            Console.WriteLine($"Correct! {executionTime.TotalSeconds} seconds. Expected {baseline} and actual was {result}");
        } else {
            Console.WriteLine($"Wrong! {executionTime.TotalSeconds} seconds. Expected {baseline} but was {result}");
        }
    }

    private static string IEnumerableToString(IEnumerable collection) {
        var sb = new StringBuilder("[");
        foreach (var element in collection) {
            sb.Append(element.ToString());
            sb.Append(",");
        }
        if (sb.Length > 1) {
            sb.Remove(sb.Length - 1, 1);
        }
        sb.Append("]");
        return sb.ToString();
    }
}

///<summary>Short alias for <see cref="TimeTracker"/> class</summary>
public static class TT {
    ///<summary>Short alias for <see cref="TimeTracker.Execute{T}"/> method</summary>
    public static void E<T>(Func<T> action, T baseline) {
        TimeTracker.Execute<T>(action, baseline);
    }
}