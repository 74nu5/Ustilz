namespace Ustilz.StateMachine.Abstractions.Models;

using JetBrains.Annotations;

/// <summary>
///     Interface which defines which property must have a state object.
/// </summary>
/// <typeparam name="TState">The type of state.</typeparam>
[PublicAPI]
public interface IStateObject<out TState>
{
    /// <summary>
    ///     Gets the state of object.
    /// </summary>
    TState State { get; }
}
