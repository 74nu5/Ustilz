### [Ustilz.Time](Ustilz.Time.md 'Ustilz.Time')

## Clock Class

Class de wrapping de la propriété [System.DateTime.Now](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.Now 'System.DateTime.Now').

```csharp
public static class Clock
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Clock

| Fields | |
| :--- | :--- |
| [function](Ustilz.Time.Clock.function.md 'Ustilz.Time.Clock.function') | La fonction de remplacement de [System.DateTime.Now](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.Now 'System.DateTime.Now'). |

| Properties | |
| :--- | :--- |
| [Now](Ustilz.Time.Clock.Now.md 'Ustilz.Time.Clock.Now') | Obtient la valeur définit par la fonction [function](Ustilz.Time.Clock.function.md 'Ustilz.Time.Clock.function'), renvoie [System.DateTime.Now](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.Now 'System.DateTime.Now') si la fonction n'est pas définit. |

| Methods | |
| :--- | :--- |
| [Reset()](Ustilz.Time.Clock.Reset().md 'Ustilz.Time.Clock.Reset()') | Méthode de remise à zéro de la fonction [Now](Ustilz.Time.Clock.Now.md 'Ustilz.Time.Clock.Now'). |
| [SetFunctionNow(Func&lt;DateTime&gt;)](Ustilz.Time.Clock.SetFunctionNow(System.Func_System.DateTime_).md 'Ustilz.Time.Clock.SetFunctionNow(System.Func<System.DateTime>)') | Définit la fonction [function](Ustilz.Time.Clock.function.md 'Ustilz.Time.Clock.function'), appelée par la propriété [Now](Ustilz.Time.Clock.Now.md 'Ustilz.Time.Clock.Now'). |
