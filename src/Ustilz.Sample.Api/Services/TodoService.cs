namespace Ustilz.Sample.Api.Services;

using Microsoft.EntityFrameworkCore;

using Ustilz.Models;

public class TodoService
{
    private readonly TodoDb db;

    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public TodoService(TodoDb db)
        => this.db = db;

    public async Task<Todo> CreateTodoAsync(ServiceMonitoringDefinition serviceMonitoringDefinition, Todo todo)
    {
        this.db.Todos.Add(todo);
        await this.db.SaveChangesAsync();

        return todo;
    }

    public async Task<Todo[]> GetAllTodosAsync()
        => await this.db.Todos.ToArrayAsync();

    public async Task<Todo?> GetTodo(int id)
        => await this.db.Todos.FindAsync(id);

    public async Task<bool> ExistsTodoAsync(int id)
        => await this.db.Todos.AnyAsync(todo => todo.Id == id);

    public async Task<Todo?> UpdateTodoAsync(int id, Todo todo)
    {
        var existingTodo = await this.db.Todos.FindAsync(id);

        if (existingTodo is null)
        {
            return null;
        }

        existingTodo.Title = todo.Title;
        existingTodo.IsComplete = todo.IsComplete;

        await this.db.SaveChangesAsync();

        return todo;
    }
}
