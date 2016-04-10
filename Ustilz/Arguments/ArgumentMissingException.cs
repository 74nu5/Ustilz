namespace Ustilz.Arguments
{
    #region Usings

    using System;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The argument missing exception. </summary>
    [PublicAPI]
    public sealed class ArgumentMissingException : Exception
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="ArgumentMissingException"/> class. </summary>
        /// <param name="message">The message that describes the error. </param>
        public ArgumentMissingException(string message)
            : base(message)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ArgumentMissingException"/> class with a specified
        ///     error message and a
        ///     reference to the inner exception that is the cause of this exception.</summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in
        ///     Visual Basic) if no inner exception is specified.</param>
        public ArgumentMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        #endregion
    }
}