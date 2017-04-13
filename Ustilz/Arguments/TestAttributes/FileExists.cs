namespace Ustilz.Arguments.TestAttributes
{
    #region Usings

    using System;
    using System.IO;

    using JetBrains.Annotations;

    #endregion

    [PublicAPI]
    public sealed class FileExists : Attribute, ITestAttribute
    {
        #region Méthodes publiques

        public bool Test<T>(T value)
        {
            var fileInfo = value as FileInfo ?? new FileInfo(value.ToString());
            return fileInfo.Exists;
        }

        #endregion
    }
}