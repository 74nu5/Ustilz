## .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
```assembly
; Tests.GetValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       mov       r11,7FFD057A0470
       call      qword ptr [r11]
       imul      eax,[rsi+10]
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```

## .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2
```assembly
; Tests.GetValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       mov       rax,offset MT_Tests+Producer42
       cmp       [rcx],rax
       jne       short M00_L01
       mov       eax,2A
M00_L00:
       imul      eax,[rbx+10]
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       r11,7FFD743C04B0
       call      qword ptr [r11]
       jmp       short M00_L00
; Total bytes of code 57
```

