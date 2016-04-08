namespace Ustilz.Arguments
{
    #region Usings

    using System;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The argument attribute.</summary>
    [PublicAPI]
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ArgumentAttribute : Attribute
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="ArgumentAttribute"/> class. Initializes a new instance of the<see cref="T:System.Attribute"/> class.</summary>
        /// <param name="key">The key.</param>
        public ArgumentAttribute(string key)
        {
            this.Key = key;
            this.IsRequired = false;
        }

        /// <summary>Initializes a new instance of the <see cref="ArgumentAttribute"/> class.</summary>
        /// <param name="key">The key.</param>
        /// <param name="isRequired">The is Required.</param>
        public ArgumentAttribute(string key, bool isRequired)
        {
            this.Key = key;
            this.IsRequired = isRequired;
        }

        #endregion

        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the key.</summary>
        public string Key { get; private set; }

        /// <summary>Gets a value indicating whether is required.</summary>
        public bool IsRequired { get; private set; }

        #endregion
    }
}