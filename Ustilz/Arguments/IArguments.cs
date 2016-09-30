namespace Ustilz.Arguments
{
    using System.Collections.Generic;
    using System.Reflection;

    public interface IArguments
    {
        Dictionary<PropertyInfo, bool> CheckArguments();
    }
}