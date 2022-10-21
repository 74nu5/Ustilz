#### [Ustilz.Razor](index.md 'index')
### [Ustilz.Razor.Utils](Ustilz.Razor.Utils.md 'Ustilz.Razor.Utils').[BaseMapperExtensions](Ustilz.Razor.Utils.BaseMapperExtensions.md 'Ustilz.Razor.Utils.BaseMapperExtensions')

## BaseMapperExtensions.AddIf(this BaseMapper, string, Func<bool>) Method

Method which add a class by it name with a function which indicating whether the css class can be apply.

```csharp
public static Ustilz.Razor.Utils.BaseMapper AddIf(this Ustilz.Razor.Utils.BaseMapper m, string name, System.Func<bool> func);
```
#### Parameters

<a name='Ustilz.Razor.Utils.BaseMapperExtensions.AddIf(thisUstilz.Razor.Utils.BaseMapper,string,System.Func_bool_).m'></a>

`m` [BaseMapper](Ustilz.Razor.Utils.BaseMapper.md 'Ustilz.Razor.Utils.BaseMapper')

The [BaseMapper](Ustilz.Razor.Utils.BaseMapper.md 'Ustilz.Razor.Utils.BaseMapper').

<a name='Ustilz.Razor.Utils.BaseMapperExtensions.AddIf(thisUstilz.Razor.Utils.BaseMapper,string,System.Func_bool_).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The css class name.

<a name='Ustilz.Razor.Utils.BaseMapperExtensions.AddIf(thisUstilz.Razor.Utils.BaseMapper,string,System.Func_bool_).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The function which calculate whether the css class can be apply.

#### Returns
[BaseMapper](Ustilz.Razor.Utils.BaseMapper.md 'Ustilz.Razor.Utils.BaseMapper')  
Returns the [BaseMapper](Ustilz.Razor.Utils.BaseMapper.md 'Ustilz.Razor.Utils.BaseMapper').