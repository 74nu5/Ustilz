```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-11370H 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200-preview.0.25057.12
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method             | Mean     | Error    | StdDev   | Gen0   | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated native memory | Native memory leak | Allocated |
|------------------- |---------:|---------:|---------:|-------:|-----------:|----------:|---------------------:|-----------------:|------------------------:|-------------------:|----------:|
| ParseWorlCupResult | 537.5 μs | 11.63 μs | 32.60 μs | 1.9531 |          - |      74 B |                    - |                - |                    0 KB |               0 KB |  49.23 KB |
