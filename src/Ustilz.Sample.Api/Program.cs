using System.Net;

using Microsoft.EntityFrameworkCore;

using Ustilz.Api.ApiResponse;
using Ustilz.Api.ApiResponse.Results.Extensions;
using Ustilz.Sample.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<TodoDb>("Filename=Ustilz.db");

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<TodoService>();

var app = builder.Build();

using var scope = app.Services.CreateScope();
scope.ServiceProvider.GetRequiredService<TodoDb>().Database.EnsureCreated();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapTodosApi();

app.Run();

public static class TodosApi
{
    public static IEndpointRouteBuilder MapTodosApi(this IEndpointRouteBuilder routes)
    {
        routes.MapGet(
                   "/todos",
                   async (ApiRequestHeaders headers, TodoService todoService)
                       => Results.Extensions.Ok(headers, await todoService.GetAllTodosAsync()))
              .Produces<Todo[]>();

        routes.MapGet(
                   "/todos/{id:int}",
                   (ApiRequestHeaders headers, int id, TodoService todoService)
                       => todoService.GetTodo(id) is { } todo
                              ? Results.Extensions.Ok(headers, todo)
                              : Results.Extensions.NotFound(headers))
              .ProducesApiResponse<Todo>()
              .Produces(404);

        routes.MapPost(
                   "/todos",
                   async (ApiRequestHeaders headers, TodoService todoService, Todo todo) =>
                   {
                       if (await todoService.ExistsTodoAsync(todo.Id))
                       {
                           return Results.Extensions.Conflict(headers, todo);
                       }

                       if (todo.Title.Length > 100)
                       {
                           return Results.Extensions.BadRequest(headers, "Title must be less than 100 characters");
                       }
                       
                       var t = await todoService.CreateTodoAsync(headers, todo);
                       return Results.Extensions.Created<Todo>(headers, $"/todos/{t.Id}");
                   })
              .ProducesApiResponse<Todo>()
              .ProducesApiResponse<Todo>(HttpStatusCode.Conflict)
              .Produces(404);

        routes.MapPut(
                   "/todos/{id}",
                   async (ApiRequestHeaders headers, TodoService todoService, int id, Todo todo)
                       =>
                   {
                       if (id < -1)
                       {
                           return Results.Extensions.BadRequest(headers);
                       }

                       var existingTodo = await todoService.ExistsTodoAsync(id);

                       if (!existingTodo)
                       {
                           return Results.Extensions.NotFound(headers);
                       }

                       await todoService.UpdateTodoAsync(id, todo);

                       return Results.Extensions.NoContent(headers);
                   })
              .Produces(204)
              .Produces(400)
              .Produces(404);

        return routes;
    }
}

public class Todo
{
    public int Id { get; set; }

    public bool IsComplete { get; set; }

    public string Title { get; set; } = string.Empty;
}

public class TodoDb : DbContext
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="T:Microsoft.EntityFrameworkCore.DbContext" /> class using the specified options.
    ///     The <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" /> method will still be called to allow further
    ///     configuration of the options.
    /// </summary>
    /// <remarks>
    ///     See <see href="https://aka.ms/efcore-docs-dbcontext">DbContext lifetime, configuration, and initialization</see> and
    ///     <see href="https://aka.ms/efcore-docs-dbcontext-options">Using DbContextOptions</see> for more information and examples.
    /// </remarks>
    /// <param name="options">The options for this context.</param>
    public TodoDb(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Todo> Todos => this.Set<Todo>();
}
