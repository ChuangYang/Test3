using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L1_StringBuilderExtensions
{
    internal static class CStringBuilderExtensions
    {
        internal static bool extIsNullOrEmpty(this StringBuilder ioSource)
        {
            return ((ioSource == null) || (ioSource.Length == CConst.EMPTY));
        }

        internal static bool extIsNotEmpty(this StringBuilder ioSource)
        {
            return !extIsNullOrEmpty(ioSource);
        }
    }
}
