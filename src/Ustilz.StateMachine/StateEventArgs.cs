namespace Ustilz.StateMachine;

using JetBrains.Annotations;

/// <summary>
///     Class which defines the state event argument.
/// </summary>
/// <typeparam name="TStateEvent">The type of state event.</typeparam>
[PublicAPI]
public sealed class StateEventArgs<TStateEvent> : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StateEventArgs{TStateEvent}" /> class.
    /// </summary>
    /// <param name="stateEvent">The state event.</param>
    public StateEventArgs(TStateEvent stateEvent)
        => this.StateEvent = stateEvent;

    /// <summary>
    ///     Gets the state event.
    /// </summary>
    public TStateEvent StateEvent { get; }
}
