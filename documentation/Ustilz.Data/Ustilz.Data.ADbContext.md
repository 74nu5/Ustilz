#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data](Ustilz.Data.md 'Ustilz.Data')

## ADbContext Class

Represents the application Database.

```csharp
public abstract class ADbContext : Microsoft.EntityFrameworkCore.DbContext
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext') &#129106; ADbContext

| Constructors | |
| :--- | :--- |
| [ADbContext(DbContextOptions)](Ustilz.Data.ADbContext.ADbContext(Microsoft.EntityFrameworkCore.DbContextOptions).md 'Ustilz.Data.ADbContext.ADbContext(Microsoft.EntityFrameworkCore.DbContextOptions)') | Initializes a new instance of the [ADbContext](Ustilz.Data.ADbContext.md 'Ustilz.Data.ADbContext') class. |

| Methods | |
| :--- | :--- |
| [SaveChanges()](Ustilz.Data.ADbContext.SaveChanges().md 'Ustilz.Data.ADbContext.SaveChanges()') | Update <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.CreationDate"/> and <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.LastModifiedDate"/> before apply changes in databse. |
| [SaveChangesAsync(CancellationToken)](Ustilz.Data.ADbContext.SaveChangesAsync(System.Threading.CancellationToken).md 'Ustilz.Data.ADbContext.SaveChangesAsync(System.Threading.CancellationToken)') | Async method to update <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.CreationDate"/> and <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.LastModifiedDate"/> before apply changes in databse. |
| [UpdateDateChanges()](Ustilz.Data.ADbContext.UpdateDateChanges().md 'Ustilz.Data.ADbContext.UpdateDateChanges()') | For each entity to be saved in database, this method fills : |
