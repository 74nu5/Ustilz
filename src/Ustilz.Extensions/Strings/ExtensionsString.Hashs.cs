namespace Ustilz.Extensions.Strings;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;

using Ustilz.Extensions.Enumerables;
using Ustilz.Time;
using Ustilz.Utils;

/// <summary>The extensions string.</summary>
public static partial class ExtensionsString
{
    /// <summary>The hash providers.</summary>
    private static readonly Dictionary<HashType, HashAlgorithm> HashProviders = new ();

    /// <summary>The random.</summary>
    private static readonly Random Random = new ((int)Clock.Now.Ticks);

    /// <summary>Supported hash algorithms.</summary>
    public enum HashType
    {
        /// <summary>The m d 5.</summary>
        MD5,

        /// <summary>The sh a 1.</summary>
        SHA1,

        /// <summary>The sh a 256.</summary>
        SHA256,

        /// <summary>The sh a 384.</summary>
        SHA384,

        /// <summary>The sh a 512.</summary>
        SHA512
    }

    /// <summary>Computes the hash of the string using a specified hash algorithm.</summary>
    /// <param name="input">The string to hash.</param>
    /// <param name="hashType">The hash algorithm to use.</param>
    /// <returns>The resulting hash or an empty string on error.</returns>
    public static string ComputeHash(this string input, HashType hashType)
    {
        try
        {
            var hash = GetHash(input, hashType);
            var ret = new StringBuilder();

            foreach (var t in hash)
            {
                ret.Append(t.ToString("x2", CultureInfo.CurrentCulture));
            }

            return ret.ToString();
        }
        catch
        {
            return string.Empty;
        }
    }

    /// <summary>The decrypt.</summary>
    /// <param name="stringToDecrypt">The string to decrypt.</param>
    /// <param name="key">The key.</param>
    /// <returns>The <see cref="string" />.</returns>
    [Pure]
    [SupportedOSPlatform("windows")]
    public static string Decrypt(this string stringToDecrypt, string key)
    {
        if (string.IsNullOrEmpty(stringToDecrypt) || string.IsNullOrEmpty(key))
        {
            throw new ArgumentException("Empty input or key are not allowed.");
        }

        var cspp = new CspParameters { KeyContainerName = key };
        using var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };

        var decryptArray = stringToDecrypt.Split(new[] { "-" }, StringSplitOptions.None);
        var decryptByteArray = decryptArray.Select(s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber, CultureInfo.CurrentCulture))).ToArray();
        var bytes = rsa.Decrypt(decryptByteArray, true);

        return Encoding.UTF8.GetString(bytes);
    }

    /// <summary>The encrypt.</summary>
    /// <param name="stringToEncrypt">The string to encrypt.</param>
    /// <param name="key">The key.</param>
    /// <returns>The <see cref="string" />.</returns>
    [Pure]
    [SupportedOSPlatform("windows")]
    public static string Encrypt(this string stringToEncrypt, string key)
    {
        if (string.IsNullOrEmpty(stringToEncrypt))
        {
            throw new ArgumentException("An empty string value cannot be encrypted.");
        }

        if (string.IsNullOrEmpty(key))
        {
            throw new ArgumentException("Cannot encrypt using an empty key. Please supply an encryption key.");
        }

        var cspp = new CspParameters { KeyContainerName = key };
        using var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
        var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(stringToEncrypt), true);

        return BitConverter.ToString(bytes);
    }

    /// <summary>The generate hash.</summary>
    /// <param name="password">The password.</param>
    /// <param name="salt">The salt.</param>
    /// <param name="provider">The provider.</param>
    /// <returns>The <see cref="string" />.</returns>
    /// <exception cref="NotSupportedException">Throws an exception when the hash type is unknown.</exception>
    [SuppressMessage("ReSharper", "FlagArgument", Justification = "Not flag.")]
    public static string GenerateHash(string password, string? salt = null, HashType provider = HashType.MD5)
    {
        Check.NotEmpty(password, nameof(password));

        salt ??= GenerateSalt();

        var bytes = Encoding.Unicode.GetBytes(salt + password);

        if (!HashProviders.ContainsKey(provider))
        {
            throw new NotSupportedException($"Hash Provider '{provider}' is not supported");
        }

        var hash = HashProviders[provider].ComputeHash(bytes);
        return provider + "$" + salt + "$" + hash.ToHexString();
    }

    /// <summary>Generate random string to be used as passwords and salts.</summary>
    /// <returns>Base 64 random string.</returns>
    public static string GeneratePassword()
    {
        var randomNumber = Random.Next(5000, int.MaxValue);
        return Convert.ToBase64String(Encoding.Unicode.GetBytes(randomNumber.ToString(CultureInfo.CurrentCulture)));
    }

    /// <summary>Random salt to comsume in hash generation.</summary>
    /// <param name="length">Length of salt value should be even, hex string will be twice of the length.</param>
    /// <returns>Hex string representation of salt value.</returns>
    public static string GenerateSalt(int length = 4)
        => GenerateSaltBytes(length).ToHexString();

    /// <summary>Random salt to comsume in hash generation.</summary>
    /// <param name="length">Length of salt value should be even, hex string will be twice of the length.</param>
    /// <returns>Bytes representation of salt value.</returns>
    public static byte[] GenerateSaltBytes(int length = 16)
    {
        var salt = new byte[length];
        Random.NextBytes(salt);

        return salt;
    }

    /// <summary>Validate password is equal to hashValue(Generated from Compute hash).</summary>
    /// <param name="hashValue">Computed hash value of actual password 'MD5$Salt$Hash'.</param>
    /// <param name="password">Password to validate against hash value.</param>
    /// <returns>True if password is equal to the hash value.</returns>
    public static bool Validate(string hashValue, string password)
    {
        if (string.IsNullOrEmpty(hashValue))
        {
            throw new ArgumentException($@"{nameof(hashValue)}' parameter is null.", nameof(hashValue));
        }

        Check.NotEmpty(hashValue, nameof(hashValue));

        var hashParts = hashValue.Split('$');
        if (hashParts.Length != 3)
        {
            throw new ArgumentException(
                                        "hashValue is not valid, it should contain hash algorithm, salt and hash value seperated by '$' e.g 'MD5$F8F25518$23C1916FF7C0A35166BEBCE564D19586'");
        }

        HashType provider;
        var salt = hashParts[1];

        try
        {
            provider = hashParts[0].ToEnum<HashType>();
        }
        catch (Exception ex)
        {
            throw new ArgumentException($"Invalid Hash Provider '{hashValue[0]}'", ex);
        }

        return hashValue == GenerateHash(password, salt, provider);
    }

    /// <summary>The get hash.</summary>
    /// <param name="input">The input.</param>
    /// <param name="hash">The hash.</param>
    /// <returns>The <see cref="byte" />.</returns>
    [SuppressMessage("Security", "CA5351:Ne pas utiliser d'algorithmes de chiffrement cassés", Justification = "Ca peut toujours servir.")]
    [SuppressMessage("Security", "CA5350:Ne pas utiliser d'algorithmes de chiffrement faibles", Justification = "Ca peut toujours servir.")]
    private static byte[] GetHash(string input, HashType hash)
    {
        var inputBytes = Encoding.ASCII.GetBytes(input);
        HashAlgorithm algo;
        switch (hash)
        {
            case HashType.MD5:
                algo = MD5.Create();
                break;
            case HashType.SHA1:
                algo = SHA1.Create();
                break;
            case HashType.SHA256:
                algo = SHA256.Create();
                break;
            case HashType.SHA384:
                algo = SHA384.Create();
                break;
            case HashType.SHA512:
                algo = SHA512.Create();
                break;
            default:
                return inputBytes;
        }

        using (algo)
        {
            return algo.ComputeHash(inputBytes);
        }
    }
}
