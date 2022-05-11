namespace Ustilz.Time;

/// <summary>
///     Enumération de durée, à utiliser avec la méthode d'extension <see cref="ExtensionsDuration.From" />.
/// </summary>
public enum Duration
{
    /// <summary>Durée en seconde.</summary>
    Second,

    /// <summary>Durée en minute.</summary>
    Minute,

    /// <summary>Durée en heure.</summary>
    Hour,

    /// <summary>Durée en demi journée.</summary>
    HalfDay,

    /// <summary>Durée en jours.</summary>
    Day,

    /// <summary>Durée en semaine.</summary>
    Week,

    /// <summary>Durée en mois.</summary>
    Month,

    /// <summary>Durée en trimestre.</summary>
    Quarter,

    /// <summary>Durée en semestre.</summary>
    Semester,

    /// <summary>Durée en années.</summary>
    Year,

    /// <summary>Durée en décénnie.</summary>
    Decade
}