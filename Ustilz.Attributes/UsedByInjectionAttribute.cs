namespace Ustilz.Attributes
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The use for deserialization attribute.</summary>
    [MeansImplicitUse]
    public sealed class UsedByInjectionAttribute : Attribute
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="UsedByInjectionAttribute" /> class.</summary>
        public UsedByInjectionAttribute()
            : this(ImplicitUseKindFlags.Default)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="UsedByInjectionAttribute" /> class.</summary>
        /// <param name="targetFlags">The target flags.</param>
        public UsedByInjectionAttribute(ImplicitUseTargetFlags targetFlags)
            : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="UsedByInjectionAttribute" /> class.</summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        /// <param name="targetFlags">The target flags.</param>
        public UsedByInjectionAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags = ImplicitUseTargetFlags.Default)
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
