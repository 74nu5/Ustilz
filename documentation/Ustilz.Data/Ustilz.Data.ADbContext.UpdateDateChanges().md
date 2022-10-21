#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data](Ustilz.Data.md 'Ustilz.Data').[ADbContext](Ustilz.Data.ADbContext.md 'Ustilz.Data.ADbContext')

## ADbContext.UpdateDateChanges() Method

For each entity to be saved in database, this method fills :  
- <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.CreationDate"/> if entity state is <seealso cref="F:Microsoft.EntityFrameworkCore.EntityState.Added"/>  
- <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.LastModifiedDate"/> if entity state is <seealso cref="F:Microsoft.EntityFrameworkCore.EntityState.Modified"/>

```csharp
private void UpdateDateChanges();
```