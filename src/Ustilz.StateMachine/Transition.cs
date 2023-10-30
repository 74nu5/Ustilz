namespace Ustilz.StateMachine;

using JetBrains.Annotations;

/// <summary>
///     Method which represent a transition in state machine.
/// </summary>
/// <typeparam name="TState">The type of state.</typeparam>
/// <typeparam name="TStateEvent">The type of state event.</typeparam>
[PublicAPI]
public sealed class Transition<TState, TStateEvent>
    where TState : Enum
    where TStateEvent : Enum
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Transition{TState, TStateEvent}" /> class.
    /// </summary>
    /// <param name="initialState">The initial state of transition.</param>
    /// <param name="stateEventArgs">The state event argument.</param>
    /// <param name="finalState">The final state of transition.</param>
    /// <param name="action">The action to perform on transition.</param>
    public Transition(TState initialState, StateEventArgs<TStateEvent> stateEventArgs, TState finalState, StateAction action)
    {
        this.InitialState = initialState;
        this.EventArgs = stateEventArgs;
        this.FinalState = finalState;
        this.Action = action;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Transition{TState, TStateEvent}" /> class.
    /// </summary>
    /// <param name="initialState">The initial state of transition.</param>
    /// <param name="stateEventArgs">The state event argument.</param>
    /// <param name="finalState">The final state of transition.</param>
    /// <param name="action">The action to perform on transition.</param>
    /// <param name="autoMode">Set this transition to auto mode.</param>
    /// <param name="autoTransition">Set the next transition when <seealso cref="AutoMode" /> is True.</param>
    public Transition(TState initialState, StateEventArgs<TStateEvent> stateEventArgs, TState finalState, StateAction action, bool autoMode, Transition<TState, TStateEvent>? autoTransition)
        : this(initialState, stateEventArgs, finalState, action)
    {
        this.AutoMode = autoMode;
        this.AutoTransition = autoTransition;
    }

    /// <summary>
    ///     Defines a delegate to state actions.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="eventArgs">The evenet arguments.</param>
    public delegate void StateAction(object sender, StateEventArgs<TStateEvent> eventArgs);

    /// <summary>
    ///     Gets the initiale state of transition.
    /// </summary>
    public TState InitialState { get; }

    /// <summary>
    ///     Gets the event args.
    /// </summary>
    public StateEventArgs<TStateEvent> EventArgs { get; }

    /// <summary>
    ///     Gets the final state of transtion.
    /// </summary>
    public TState FinalState { get; }

    /// <summary>
    ///     Gets the transition action.
    /// </summary>
    public StateAction? Action { get; }

    /// <summary>
    ///     Gets a value indicating whether the transition is in auto mode.
    /// </summary>
    public bool AutoMode { get; }

    /// <summary>
    ///     Gets the next transition perform when the current transition is in auto mode.
    /// </summary>
    public Transition<TState, TStateEvent>? AutoTransition { get; }

    /// <summary>
    ///     Method to get transition hash code.
    /// </summary>
    /// <param name="state">The initial state of transition.</param>
    /// <param name="stateEventArgs">The transition state event.</param>
    /// <returns>Returns the transition hash code.</returns>
    public static int GetHashCode(TState state, StateEventArgs<TStateEvent> stateEventArgs)
        => (state.GetHashCode() << 8) + stateEventArgs.StateEvent.GetHashCode();

    /// <inheritdoc />
    public override int GetHashCode()
        => GetHashCode(this.InitialState, this.EventArgs);
}
