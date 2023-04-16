namespace Ustilz.Sample.Api;

public sealed class Todo
{
    public int Id { get; set; }

    public bool IsComplete { get; set; }

    public string Title { get; set; } = string.Empty;
}
