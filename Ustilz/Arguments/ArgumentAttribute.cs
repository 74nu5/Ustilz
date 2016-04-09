namespace Ustilz.Arguments
{
    #region Usings

    using System;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The argument attribute. </summary>
    [PublicAPI]
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ArgumentAttribute : Attribute
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="ArgumentAttribute" /> class.</summary>
        /// <param name="key">The key.</param>
        /// <param name="isRequired">The is Required.</param>
        public ArgumentAttribute(string key, bool isRequired = false)
        {
            this.Key = key;
            this.IsRequired = isRequired;
        }

        #endregion

        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the key.</summary>
        /// <value>The key.</value>
        public string Key { get; }

        /// <summary>Gets a value indicating whether is required.</summary>
        /// <value>The is required.</value>
        public bool IsRequired { get; }

        #endregion
    }
}