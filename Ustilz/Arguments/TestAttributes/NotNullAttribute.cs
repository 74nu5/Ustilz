namespace Ustilz.Arguments.TestAttributes
{
    using System;

    public sealed class NotNullAttribute : Attribute, ITestAttribute
    {
        #region Implementation of ITestAttribute

        public bool Test<T>(T value)
        {
            return value != null;
        }

        #endregion
    }
}