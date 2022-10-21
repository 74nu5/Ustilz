namespace Ustilz.Extensions;

using System;

using JetBrains.Annotations;

/// <summary>
/// Classe statique d'extension du type <see cref="Random"/>.
/// </summary>
[PublicAPI]
public static class ExtensionsRandom
{
    /// <summary>
    /// Méthode de sélection aléatoire dans une énumération.
    /// </summary>
    /// <typeparam name="T">Type de l'énumération.</typeparam>
    /// <param name="random">Objet <see cref="Random"/>.</param>
    /// <returns>Retourne une valeur aléatoire présente dans l'énumération.</returns>
    public static T NextEnum<T>(this Random random)
        where T : Enum
    {
        Type type = typeof(T);
        var array = Enum.GetValues(type);
        var index = random.Next(array.GetLowerBound(0), array.GetUpperBound(0) + 1);
        return (T)(array.GetValue(index) ?? throw new InvalidOperationException("Value not found."));
    }
}