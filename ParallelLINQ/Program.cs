
using System.Diagnostics;

var sw = Stopwatch.StartNew();

sw.Start();

var collection = Enumerable.Range(1, 100)
    .AsParallel()
    .Select(HeavyCompuation);

int HeavyCompuation(int n)
{
    for (int i = 0; i < 100_000_000; i++) n += i;
    return n;
}

foreach (var _ in collection) ;

sw.Stop();

Console.WriteLine($"Execution time {sw.ElapsedMilliseconds}");

Console.ReadLine();