using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace ConsoleBenchmarkDotNet;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class Benchy
{
    const string ClearValue = "Password123!";

    [Benchmark]
    public string MaskNaive()
    {
        
        var firstChars = ClearValue.Substring(0, 3);
        var length = ClearValue.Length - 3;

        for (var i = 0; i < length; i++)
        {
            firstChars += '*';
        }

        return firstChars;
    }

    [Benchmark]
    public string MaskStringBuilder()
    {

        var firstChars = ClearValue.Substring(0, 3);
        var length = ClearValue.Length - 3;
        var stringBuilder = new StringBuilder(firstChars);

        for (var i = 0; i < length; i++)
        {
            stringBuilder.Append('*');
        }

        return firstChars;
    }

    [Benchmark]
    public string Mask()
    {
        var length = ClearValue.Length - 3;
        var s = new string('*', length);

        return s;
    }
}
