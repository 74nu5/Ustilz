### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpExtensions](Ustilz.Http.HttpExtensions.md 'Ustilz.Http.HttpExtensions')

## HttpExtensions.ProcessWebException(this WebException) Method

The process web exception.

```csharp
public static System.Net.WebException ProcessWebException(this System.Net.WebException exception);
```
#### Parameters

<a name='Ustilz.Http.HttpExtensions.ProcessWebException(thisSystem.Net.WebException).exception'></a>

`exception` [System.Net.WebException](https://docs.microsoft.com/en-us/dotnet/api/System.Net.WebException 'System.Net.WebException')

The exception.

#### Returns
[System.Net.WebException](https://docs.microsoft.com/en-us/dotnet/api/System.Net.WebException 'System.Net.WebException')  
The [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[exception](Ustilz.Http.HttpExtensions.ProcessWebException(thisSystem.Net.WebException).md#Ustilz.Http.HttpExtensions.ProcessWebException(thisSystem.Net.WebException).exception 'Ustilz.Http.HttpExtensions.ProcessWebException(this System.Net.WebException).exception') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
Any attempt is made to access the method, when the method is not overridden in a descendant class.

[System.Net.WebException](https://docs.microsoft.com/en-us/dotnet/api/System.Net.WebException 'System.Net.WebException')  
Throw web exeption when response stream is null.

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Stream does not support reading.

[System.OutOfMemoryException](https://docs.microsoft.com/en-us/dotnet/api/System.OutOfMemoryException 'System.OutOfMemoryException')  
There is insufficient memory to allocate a buffer for the returned string.

[System.IO.IOException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.IOException 'System.IO.IOException')  
An I/O error occurs.