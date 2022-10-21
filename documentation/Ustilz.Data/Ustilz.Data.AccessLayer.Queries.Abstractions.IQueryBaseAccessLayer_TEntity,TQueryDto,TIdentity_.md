#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Queries.Abstractions](Ustilz.Data.AccessLayer.Queries.Abstractions.md 'Ustilz.Data.AccessLayer.Queries.Abstractions')

## IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity> Interface

Interface which represent the query base access layer.

```csharp
public interface IQueryBaseAccessLayer<TEntity,in TQueryDto,TIdentity> :
Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity, TIdentity>
    where TEntity : Ustilz.Data.Entities.ADataObject<TIdentity>
    where TQueryDto : Ustilz.Data.AccessLayer.Queries.Pageable.PageableQuery
    where TIdentity : System.IComparable<TIdentity>
```
#### Type parameters

<a name='Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.TEntity'></a>

`TEntity`

The entity type to query.

<a name='Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.TQueryDto'></a>

`TQueryDto`

The query type.

<a name='Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.TIdentity'></a>

`TIdentity`

The primary key type.

Derived  
&#8627; [AQueryBaseAccessLayer&lt;TContext,TEntity,TQueryDto,TIdentity&gt;](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>')

Implements [Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer&lt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')[TEntity](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.TEntity')[,](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')[TIdentity](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.TIdentity 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.TIdentity')[&gt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')

| Methods | |
| :--- | :--- |
| [CountCollectionAsync(TQueryDto)](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.CountCollectionAsync(TQueryDto).md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.CountCollectionAsync(TQueryDto)') | Method that retrieve the count of collection of data according to the query. |
| [GetCollectionAsync(TQueryDto, bool)](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.GetCollectionAsync(TQueryDto,bool).md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.GetCollectionAsync(TQueryDto, bool)') | Method that retrieve a collection of data according to the query. |
| [GetPageableCollectionAsync(TQueryDto, bool)](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.GetPageableCollectionAsync(TQueryDto,bool).md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.GetPageableCollectionAsync(TQueryDto, bool)') | Method that retrieve a pageable collection of data according to the query. |
