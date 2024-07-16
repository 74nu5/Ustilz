```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  Job-TMETWW : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  Job-QLBEFC : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2


```
| Method   | Runtime  | Mean      | Ratio | Code Size |
|--------- |--------- |----------:|------:|----------:|
| GetValue | .NET 7.0 | 2.0724 ns |  1.00 |      35 B |
| GetValue | .NET 8.0 | 0.3131 ns |  0.15 |      57 B |
