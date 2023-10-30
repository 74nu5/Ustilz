namespace Ustilz.StateMachine;

/// <summary>
///     Represents a collection of transition objects.
/// </summary>
/// <typeparam name="TState">The state of state machine.</typeparam>
/// <typeparam name="TStateEvent">The state stateEvent of state machine.</typeparam>
public sealed class Transitions<TState, TStateEvent> : Dictionary<int, Transition<TState, TStateEvent>>
    where TState : Enum
    where TStateEvent : Enum
{
    /// <summary>
    ///     Indexer to get transitions.
    /// </summary>
    /// <param name="state">The initial state.</param>
    /// <param name="stateEvent">The state event.</param>
    /// <returns>Returns the transition if found, raises exception otherwise.</returns>
    /// <exception cref="KeyNotFoundException">
    ///     Raises an exception if the transition not found.
    ///     Call <see cref="StatesManager{TStateObject,TState,TStateEvent}.CheckState" /> to prevent this behavior.
    /// </exception>
    public Transition<TState, TStateEvent> this[TState state, StateEventArgs<TStateEvent> stateEvent]
    {
        get
        {
            try
            {
                return this[Transition<TState, TStateEvent>.GetHashCode(state, stateEvent)];
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("The given transition was not found.");
            }
        }
        init => this[Transition<TState, TStateEvent>.GetHashCode(state, stateEvent)] = value;
    }

    /// <summary>
    ///     Adds the specified transition to the collection.
    /// </summary>
    /// <param name="transition">Transition object.</param>
    /// <exception cref="System.ArgumentNullException">Key is null.</exception>
    /// <exception cref="System.ArgumentException">An transition with the same key already exists.</exception>
    public void Add(Transition<TState, TStateEvent> transition)
    {
        // The Add method throws an exception if the new key is already in the dictionary.
        try
        {
            this.Add(transition.GetHashCode(), transition);
        }
        catch (ArgumentException)
        {
            throw new ArgumentException($"A transition with the key (Initials state {transition.InitialState}, Event {transition.EventArgs}) already exists.");
        }
    }

    /// <summary>
    ///     Method to remove transition, if needed.
    /// </summary>
    /// <param name="state">The initial state.</param>
    /// <param name="stateEvent">The state event.</param>
    /// <returns>Returns True if transition removed successfully.</returns>
    public bool Remove(TState state, StateEventArgs<TStateEvent> stateEvent)
        => this.Remove(Transition<TState, TStateEvent>.GetHashCode(state, stateEvent));
}
