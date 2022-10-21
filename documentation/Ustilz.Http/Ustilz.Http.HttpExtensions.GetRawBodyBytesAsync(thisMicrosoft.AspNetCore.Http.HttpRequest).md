### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpExtensions](Ustilz.Http.HttpExtensions.md 'Ustilz.Http.HttpExtensions')

## HttpExtensions.GetRawBodyBytesAsync(this HttpRequest) Method

Retrieves the raw body as a byte array from the Request.Body stream.

```csharp
public static System.Threading.Tasks.Task<byte[]> GetRawBodyBytesAsync(this Microsoft.AspNetCore.Http.HttpRequest request);
```
#### Parameters

<a name='Ustilz.Http.HttpExtensions.GetRawBodyBytesAsync(thisMicrosoft.AspNetCore.Http.HttpRequest).request'></a>

`request` [Microsoft.AspNetCore.Http.HttpRequest](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpRequest 'Microsoft.AspNetCore.Http.HttpRequest')

The request.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Destination is null.

[System.ObjectDisposedException](https://docs.microsoft.com/en-us/dotnet/api/System.ObjectDisposedException 'System.ObjectDisposedException')  
Either the current stream or the destination stream is disposed.

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The current stream does not support reading, or the destination stream does not support writing.

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
Capacity is negative.