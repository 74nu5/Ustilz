namespace Ustilz.Test.Models
{
    #region Usings

    using System;
    using System.Collections.Generic;

    #endregion

    public sealed class Personne
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }
    }

    public class PersonneComparer : IEqualityComparer<Personne>
    {
        /// <summary>Determines whether the specified objects are equal.</summary>
        /// <param name="x">The first object of type T to compare.</param>
        /// <param name="y">The second object of type T to compare.</param>
        /// <returns>true if the specified objects are equal; otherwise, false.</returns>
        public bool Equals(Personne x, Personne y) => x?.Nom == y?.Nom && x?.Prenom == y?.Prenom;

        /// <summary>Returns a hash code for the specified object.</summary>
        /// <param name="obj">The <see cref="object"></see> for which a hash code is to be returned.</param>
        /// <returns>A hash code for the specified object.</returns>
        /// <exception cref="ArgumentNullException">The type of <paramref name="obj">obj</paramref> is a reference type and <paramref name="obj">obj</paramref> is null.</exception>
        public int GetHashCode(Personne obj) => obj.GetHashCode();
    }
}
