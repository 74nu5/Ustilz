namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Globalization;
    using System.Security.Cryptography;
    using System.Text;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The extensions string.</summary>
    [PublicAPI]
    public static class ExtensionsString
    {
        /// <summary>The encrypt.</summary>
        /// <param name="stringToEncrypt">The string to encrypt.</param>
        /// <param name="key">The key.</param>
        /// <returns>The <see cref="string"/>.</returns>
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
            var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
            var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(stringToEncrypt), true);

            return BitConverter.ToString(bytes);
        }

        /// <summary>The decrypt.</summary>
        /// <param name="stringToDecrypt">The string to decrypt.</param>
        /// <param name="key">The key.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Decrypt(this string stringToDecrypt, string key)
        {
            if (string.IsNullOrEmpty(stringToDecrypt) || string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Empty input or key are not allowed.");
            }

            var cspp = new CspParameters { KeyContainerName = key };
            var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };

            var decryptArray = stringToDecrypt.Split(new[] { "-" }, StringSplitOptions.None);
            var decryptByteArray = Array.ConvertAll(decryptArray, s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber)));
            var bytes = rsa.Decrypt(decryptByteArray, true);

            return Encoding.UTF8.GetString(bytes);
        }
    }
}