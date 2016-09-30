namespace Ustilz.Arguments.TestAttributes
{
    public interface ITestAttribute
    {
        #region Méthodes publiques

        bool Test<T>(T value);

        #endregion
    }
}