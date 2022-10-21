#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsNameValueCollection](Ustilz.Extensions.ExtensionsNameValueCollection.md 'Ustilz.Extensions.ExtensionsNameValueCollection')

## ExtensionsNameValueCollection.ToDictionary(this NameValueCollection) Method

The to dictionary.

```csharp
public static System.Collections.Generic.Dictionary<string,string> ToDictionary(this System.Collections.Specialized.NameValueCollection? nvc);
```
#### Parameters

<a name='Ustilz.Extensions.ExtensionsNameValueCollection.ToDictionary(thisSystem.Collections.Specialized.NameValueCollection).nvc'></a>

`nvc` [System.Collections.Specialized.NameValueCollection](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Specialized.NameValueCollection 'System.Collections.Specialized.NameValueCollection')

The nvc.

#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
The Dictionary{string, string}.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[nvc](Ustilz.Extensions.ExtensionsNameValueCollection.ToDictionary(thisSystem.Collections.Specialized.NameValueCollection).md#Ustilz.Extensions.ExtensionsNameValueCollection.ToDictionary(thisSystem.Collections.Specialized.NameValueCollection).nvc 'Ustilz.Extensions.ExtensionsNameValueCollection.ToDictionary(this System.Collections.Specialized.NameValueCollection).nvc') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
keySelector produces duplicate keys for two elements.

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The collection is read-only and the operation attempts to modify the collection.