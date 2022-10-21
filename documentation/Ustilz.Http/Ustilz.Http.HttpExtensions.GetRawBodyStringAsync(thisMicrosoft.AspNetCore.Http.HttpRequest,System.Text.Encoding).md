### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpExtensions](Ustilz.Http.HttpExtensions.md 'Ustilz.Http.HttpExtensions')

## HttpExtensions.GetRawBodyStringAsync(this HttpRequest, Encoding) Method

Retrieve the raw body as a string from the Request.Body stream.

```csharp
public static System.Threading.Tasks.Task<string> GetRawBodyStringAsync(this Microsoft.AspNetCore.Http.HttpRequest request, System.Text.Encoding? encoding=null);
```
#### Parameters

<a name='Ustilz.Http.HttpExtensions.GetRawBodyStringAsync(thisMicrosoft.AspNetCore.Http.HttpRequest,System.Text.Encoding).request'></a>

`request` [Microsoft.AspNetCore.Http.HttpRequest](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpRequest 'Microsoft.AspNetCore.Http.HttpRequest')

Request instance to apply to.

<a name='Ustilz.Http.HttpExtensions.GetRawBodyStringAsync(thisMicrosoft.AspNetCore.Http.HttpRequest,System.Text.Encoding).encoding'></a>

`encoding` [System.Text.Encoding](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Encoding 'System.Text.Encoding')

Optional - Encoding, defaults to UTF8.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task').

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Stream does not support reading.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[request](Ustilz.Http.HttpExtensions.GetRawBodyStringAsync(thisMicrosoft.AspNetCore.Http.HttpRequest,System.Text.Encoding).md#Ustilz.Http.HttpExtensions.GetRawBodyStringAsync(thisMicrosoft.AspNetCore.Http.HttpRequest,System.Text.Encoding).request 'Ustilz.Http.HttpExtensions.GetRawBodyStringAsync(this Microsoft.AspNetCore.Http.HttpRequest, System.Text.Encoding).request') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The reader is currently in use by a previous read operation.

[System.ObjectDisposedException](https://docs.microsoft.com/en-us/dotnet/api/System.ObjectDisposedException 'System.ObjectDisposedException')  
The stream has been disposed.

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The number of characters is larger than [System.Int32.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MaxValue 'System.Int32.MaxValue').