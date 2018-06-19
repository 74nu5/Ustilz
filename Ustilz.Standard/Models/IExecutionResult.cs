namespace Ustilz.Models
{
    #region Usings

    using System;

    #endregion

    /// <summary>The ExecutionResult interface.</summary>
    /// <typeparam name="T">Type du resultat</typeparam>
    public interface IExecutionResult<T>
    {
        #region Propriétés et indexeurs

        /// <summary>Gets or sets the exception.</summary>
        /// <value>The exception.</value>
        Exception Exception { get; set; }

        /// <summary>Gets or sets the result.</summary>
        /// <value>The result.</value>
        T Result { get; set; }

        #endregion
    }
}