## .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; Tests.ParseWorlCupResult()
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rdx,[rcx+10]
       mov       rax,[rcx+20]
       mov       dword ptr [rsp+28],100
       mov       word ptr [rsp+30],2C
       mov       byte ptr [rsp+32],1
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD36145980]; Ustilz.Benchmark.Parsers.Parsers.WorldCupMatchesParser.Parse(System.String, Ustilz.Parsers.Csv.CsvParsingOptions)
       nop
       add       rsp,38
       ret
; Total bytes of code 74
```

