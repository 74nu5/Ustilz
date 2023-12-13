namespace Ustilz.StateMachine;

using JetBrains.Annotations;

using Ustilz.StateMachine.Abstractions.Models;

/// <summary>
///     Class which represent the state manager base.
/// </summary>
/// <typeparam name="TStateObject">The type of object which contains state value.</typeparam>
/// <typeparam name="TState">The type of state.</typeparam>
/// <typeparam name="TStateEvent">The type of state event.</typeparam>
[PublicAPI]
public abstract class StatesManager<TStateObject, TState, TStateEvent>
    where TStateObject : class, IStateObject<TState>
    where TState : Enum
    where TStateEvent : Enum
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StatesManager{TStateObject, TState, TStateEvent}" /> class.
    /// </summary>
    /// <remarks>Build transitions and set an initial state.</remarks>
    protected StatesManager()
        => this.ActiveState = this.BuildTransitionsTable();

    /// <summary>
    ///     Declare the delegate (if using non-generic pattern).
    /// </summary>
    /// <param name="stateObject">The state object.</param>
    /// <param name="eventArgs">The change argument.</param>
    public delegate void StateChangedEventHandler(TStateObject stateObject, StateEventArgs<TStateEvent> eventArgs);

    /// <summary>
    ///     Declare the state change event.
    /// </summary>
    public event StateChangedEventHandler? StateChanged;

    /// <summary>
    ///     Gets the active state.
    /// </summary>
    protected TState ActiveState { get; private set; }

    /// <summary>
    ///     Gets the transitions dictionary.
    /// </summary>
    protected Transitions<TState, TStateEvent> Transitions { get; } = new();

    /// <summary>
    ///     Method to change state of <typeparamref name="TStateObject" />.
    /// </summary>
    /// <param name="stateObject">The state object to change.</param>
    /// <param name="stateEventArgs">The state change argument.</param>
    /// <param name="cancellationToken">A token to cancel asynchronous task.</param>
    /// <returns>Returns the new state.</returns>
    public virtual async Task<TState?> ChangeStateAsync(TStateObject stateObject, StateEventArgs<TStateEvent> stateEventArgs, CancellationToken cancellationToken)
    {
        var transition = this.Transitions[this.ActiveState, stateEventArgs];
        this.ActiveState = transition.FinalState;

        // raise 'StateChanged' event
        this.StateChanged?.Invoke(stateObject, stateEventArgs);

        transition.Action?.Invoke(this, stateEventArgs);

        // if the transitional is automatic - automatically go to the next state:
        if (transition is { AutoMode: true, AutoTransition: not null })
        {
            this.ActiveState = transition.AutoTransition.InitialState;
            return await this.ChangeStateAsync(stateObject, transition.AutoTransition.EventArgs, cancellationToken).ConfigureAwait(false);
        }

        return this.ActiveState;
    }

    /// <summary>
    ///     Method to check if the requested transition is valid.
    /// </summary>
    /// <param name="eventArgs">The transition to check.</param>
    /// <returns>Returns True if transition if valid.</returns>
    public virtual bool CheckState(StateEventArgs<TStateEvent> eventArgs)
        => this.Transitions.ContainsKey(Transition<TState, TStateEvent>.GetHashCode(this.ActiveState, eventArgs));

    /// <summary>
    ///     Method to init state.
    /// </summary>
    /// <param name="stateObject">The state object.</param>
    protected void InitState(TStateObject stateObject)
        => this.ActiveState = stateObject.State;

    /// <summary>
    ///     Method where transitions table must be define.
    /// </summary>
    /// <returns>Returns the the first state.</returns>
    protected abstract TState BuildTransitionsTable();
}
