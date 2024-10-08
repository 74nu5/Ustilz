namespace Ustilz.Razor.Components;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Components;

using Ustilz.Razor.Utils;

/// <summary>
///     Base class of razor compenents.
/// </summary>
[PublicAPI]
public abstract class BaseComponent : ComponentBase
{
    /// <summary>
    ///     Initialise une nouvelle instance de la classe <see cref="BaseComponent" />.
    /// </summary>
    protected BaseComponent()
    {
        this.ClassMapper.Add(() => this.Class);

        this.StyleMapper.Add(() => this.Style);
    }

    /// <summary>
    ///     Obtient ou définit un ou plusieurs nom de classe pour un élément du DOM.
    /// </summary>
    [Parameter]
    public string Class { get; set; } = string.Empty;

    /// <summary>
    ///     Obtient ou définit un style en ligne pour un élément du DOM.
    /// </summary>
    [Parameter]
    public string Style { get; set; } = string.Empty;

    /// <summary>
    ///     Obtient ou définit la classe de mapping des classes CSS.
    /// </summary>
    protected ClassMapper ClassMapper { get; set; } = new();

    /// <summary>
    ///     Obtient ou définit la classe de mapping des styles CSS.
    /// </summary>
    protected StyleMapper StyleMapper { get; set; } = new();

    /// <summary>
    ///     Method which invoke the <see cref="ComponentBase.StateHasChanged" />.
    /// </summary>
    protected void InvokeStateHasChanged() => this.InvokeAsync(this.StateHasChanged);
}
