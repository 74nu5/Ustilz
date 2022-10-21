namespace Ustilz.Sample.Api.Modules;

using System.Net;

using JetBrains.Annotations;

using Microsoft.Extensions.DependencyInjection.Extensions;

using Ustilz.Api.ApiResponse;
using Ustilz.Api.ApiResponse.Extensions;
using Ustilz.Api.Minimal.Modules;
using Ustilz.Sample.Api.Services;

[UsedImplicitly]
public sealed class TodoModule : IModule
{
    /// <summary>
    ///     Registers the module depedencies.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configuration">The configuration service manager.</param>
    /// <returns>
    ///     The service collection with all dependencies added.
    /// </returns>
    public void RegisterModule(IServiceCollection services, IConfiguration configuration)
    {
        services.TryAddTransient<TodoService>();
        services.AddSqlite<TodoDb>("Filename=Ustilz.db");
    }

    /// <summary>
    ///     Configure module dependencies once service provider has been built.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    public void ConfigureModule(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        scope.ServiceProvider.GetRequiredService<TodoDb>()
             .Database.EnsureCreated();
    }

    /// <summary>
    ///     Maps incoming requests to the specified services types declared by the module.
    /// </summary>
    /// <param name="endpoints">The route builder.</param>
    public void MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/todos", GetTodos)
                 .Produces<Todo[]>();

        endpoints.MapGet("/todos/{id:int}", GetTodo)
                 .ProducesApiResponse<Todo>()
                 .Produces(404);

        endpoints.MapPost("/todos", CreateTodo)
                 .ProducesApiResponse<Todo>()
                 .ProducesApiResponse<Todo>(HttpStatusCode.Conflict)
                 .Produces(404);

        endpoints.MapPut("/todos/{id:int}", UpdateTodo)
                 .Produces(204)
                 .Produces(400)
                 .Produces(404);
    }

    private static async Task<IResult> CreateTodo(ApiRequestHeaders headers, TodoService todoService, Todo todo)
    {
        if (await todoService.ExistsTodoAsync(todo.Id))
            return Results.Extensions.Conflict(headers, todo);

        if (todo.Title.Length > 100)
            return Results.Extensions.BadRequest(headers, "Title must be less than 100 characters");

        var t = await todoService.CreateTodoAsync(headers, todo);

        return Results.Extensions.Created<Todo>(headers, $"/todos/{t.Id}");
    }

    private static async Task<IResult> UpdateTodo(ApiRequestHeaders headers, TodoService todoService, int id, Todo todo)
    {
        if (id < -1)
            return Results.Extensions.BadRequest(headers);

        var existingTodo = await todoService.ExistsTodoAsync(id);

        if (!existingTodo)
            return Results.Extensions.NotFound(headers);

        await todoService.UpdateTodoAsync(id, todo);

        return Results.Extensions.NoContent(headers);
    }

    private static IResult GetTodo(ApiRequestHeaders headers, int id, TodoService todoService)
        => todoService.GetTodo(id) is { } todo
               ? Results.Extensions.Ok(headers, todo)
               : Results.Extensions.NotFound(headers);

    private static async Task<IResult> GetTodos(ApiRequestHeaders headers, TodoService todoService)
        => Results.Extensions.Ok(headers, await todoService.GetAllTodosAsync());
}
