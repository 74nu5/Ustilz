namespace Ustilz.Arguments
{
    #region Usings

    using System;
    using System.Linq;
    using System.Text;

    using Ustilz.Annotations;
    using Ustilz.Extensions;

    #endregion

    /// <summary>The arguments manager. </summary>
    [PublicAPI]
    public static class ArgumentsManager
    {
        #region Champs statiques

        /// <summary>The no m_ method e_ parse. </summary>
        private const string NOM_METHODE_PARSE = "Parse";

        #endregion

        /// <summary>The check.</summary>
        /// <param name="str">The str.</param>
        /// <returns>The <see cref="Checker"/>.</returns>
        public static Checker Check(string str)
        {
            return new Checker(str);
        }

        #region Méthodes statiques

        /// <summary>The init. </summary>
        /// <typeparam name="T">The t </typeparam>
        /// <param name="args">The args. </param>
        /// <returns>The <see cref="T"/>. </returns>
        public static T Init<T>(string[] args) where T : new()
        {
            return Init<T>(args, false);
        }

        /// <summary>The init. </summary>
        /// <typeparam name="T">The t </typeparam>
        /// <param name="args">The args. </param>
        /// <param name="afficherResume">The afficher Resume. </param>
        /// <returns>The <see cref="T"/>. </returns>
        public static T Init<T>(string[] args, bool afficherResume) where T : new()
        {
            var retour = new T();
            var atts =
                typeof(T).GetProperties()
                    .Select(prop => new { Property = prop, Attribute = (ArgumentAttribute)Attribute.GetCustomAttribute(prop, typeof(ArgumentAttribute)) })
                    .Where(a => a.Attribute != null);

            var sb = new StringBuilder();
            sb.Append("************************************************************\n");

            foreach (var arguments in atts)
            {
                sb.AppendFormat("\t ~ {0} ({1}) : ", arguments.Property.Name, arguments.Attribute.Key);
                var index = args.IndexOf(arguments.Attribute.Key);
                if (index >= 0)
                {
                    var methodInfo = arguments.Property.PropertyType.GetMethod(NOM_METHODE_PARSE, new[] { typeof(string) });
                    object valeur = null;
                    if (methodInfo != null)
                    {
                        try
                        {
                            valeur = methodInfo.Invoke(null, new object[] { args.ElementAt(index + 1) });
                        }
                        catch (Exception e)
                        {
                            if (e.InnerException != null)
                            {
                                throw e.InnerException;
                            }

                            throw;
                        }
                    }
                    else if (arguments.Property.PropertyType == typeof(string))
                    {
                        valeur = args.ElementAt(index + 1);
                    }
                    else
                    {
                        var construct = arguments.Property.PropertyType.GetConstructor(new[] { typeof(string) });
                        if (construct != null)
                        {
                            try
                            {
                                valeur = construct.Invoke(new object[] { args.ElementAt(index + 1) });
                            }
                            catch (Exception e)
                            {
                                if (e.InnerException != null)
                                {
                                    throw e.InnerException;
                                }

                                throw;
                            }
                        }
                    }

                    sb.AppendFormat("{0}\n", valeur);
                    arguments.Property.SetValue(retour, valeur, null);
                }
                else
                {
                    if (arguments.Attribute.IsRequired)
                    {
                        throw new ArgumentMissingException($"L'argument {arguments.Property.Name.ToLower()} ({arguments.Attribute.Key}) obligatoire, est manquant.");
                    }
                }
            }

            sb.Append("************************************************************\n");

            if (afficherResume)
            {
                Console.Write(sb.ToString());
            }

            return retour;
        }

        #endregion
    }
}