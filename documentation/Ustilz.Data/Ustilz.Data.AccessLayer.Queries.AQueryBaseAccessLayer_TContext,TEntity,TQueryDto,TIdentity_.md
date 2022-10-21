#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Queries](Ustilz.Data.AccessLayer.Queries.md 'Ustilz.Data.AccessLayer.Queries')

## AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity> Class

Abstraction that provides basic CRUD operations on models data.

```csharp
public abstract class AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity> : Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext, TEntity, TIdentity>,
Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity, TQueryDto, TIdentity>,
Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity, TIdentity>
    where TContext : Ustilz.Data.ADbContext
    where TEntity : Ustilz.Data.Entities.ADataObject<TIdentity>
    where TQueryDto : Ustilz.Data.AccessLayer.Queries.Pageable.PageableQuery
    where TIdentity : System.IComparable<TIdentity>
```
#### Type parameters

<a name='Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TContext'></a>

`TContext`

The context to query.

<a name='Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TEntity'></a>

`TEntity`

The entity type to query.

<a name='Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TQueryDto'></a>

`TQueryDto`

The query type.

<a name='Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TIdentity'></a>

`TIdentity`

The primary key type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Ustilz.Data.AccessLayer.ABaseAccessLayer&lt;](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>')[TContext](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TContext 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TContext')[,](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>')[TEntity](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TEntity')[,](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>')[TIdentity](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TIdentity 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TIdentity')[&gt;](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>') &#129106; AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>

Implements [Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer&lt;](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>')[TEntity](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TEntity')[,](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>')[TQueryDto](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TQueryDto 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TQueryDto')[,](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>')[TIdentity](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TIdentity 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TIdentity')[&gt;](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>'), [Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer&lt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')[TEntity](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TEntity')[,](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')[TIdentity](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TIdentity 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TIdentity')[&gt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')

| Constructors | |
| :--- | :--- |
| [AQueryBaseAccessLayer(TContext)](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.AQueryBaseAccessLayer(TContext).md 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.AQueryBaseAccessLayer(TContext)') | Initializes a new instance of the [AQueryBaseAccessLayer&lt;TContext,TEntity,TQueryDto,TIdentity&gt;](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>') class. |

| Methods | |
| :--- | :--- |
| [GetCollectionInternalAsync(TQueryDto, bool)](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.GetCollectionInternalAsync(TQueryDto,bool).md 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.GetCollectionInternalAsync(TQueryDto, bool)') | Internal method that retrieve a queryable collection of data according to the query. |
