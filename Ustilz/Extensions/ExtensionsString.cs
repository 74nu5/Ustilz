namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Data.Entity.Design.PluralizationServices;
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The extensions string.</summary>
    [PublicAPI]
    public static class ExtensionsString
    {
        #region HashType enum

        /// <summary>Supported hash algorithms</summary>
        [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Ce sont des acronymes")]
        public enum HashType
        {
            /// <summary>The hmac.</summary>
            HMAC, 

            /// <summary>The hmacm d 5.</summary>
            HMACMD5, 

            /// <summary>The hmacsh a 1.</summary>
            HMACSHA1, 

            /// <summary>The hmacsh a 256.</summary>
            HMACSHA256, 

            /// <summary>The hmacsh a 384.</summary>
            HMACSHA384, 

            /// <summary>The hmacsh a 512.</summary>
            HMACSHA512, 

            /// <summary>The mac triple des.</summary>
            MACTripleDES, 

            /// <summary>The m d 5.</summary>
            MD5, 

            /// <summary>The ripem d 160.</summary>
            RIPEMD160, 

            /// <summary>The sh a 1.</summary>
            SHA1, 

            /// <summary>The sh a 256.</summary>
            SHA256, 

            /// <summary>The sh a 384.</summary>
            SHA384, 

            /// <summary>The sh a 512.</summary>
            SHA512
        }

        #endregion

        #region Méthodes publiques

        /// <summary>Computes the hash of the string using a specified hash algorithm</summary>
        /// <param name="input">The string to hash</param>
        /// <param name="hashType">The hash algorithm to use</param>
        /// <returns>The resulting hash or an empty string on error</returns>
        public static string ComputeHash(this string input, HashType hashType)
        {
            try
            {
                var hash = GetHash(input, hashType);
                var ret = new StringBuilder();

                foreach (var t in hash)
                {
                    ret.Append(t.ToString("x2"));
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
        /// <returns>The <see cref="string"/>.</returns>
        [System.Diagnostics.Contracts.Pure]
        public static string Decrypt(this string stringToDecrypt, string key)
        {
            if (string.IsNullOrEmpty(stringToDecrypt) || string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Empty input or key are not allowed.");
            }

            Contract.EndContractBlock();

            var cspp = new CspParameters { KeyContainerName = key };
            var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };

            var decryptArray = stringToDecrypt.Split(new[] { "-" }, StringSplitOptions.None);
            var decryptByteArray = Array.ConvertAll(decryptArray, s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber)));
            var bytes = rsa.Decrypt(decryptByteArray, true);

            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>The encrypt.</summary>
        /// <param name="stringToEncrypt">The string to encrypt.</param>
        /// <param name="key">The key.</param>
        /// <returns>The <see cref="string"/>.</returns>
        [System.Diagnostics.Contracts.Pure]
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

            Contract.EndContractBlock();

            var cspp = new CspParameters { KeyContainerName = key };
            var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
            var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(stringToEncrypt), true);

            return BitConverter.ToString(bytes);
        }

        /// <summary>The to string format.</summary>
        /// <param name="stringFormat">The string format.</param>
        /// <param name="stringParams">The string params.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Format(this string stringFormat, params string[] stringParams)
        {
            return string.Format(stringFormat, stringParams);
        }

        /// <summary>The format.</summary>
        /// <param name="template">The template.</param>
        /// <param name="data">The data.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Format<T>(this string template, T data)
        {
            return Regex.Replace(template, @"\@{([\w\d]+)\}", match => GetValue(match, data)).Replace("{{", "{").Replace("}}", "}");
        }

        /// <summary>The is null or empty.</summary>
        /// <param name="str">The str.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>The join.</summary>
        /// <param name="strs">The strs.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Join(this string[] strs, string separator)
        {
            return string.Join(separator, strs);
        }

        /// <summary>Returns the plural form of the specified word.</summary>
        /// <param name="chaine">The this.</param>
        /// <param name="count">How many of the specified word there are. A count equal to 1 will not pluralize the specified word.</param>
        /// <returns>A string that is the plural form of the input parameter.</returns>
        public static string Pluralize(this string chaine, int count = 0)
        {
            return count == 1 ? chaine : PluralizationService.CreateService(new CultureInfo("en-US")).Pluralize(chaine);
        }

        /// <summary>Converts string to enum object</summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="value">String value to convert</param>
        /// <returns>Returns enum object</returns>
        [System.Diagnostics.Contracts.Pure]
        public static T ToEnum<T>(this string value) where T : struct
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        /// <summary>The to exception.</summary>
        /// <param name="message">The message.</param>
        /// <typeparam name="T">Type de l'exception</typeparam>
        public static void ToException<T>(this string message) where T : Exception, new()
        {
            throw (T)Activator.CreateInstance(typeof(T), message);
        }

        #endregion

        #region Méthodes privées

        /// <summary>The get hash.</summary>
        /// <param name="input">The input.</param>
        /// <param name="hash">The hash.</param>
        /// <returns>The <see cref="byte"/>.</returns>
        private static byte[] GetHash(string input, HashType hash)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);

            switch (hash)
            {
                case HashType.HMAC:
                    return HMAC.Create().ComputeHash(inputBytes);

                case HashType.HMACMD5:
                    return HMAC.Create().ComputeHash(inputBytes);

                case HashType.HMACSHA1:
                    return HMAC.Create().ComputeHash(inputBytes);

                case HashType.HMACSHA256:
                    return HMAC.Create().ComputeHash(inputBytes);

                case HashType.HMACSHA384:
                    return HMAC.Create().ComputeHash(inputBytes);

                case HashType.HMACSHA512:
                    return HMAC.Create().ComputeHash(inputBytes);

                case HashType.MACTripleDES:
                    return KeyedHashAlgorithm.Create().ComputeHash(inputBytes);

                case HashType.MD5:
                    return MD5.Create().ComputeHash(inputBytes);

                case HashType.RIPEMD160:
                    return RIPEMD160.Create().ComputeHash(inputBytes);

                case HashType.SHA1:
                    return SHA1.Create().ComputeHash(inputBytes);

                case HashType.SHA256:
                    return SHA256.Create().ComputeHash(inputBytes);

                case HashType.SHA384:
                    return SHA384.Create().ComputeHash(inputBytes);

                case HashType.SHA512:
                    return SHA512.Create().ComputeHash(inputBytes);

                default:
                    return inputBytes;
            }
        }

        /// <summary>The get value.</summary>
        /// <param name="match">The match.</param>
        /// <param name="data">The data.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>The <see cref="string"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        private static string GetValue<T>(Match match, T data)
        {
            var paraName = match.Groups[1].Value;
            try
            {
                var proper = typeof(T).GetProperty(paraName);
                return proper.GetValue(data).ToString();
            }
            catch (Exception)
            {
                var errMsg = $"Not find '{paraName}'";
                throw new ArgumentException(errMsg);
            }
        }

        #endregion
    }
}