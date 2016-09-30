namespace Ustilz.Arguments.TestAttributes
{
    #region Usings

    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    #endregion

    public abstract class ArgumentTestable
    {
        #region Méthodes publiques

        public Dictionary<PropertyInfo, bool> CheckArguments()
        {
            var result = new Dictionary<PropertyInfo, bool>();
            foreach (var propertyInfo in this.GetType().GetProperties())
            {
                var attributes = propertyInfo.GetCustomAttributes(false);

                if (!attributes.Any(o => o is ArgumentAttribute))
                {
                    continue;
                }

                foreach (var testAttribute in attributes.Where(o => !(o is ArgumentAttribute) && o is ITestAttribute).Cast<ITestAttribute>())
                {
                    result.Add(propertyInfo, testAttribute.Test(propertyInfo.GetValue(this, null)));
                }
            }

            return result;
        }

        #endregion
    }
}