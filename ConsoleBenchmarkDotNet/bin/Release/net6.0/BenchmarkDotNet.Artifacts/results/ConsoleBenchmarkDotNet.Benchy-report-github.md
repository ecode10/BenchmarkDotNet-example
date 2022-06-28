``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.301
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|            Method |      Mean |    Error |    StdDev |    Median | Rank |  Gen 0 | Allocated |
|------------------ |----------:|---------:|----------:|----------:|-----:|-------:|----------:|
|              Mask |  16.27 ns | 0.406 ns |  1.158 ns |  15.86 ns |    1 | 0.0172 |      72 B |
| MaskStringBuilder |  38.60 ns | 0.836 ns |  1.920 ns |  38.80 ns |    2 | 0.0325 |     136 B |
|         MaskNaive | 122.31 ns | 3.689 ns | 10.701 ns | 120.09 ns |    3 | 0.0956 |     400 B |
