#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsDictionary](Ustilz.Extensions.ExtensionsDictionary.md 'Ustilz.Extensions.ExtensionsDictionary')

## ExtensionsDictionary.GetOrCreate<TKey,TValue>(this IDictionary<TKey,TValue>, TKey, TValue) Method

Méthode qui obtient une valeur d'un dictionnaire, si la clé n'existe pas la valeur calculée est créé avec la clé fournie.

```csharp
public static TValue GetOrCreate<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dictionary, TKey key, TValue missingValue);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TKey'></a>

`TKey`

Le type de la clé.

<a name='Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TValue'></a>

`TValue`

Le type de la valeur.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).dictionary'></a>

`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TKey 'Ustilz.Extensions.ExtensionsDictionary.GetOrCreate<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TValue 'Ustilz.Extensions.ExtensionsDictionary.GetOrCreate<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

Le dictionnaire.

<a name='Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).key'></a>

`key` [TKey](Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TKey 'Ustilz.Extensions.ExtensionsDictionary.GetOrCreate<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TKey')

La clé.

<a name='Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).missingValue'></a>

`missingValue` [TValue](Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TValue 'Ustilz.Extensions.ExtensionsDictionary.GetOrCreate<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TValue')

La valeur à insérer si la clé n'existe pas.

#### Returns
[TValue](Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.GetOrCreate_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TValue 'Ustilz.Extensions.ExtensionsDictionary.GetOrCreate<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TValue')  
Retourne la valeur associé à la clé, si la clé n'existe pas la valeur calculée est retournée.