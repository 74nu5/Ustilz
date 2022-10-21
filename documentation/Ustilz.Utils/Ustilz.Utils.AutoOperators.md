### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils')

## AutoOperators Class

A base class that automatically provides all operator overloads based on your class only implementing CompareTo.

```csharp
public abstract class AutoOperators :
System.IComparable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AutoOperators

Implements [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')

| Methods | |
| :--- | :--- |
| [Compare(AutoOperators, AutoOperators)](Ustilz.Utils.AutoOperators.Compare(Ustilz.Utils.AutoOperators,Ustilz.Utils.AutoOperators).md 'Ustilz.Utils.AutoOperators.Compare(Ustilz.Utils.AutoOperators, Ustilz.Utils.AutoOperators)') | Comparaison method by référence. |
| [CompareTo(object)](Ustilz.Utils.AutoOperators.CompareTo(object).md 'Ustilz.Utils.AutoOperators.CompareTo(object)') | Compare l'instance actuelle avec un autre objet du même type et retourne un entier qui indique si l'instance actuelle précède ou suit un autre objet ou se trouve à la même position dans l'ordre de tri. |
| [Equals(object)](Ustilz.Utils.AutoOperators.Equals(object).md 'Ustilz.Utils.AutoOperators.Equals(object)') | Détermine si l'objet spécifié est identique à l'objet actuel. |
| [GetHashCode()](Ustilz.Utils.AutoOperators.GetHashCode().md 'Ustilz.Utils.AutoOperators.GetHashCode()') | Fait office de fonction de hachage par défaut. |

| Operators | |
| :--- | :--- |
| [operator ==(AutoOperators, AutoOperators)](Ustilz.Utils.AutoOperators.op_Equality(Ustilz.Utils.AutoOperators,Ustilz.Utils.AutoOperators).md 'Ustilz.Utils.AutoOperators.op_Equality(Ustilz.Utils.AutoOperators, Ustilz.Utils.AutoOperators)') | Operator equals. |
| [operator &gt;(AutoOperators, AutoOperators)](Ustilz.Utils.AutoOperators.op_GreaterThan(Ustilz.Utils.AutoOperators,Ustilz.Utils.AutoOperators).md 'Ustilz.Utils.AutoOperators.op_GreaterThan(Ustilz.Utils.AutoOperators, Ustilz.Utils.AutoOperators)') | Operator greater than. |
| [operator &gt;=(AutoOperators, AutoOperators)](Ustilz.Utils.AutoOperators.op_GreaterThanOrEqual(Ustilz.Utils.AutoOperators,Ustilz.Utils.AutoOperators).md 'Ustilz.Utils.AutoOperators.op_GreaterThanOrEqual(Ustilz.Utils.AutoOperators, Ustilz.Utils.AutoOperators)') | Operator greater than or equals. |
| [operator !=(AutoOperators, AutoOperators)](Ustilz.Utils.AutoOperators.op_Inequality(Ustilz.Utils.AutoOperators,Ustilz.Utils.AutoOperators).md 'Ustilz.Utils.AutoOperators.op_Inequality(Ustilz.Utils.AutoOperators, Ustilz.Utils.AutoOperators)') | Operator not equals. |
| [operator &lt;(AutoOperators, AutoOperators)](Ustilz.Utils.AutoOperators.op_LessThan(Ustilz.Utils.AutoOperators,Ustilz.Utils.AutoOperators).md 'Ustilz.Utils.AutoOperators.op_LessThan(Ustilz.Utils.AutoOperators, Ustilz.Utils.AutoOperators)') | Operator less than. |
| [operator &lt;=(AutoOperators, AutoOperators)](Ustilz.Utils.AutoOperators.op_LessThanOrEqual(Ustilz.Utils.AutoOperators,Ustilz.Utils.AutoOperators).md 'Ustilz.Utils.AutoOperators.op_LessThanOrEqual(Ustilz.Utils.AutoOperators, Ustilz.Utils.AutoOperators)') | Operator less than or equals. |
