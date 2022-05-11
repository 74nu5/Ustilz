namespace Ustilz.Attributes;

using System;

using JetBrains.Annotations;

/// <summary>The use for deserialization attribute.</summary>
[MeansImplicitUse]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class UsedByInjectionAttribute : Attribute
{
    /// <summary>Initialise une nouvelle instance de la classe <see cref="UsedByInjectionAttribute" />. .</summary>
    public UsedByInjectionAttribute()
        : this(ImplicitUseKindFlags.Default)
    {
    }

    /// <summary>Initialise une nouvelle instance de la classe <see cref="UsedByInjectionAttribute" />.</summary>
    /// <param name="targetFlags">The target flags.</param>
    public UsedByInjectionAttribute(ImplicitUseTargetFlags targetFlags)
        : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    /// <summary>Initialise une nouvelle instance de la classe <see cref="UsedByInjectionAttribute" />.</summary>
    /// <param name="useKindFlags">The use kind flags.</param>
    /// <param name="targetFlags">The target flags.</param>
    public UsedByInjectionAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags = ImplicitUseTargetFlags.Default)
    {
        this.UseKindFlags = useKindFlags;
        this.TargetFlags = targetFlags;
    }

    /// <summary>Obtient the target flags.</summary>
    /// <value>The target flags.</value>
    [UsedImplicitly]
    public ImplicitUseTargetFlags TargetFlags { get; private set; }

    /// <summary>Obtient the use kind flags.</summary>
    /// <value>The use kind flags.</value>
    [UsedImplicitly]
    public ImplicitUseKindFlags UseKindFlags { get; private set; }
}