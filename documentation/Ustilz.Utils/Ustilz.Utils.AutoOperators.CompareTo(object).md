### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[AutoOperators](Ustilz.Utils.AutoOperators.md 'Ustilz.Utils.AutoOperators')

## AutoOperators.CompareTo(object) Method

Compare l'instance actuelle avec un autre objet du même type et retourne un entier qui indique si l'instance actuelle précède ou suit un autre objet ou se trouve à la même position dans l'ordre de tri.

```csharp
public abstract int CompareTo(object? obj);
```
#### Parameters

<a name='Ustilz.Utils.AutoOperators.CompareTo(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

Objet à comparer à cette instance.

Implements [CompareTo(object)](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable.CompareTo#System_IComparable_CompareTo_System_Object_ 'System.IComparable.CompareTo(System.Object)')

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Valeur qui indique l'ordre relatif des objets comparés. La valeur de retour a les significations suivantes :   
  Value   
  Signification   
  Inférieure à zéro   
  Cette instance précède [obj](Ustilz.Utils.AutoOperators.CompareTo(object).md#Ustilz.Utils.AutoOperators.CompareTo(object).obj 'Ustilz.Utils.AutoOperators.CompareTo(object).obj') dans l'ordre de tri.    
  Zéro   
  Cette instance se produit à la même position dans l'ordre de tri que [obj](Ustilz.Utils.AutoOperators.CompareTo(object).md#Ustilz.Utils.AutoOperators.CompareTo(object).obj 'Ustilz.Utils.AutoOperators.CompareTo(object).obj').    
  Supérieure à zéro   
  Cette instance suit [obj](Ustilz.Utils.AutoOperators.CompareTo(object).md#Ustilz.Utils.AutoOperators.CompareTo(object).obj 'Ustilz.Utils.AutoOperators.CompareTo(object).obj') dans l'ordre de tri.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[obj](Ustilz.Utils.AutoOperators.CompareTo(object).md#Ustilz.Utils.AutoOperators.CompareTo(object).obj 'Ustilz.Utils.AutoOperators.CompareTo(object).obj') n'est pas du même type que cette instance.