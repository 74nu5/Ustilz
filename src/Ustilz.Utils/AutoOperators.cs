namespace Ustilz.Utils
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>A base class that automatically provides all operator overloads based on your class only implementing CompareTo.</summary>
    [PublicAPI]
    public abstract class AutoOperators : IComparable
    {
        /// <summary>Operator equals.</summary>
        /// <param name="obj1">First object to compare.</param>
        /// <param name="obj2">Second object to compare.</param>
        /// <returns>Return true if the both objects are equals, false otherwise.</returns>
        public static bool operator ==(AutoOperators? obj1, AutoOperators? obj2)
            => Compare(obj1, obj2) == 0;

        /// <summary>Operator greater than.</summary>
        /// <param name="obj1">First object to compare.</param>
        /// <param name="obj2">Second object to compare.</param>
        /// <returns>Return true if obj1 is greater than obj2, false otherwise.</returns>
        public static bool operator >(AutoOperators? obj1, AutoOperators? obj2)
            => Compare(obj1, obj2) > 0;

        /// <summary>Operator greater than or equals.</summary>
        /// <param name="obj1">First object to compare.</param>
        /// <param name="obj2">Second object to compare.</param>
        /// <returns>Return true if obj1 is greater than or equals obj2, false otherwise.</returns>
        public static bool operator >=(AutoOperators? obj1, AutoOperators? obj2)
            => Compare(obj1, obj2) >= 0;

        /// <summary>Operator not equals.</summary>
        /// <param name="obj1">First object to compare.</param>
        /// <param name="obj2">Second object to compare.</param>
        /// <returns>Return true if obj1 is greater than obj2, false otherwise.</returns>
        public static bool operator !=(AutoOperators? obj1, AutoOperators? obj2)
            => Compare(obj1, obj2) != 0;

        /// <summary>Operator less than.</summary>
        /// <param name="obj1">First object to compare.</param>
        /// <param name="obj2">Second object to compare.</param>
        /// <returns>Return true if obj1 is less than obj2, false otherwise.</returns>
        public static bool operator <(AutoOperators? obj1, AutoOperators? obj2)
            => Compare(obj1, obj2) < 0;

        /// <summary>Operator less than or equals.</summary>
        /// <param name="obj1">First object to compare.</param>
        /// <param name="obj2">Second object to compare.</param>
        /// <returns>Return true if obj1 is less than or equals obj2, false otherwise.</returns>
        public static bool operator <=(AutoOperators? obj1, AutoOperators? obj2)
            => Compare(obj1, obj2) <= 0;

        /// <summary>Comparaison method by référence.</summary>
        /// <param name="obj1">First object to compare.</param>
        /// <param name="obj2">Second object to compare.</param>
        /// <returns>Return true if the both objects are equals, false otherwise.</returns>
        public static int Compare(AutoOperators? obj1, AutoOperators? obj2)
            => ReferenceEquals(obj1, obj2) ? 0 : obj1 is null ? -1 : obj2 is null ? 1 : obj1.CompareTo(obj2);

        /// <inheritdoc />
        public abstract int CompareTo(object? obj);

        /// <inheritdoc />
        public override bool Equals(object? obj)
            => obj is AutoOperators operators && this == operators;

        /// <inheritdoc />
        public abstract override int GetHashCode();
    }
}
