#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables')

## ExtensionsIEnumerable Class

The extensions i enumerable.

```csharp
public static class ExtensionsIEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExtensionsIEnumerable

| Methods | |
| :--- | :--- |
| [Adjust&lt;T&gt;(this IEnumerable&lt;T&gt;, Func&lt;T,int,bool&gt;, T)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,int,bool>, T)') | Méthode permettant d'ajuster des éléments d'un [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'). |
| [Bifurcate&lt;T&gt;(this IEnumerable&lt;T&gt;, IList&lt;bool&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<bool>)') | Méthode qui split une liste à partir d'un tableau de booléen. |
| [Bifurcate&lt;T&gt;(this IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,bool>)') | Méthode qui split une liste à partir d'un prédicat. |
| [FindMax&lt;T,TValue&gt;(this IEnumerable&lt;T&gt;, Func&lt;T,TValue&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax<T,TValue>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,TValue>)') | Méthode de récupération de l'élément de la liste pour lequel le sélecteur renvoie la valeur maximale. |
| [FindMin&lt;T,TValue&gt;(this IEnumerable&lt;T&gt;, Func&lt;T,TValue&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMin_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMin<T,TValue>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,TValue>)') | Méthode de récupération de l'élément de la liste pour lequel le sélecteur renvoie la valeur minimale. |
| [ForEach&lt;T&gt;(this IEnumerable&lt;T&gt;, Action&lt;T&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>)') | Enumerate each element in the enumeration and execute specified action. |
| [Join&lt;T&gt;(this IEnumerable&lt;T&gt;, string)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Join_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Join<T>(this System.Collections.Generic.IEnumerable<T>, string)') | The join. |
| [NotAny&lt;T&gt;(this IEnumerable&lt;T&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny<T>(this System.Collections.Generic.IEnumerable<T>)') | Determines whether the given IEnumerable contains no items, or not. |
| [NotAny&lt;T&gt;(this IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,bool>)') | Determines whether the given IEnumerable contains no items matching the given predicate, or not. |
| [Page&lt;T&gt;(this IEnumerable&lt;T&gt;, int, int)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Page_T_(thisSystem.Collections.Generic.IEnumerable_T_,int,int).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Page<T>(this System.Collections.Generic.IEnumerable<T>, int, int)') | Gets a subset of IEnumerable by passing the page number. |
| [Pairwise&lt;T,TReturn&gt;(this IEnumerable&lt;T&gt;, Func&lt;T,T,TReturn&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise<T,TReturn>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,T,TReturn>)') | Méthode de traitement des éléments d'une liste deux à deux. |
| [PathCombine(this IEnumerable&lt;string&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.PathCombine(thisSystem.Collections.Generic.IEnumerable_string_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.PathCombine(this System.Collections.Generic.IEnumerable<string>)') | Returns a path combined out of the items in the given IEnumerable. |
| [SplitList&lt;T&gt;(IEnumerable&lt;T&gt;, int)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.SplitList_T_(System.Collections.Generic.IEnumerable_T_,int).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.SplitList<T>(System.Collections.Generic.IEnumerable<T>, int)') | Méthode de split d'un liste en n liste. |
| [ToHexString(this IEnumerable&lt;byte&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ToHexString(thisSystem.Collections.Generic.IEnumerable_byte_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ToHexString(this System.Collections.Generic.IEnumerable<byte>)') | Converts bytes collection to hexadecimal representation. |
| [ToReadOnly&lt;T&gt;(this IEnumerable&lt;T&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ToReadOnly_T_(thisSystem.Collections.Generic.IEnumerable_T_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ToReadOnly<T>(this System.Collections.Generic.IEnumerable<T>)') | Read only collection of any enumeration. |
| [WithIndex&lt;T&gt;(this IEnumerable&lt;T&gt;)](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex_T_(thisSystem.Collections.Generic.IEnumerable_T_).md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex<T>(this System.Collections.Generic.IEnumerable<T>)') | Méthode récupération d'une énumération avec index. |