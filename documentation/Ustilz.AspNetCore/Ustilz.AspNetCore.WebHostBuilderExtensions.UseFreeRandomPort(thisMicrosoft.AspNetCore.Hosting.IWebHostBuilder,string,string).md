### [Ustilz.AspNetCore](Ustilz.AspNetCore.md 'Ustilz.AspNetCore').[WebHostBuilderExtensions](Ustilz.AspNetCore.WebHostBuilderExtensions.md 'Ustilz.AspNetCore.WebHostBuilderExtensions')

## WebHostBuilderExtensions.UseFreeRandomPort(this IWebHostBuilder, string, string) Method

Method that enable acces of website / api on free random port and and defined http / https domain.

```csharp
public static Microsoft.AspNetCore.Hosting.IWebHostBuilder UseFreeRandomPort(this Microsoft.AspNetCore.Hosting.IWebHostBuilder webHostBuilder, string httpListenDomain, string httpsListenDomain);
```
#### Parameters

<a name='Ustilz.AspNetCore.WebHostBuilderExtensions.UseFreeRandomPort(thisMicrosoft.AspNetCore.Hosting.IWebHostBuilder,string,string).webHostBuilder'></a>

`webHostBuilder` [Microsoft.AspNetCore.Hosting.IWebHostBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Hosting.IWebHostBuilder 'Microsoft.AspNetCore.Hosting.IWebHostBuilder')

The web host builder.

<a name='Ustilz.AspNetCore.WebHostBuilderExtensions.UseFreeRandomPort(thisMicrosoft.AspNetCore.Hosting.IWebHostBuilder,string,string).httpListenDomain'></a>

`httpListenDomain` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Http domain to listen.

<a name='Ustilz.AspNetCore.WebHostBuilderExtensions.UseFreeRandomPort(thisMicrosoft.AspNetCore.Hosting.IWebHostBuilder,string,string).httpsListenDomain'></a>

`httpsListenDomain` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Https domain to listen.

#### Returns
[Microsoft.AspNetCore.Hosting.IWebHostBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Hosting.IWebHostBuilder 'Microsoft.AspNetCore.Hosting.IWebHostBuilder')  
Returns the web host builder.