namespace Ustilz.Extensions.Models
{
    #region Usings

    using System;

    #endregion

    /// <summary>The ExecutionResult interface.</summary>
    /// <typeparam name="T">Type du résultat.</typeparam>
    public interface IExecutionResult<T>
    {
        /// <summary>Obtient ou définit l'exception.</summary>
        /// <value>The exception.</value>
        Exception? Exception { get; set; }

        /// <summary>Obtient ou définit le result.</summary>
        /// <value>The result.</value>
        T Result { get; set; }
    }
}
