using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Configuration;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Internal.L5_ExceptionHelper;
using LanguageExtensions.CSharp.Observer;
#endregion

#region Set the aliases.
using CL0ConfigurationExtensions = LanguageExtensions.CSharp.Internal.L0_ConfigurationExtensions.CConfigurationExtensions;
#endregion

namespace LanguageExtensions.CSharp.Internal.L7_ConfigurationExtensions
{
    internal static class CConfigurationExtensions
    {
        internal static KeyValueConfigurationCollection extSettings(this Configuration ioConfiguration, Action<Exception> iExceptionHandler = null)
        {
            return CTryCatchObserver.Return(() => CL0ConfigurationExtensions.extSettings(ioConfiguration), iExceptionHandler).Item2;
        }

        internal static bool extContains(this Configuration ioConfiguration, string iKey)
        {
            return CTryCatchObserver.Return(() => ioConfiguration.AppSettings.Settings.AllKeys.Contains(iKey), CExceptionHelper.ignoreException).Item2;
        }
    }
}
