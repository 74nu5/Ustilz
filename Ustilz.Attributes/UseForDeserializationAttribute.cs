namespace Ustilz.Attributes
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The use for deserialization attribute.</summary>
    [MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
    public sealed class UseForDeserializationAttribute : Attribute
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="UseForDeserializationAttribute" /> class.</summary>
        public UseForDeserializationAttribute()
            : this(ImplicitUseKindFlags.Default)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="UseForDeserializationAttribute" /> class.</summary>
        /// <param name="targetFlags">The target flags.</param>
        public UseForDeserializationAttribute(ImplicitUseTargetFlags targetFlags)
            : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="UseForDeserializationAttribute" /> class.</summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        /// <param name="targetFlags">The target flags.</param>
        public UseForDeserializationAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags = ImplicitUseTargetFlags.Default)
        {
            this.UseKindFlags = useKindFlags;
            this.TargetFlags = targetFlags;
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Gets the target flags.</summary>
        /// <value>The target flags.</value>
        [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; private set; }

        /// <summary>Gets the use kind flags.</summary>
        /// <value>The use kind flags.</value>
        [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; private set; }

        #endregion
    }
}
