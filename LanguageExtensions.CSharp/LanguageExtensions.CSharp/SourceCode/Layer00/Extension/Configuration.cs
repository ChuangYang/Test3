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
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L0_ConfigurationExtensions
{
    internal static class CConfigurationExtensions
    {
        internal static KeyValueConfigurationCollection extSettings(this Configuration ioConfiguration)
        {
            return ioConfiguration.AppSettings.Settings;
        }
    }
}
