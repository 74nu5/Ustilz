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

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="UsedByInjectionAttribute"/>.
        /// .</summary>
        public UsedByInjectionAttribute()
            : this(ImplicitUseKindFlags.Default)
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="UsedByInjectionAttribute"/>.
        /// </summary>
        /// <param name="targetFlags">The target flags.</param>
        public UsedByInjectionAttribute(ImplicitUseTargetFlags targetFlags)
            : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="UsedByInjectionAttribute"/>.
        /// </summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        /// <param name="targetFlags">The target flags.</param>
        public UsedByInjectionAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags = ImplicitUseTargetFlags.Default)
        {
            this.UseKindFlags = useKindFlags;
            this.TargetFlags = targetFlags;
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Obtient the target flags.</summary>
        /// <value>The target flags.</value>
        [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; private set; }

        /// <summary>Obtient the use kind flags.</summary>
        /// <value>The use kind flags.</value>
        [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; private set; }

        #endregion
    }
}
