#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data](Ustilz.Data.md 'Ustilz.Data').[ADbContext](Ustilz.Data.ADbContext.md 'Ustilz.Data.ADbContext')

## ADbContext.SaveChangesAsync(CancellationToken) Method

Async method to update <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.CreationDate"/> and <seealso cref="P:Ustilz.Data.Abstractions.ITraceableDataObject.LastModifiedDate"/> before apply changes in databse.

```csharp
public override System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Ustilz.Data.ADbContext.SaveChangesAsync(System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The token for async task cancellation.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The number of state entrie written to the database.