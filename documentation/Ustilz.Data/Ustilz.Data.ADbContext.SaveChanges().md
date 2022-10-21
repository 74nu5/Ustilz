#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data](Ustilz.Data.md 'Ustilz.Data').[ADbContext](Ustilz.Data.ADbContext.md 'Ustilz.Data.ADbContext')

## ADbContext.SaveChanges() Method

Update <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.CreationDate"/> and <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.LastModifiedDate"/> before apply changes in databse.

```csharp
public override int SaveChanges();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of state entrie written to the database.