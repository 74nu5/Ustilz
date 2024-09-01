namespace Ustilz.Sample.Api;

using System.ComponentModel.DataAnnotations;

public sealed class Todo
{
    public int Id { get; set; }

    public bool IsComplete { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = string.Empty;
}
