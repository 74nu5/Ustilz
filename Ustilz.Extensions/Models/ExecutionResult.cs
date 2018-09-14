namespace Ustilz.Extensions.Models
{
    #region Usings

    using System;

    #endregion

    /// <summary>The execution result.</summary>
    /// <typeparam name="T">Type du résultat</typeparam>
    public class ExecutionResult<T> : IExecutionResult<T>
    {
        #region Propriétés et indexeurs

        /// <summary>Gets or sets the exception.</summary>
        /// <value>The exception.</value>
        public Exception Exception { get; set; }

        /// <summary>Gets or sets the result.</summary>
        /// <value>The result.</value>
        public T Result { get; set; }

        #endregion
    }
}
