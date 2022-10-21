#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsDictionary](Ustilz.Extensions.ExtensionsDictionary.md 'Ustilz.Extensions.ExtensionsDictionary')

## ExtensionsDictionary.AddOrUpdate<TKey,TValue>(this Dictionary<TKey,TValue>, TKey, TValue) Method

Méthode d'ajout ou de mise à jour de valeur dans un dictionnaire.

```csharp
public static bool AddOrUpdate<TKey,TValue>(this System.Collections.Generic.Dictionary<TKey,TValue> dictionary, TKey key, TValue value)
    where TKey : notnull;
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).TKey'></a>

`TKey`

Type de la clé du dictionnaire.

<a name='Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).TValue'></a>

`TValue`

Type de la valeur du dictionnaire.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).dictionary'></a>

`dictionary` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TKey](Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).TKey 'Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate<TKey,TValue>(this System.Collections.Generic.Dictionary<TKey,TValue>, TKey, TValue).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TValue](Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).TValue 'Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate<TKey,TValue>(this System.Collections.Generic.Dictionary<TKey,TValue>, TKey, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

Dictionnaire à modifier.

<a name='Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).key'></a>

`key` [TKey](Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).TKey 'Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate<TKey,TValue>(this System.Collections.Generic.Dictionary<TKey,TValue>, TKey, TValue).TKey')

Clé de l'élément à ajouter/modifier.

<a name='Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).value'></a>

`value` [TValue](Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).md#Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate_TKey,TValue_(thisSystem.Collections.Generic.Dictionary_TKey,TValue_,TKey,TValue).TValue 'Ustilz.Extensions.ExtensionsDictionary.AddOrUpdate<TKey,TValue>(this System.Collections.Generic.Dictionary<TKey,TValue>, TKey, TValue).TValue')

Valeur de l'élément à ajouter/modifier.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Retourn True si la clé existe déjà, False sinon.