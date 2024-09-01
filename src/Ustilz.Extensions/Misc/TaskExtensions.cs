namespace Ustilz.Extensions.Misc;

using System.Runtime.CompilerServices;

using JetBrains.Annotations;

/// <summary>
/// Classe statique d'extension du type <see cref="Task"/>.
/// </summary>
[PublicAPI]
public static class TaskExtensions
{
    /// <summary>
    /// Méthode d'extension permettant d'attendre la fin de l'exécution d'un tuple de deux tâches sans résultats.
    /// </summary>
    /// <typeparam name="T1">Type de la première tâche.</typeparam>
    /// <typeparam name="T2">Type de la deuxième tâche.</typeparam>
    /// <param name="tuple">Tuple de tâches.</param>
    /// <returns><see cref="TaskAwaiter{TResult}"/> contenant le résultat du tuple de tâches.</returns>
    public static TaskAwaiter GetAwaiter<T1, T2>(this (Task, Task) tuple)
    {
        async Task Core()
        {
            var (task1, task2) = tuple;
            await Task.WhenAll(task1, task2);
        }

        return Core().GetAwaiter();
    }

    /// <summary>
    /// Méthode d'extension permettant d'attendre la fin de l'exécution d'un tuple de deux tâches.
    /// </summary>
    /// <typeparam name="T1">Type de la première tâche.</typeparam>
    /// <typeparam name="T2">Type de la deuxième tâche.</typeparam>
    /// <param name="tuple">Tuple de tâches.</param>
    /// <returns><see cref="TaskAwaiter{TResult}"/> contenant le résultat du tuple de tâches.</returns>
    public static TaskAwaiter<(T1, T2)> GetAwaiter<T1, T2>(this (Task<T1>, Task<T2>) tuple)
    {
        async Task<(T1, T2)> Core()
        {
            var (task1, task2) = tuple;
            await Task.WhenAll(task1, task2);
            return (task1.Result, task2.Result);
        }

        return Core().GetAwaiter();
    }

    /// <summary>
    /// Méthode d'extension permettant d'attendre la fin de l'exécution d'un tuple de trois tâches.
    /// </summary>
    /// <typeparam name="T1">Type de la première tâche.</typeparam>
    /// <typeparam name="T2">Type de la deuxième tâche.</typeparam>
    /// <typeparam name="T3">Type de la troisième tâche.</typeparam>
    /// <param name="tuple">Tuple de tâches.</param>
    /// <returns><see cref="TaskAwaiter{TResult}"/> contenant le résultat du tuple de tâches.</returns>
    public static TaskAwaiter<(T1, T2, T3)> GetAwaiter<T1, T2, T3>(this (Task<T1>, Task<T2>, Task<T3>) tuple)
    {
        async Task<(T1, T2, T3)> Core()
        {
            var (task1, task2, task3) = tuple;
            await Task.WhenAll(task1, task2, task3);
            return (task1.Result, task2.Result, task3.Result);
        }

        return Core().GetAwaiter();
    }
}
