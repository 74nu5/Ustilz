namespace Ustilz.Extensions.Configuration;

using System;
using System.IO;

using JetBrains.Annotations;

using Microsoft.Extensions.Configuration;

/// <summary>The extensions configuration builder.</summary>
[PublicAPI]
public static class ExtensionsConfigurationBuilder
{
    extension(IConfigurationBuilder builder)
    {
        /// <summary>The use app settings json.</summary>
        /// <exception cref="ArgumentNullException">Lève une exception lorsque la variable d'environnement ASPNETCORE_ENVIRONMENT n'est pas trouvée.</exception>
        /// <returns>The <see cref="IConfigurationBuilder" />.</returns>
        /// <exception cref="ArgumentException">path1, path2, or path3 contains one or more of the invalid characters defined in <see cref="System.IO.Path.GetInvalidPathChars"></see>.</exception>
        public IConfigurationBuilder UseAppSettingsJson()
        {
            // Set up configuration sources.
            builder.AddJsonFile("appsettings.json", true);
            builder.AddJsonFile(
                                Path.Combine(
                                             AppContext.BaseDirectory,
                                             $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}",
                                             "appsettings.Development.json"),
                                true);

            return builder;
        }
    }
}