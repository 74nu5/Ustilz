#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer](Ustilz.Data.AccessLayer.md 'Ustilz.Data.AccessLayer')

## ABaseAccessLayer<TContext,TEntity,TIdentity> Class

Provides a base implementation for access layer.

```csharp
public abstract class ABaseAccessLayer<TContext,TEntity,TIdentity> :
Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity, TIdentity>
    where TContext : Ustilz.Data.ADbContext
    where TEntity : Ustilz.Data.Entities.ADataObject<TIdentity>
    where TIdentity : System.IComparable<TIdentity>
```
#### Type parameters

<a name='Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.TContext'></a>

`TContext`

Type context type.

<a name='Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.TEntity'></a>

`TEntity`

Type entity type.

<a name='Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.TIdentity'></a>

`TIdentity`

The primary key type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ABaseAccessLayer<TContext,TEntity,TIdentity>

Derived  
&#8627; [AQueryBaseAccessLayer&lt;TContext,TEntity,TQueryDto,TIdentity&gt;](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>')

Implements [Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer&lt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')[TEntity](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.TEntity')[,](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')[TIdentity](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.TIdentity 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.TIdentity')[&gt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')

| Constructors | |
| :--- | :--- |
| [ABaseAccessLayer(TContext)](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.ABaseAccessLayer(TContext).md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.ABaseAccessLayer(TContext)') | Initializes a new instance of the [ABaseAccessLayer&lt;TContext,TEntity,TIdentity&gt;](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>') class. |

| Fields | |
| :--- | :--- |
| [SQLCollationInsensitive](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.SQLCollationInsensitive.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.SQLCollationInsensitive') | The sql insensitive collation. |

| Properties | |
| :--- | :--- |
| [Context](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.Context.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.Context') | Gets the Db context. |
| [ModelSet](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.ModelSet.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.ModelSet') | Gets the Db model set. |

| Methods | |
| :--- | :--- |
| [RemoveAsync(TEntity)](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.RemoveAsync(TEntity).md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.RemoveAsync(TEntity)') | Async Method that remove a specific object in Db. |
| [RemoveRangeAsync(IEnumerable&lt;TEntity&gt;)](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.RemoveRangeAsync(System.Collections.Generic.IEnumerable_TEntity_).md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.RemoveRangeAsync(System.Collections.Generic.IEnumerable<TEntity>)') | Async method using bulk deletion method to remove data object from db context. |
