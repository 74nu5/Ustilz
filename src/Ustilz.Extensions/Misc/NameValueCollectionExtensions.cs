namespace Ustilz.Extensions.Misc;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

using JetBrains.Annotations;

/// <summary>The extensions name value collection.</summary>
[PublicAPI]
public static class NameValueCollectionExtensions
{
    extension(NameValueCollection? nvc)
    {
        /// <summary>The to dictionary.</summary>
        /// <returns>The Dictionary{string, string}.</returns>
        /// <exception cref="ArgumentNullException">nvc is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">keySelector produces duplicate keys for two elements.</exception>
        /// <exception cref="NotSupportedException">The collection is read-only and the operation attempts to modify the collection.</exception>
        public Dictionary<string, string> ToDictionary()
            => nvc is null
                   ? throw new ArgumentNullException(nameof(nvc))
                   : nvc.AllKeys.ToDictionary(k => k ?? throw new InvalidOperationException("Name is null"), k => nvc[k] ?? throw new InvalidOperationException("Value is null"));
    }
}
