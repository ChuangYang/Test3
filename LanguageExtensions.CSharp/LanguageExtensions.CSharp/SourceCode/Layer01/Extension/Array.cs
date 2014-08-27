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

namespace LanguageExtensions.CSharp.Internal.L1_ArrayExtensions
{
    internal static class CArrayExtensions
    {
        internal static bool extIsNullOrEmpty(this Array ioSource)
        {
            return ((ioSource == null) || (ioSource.Length == CConst.EMPTY));
        }

        internal static bool extIsNotEmpty(this Array ioSource)
        {
            return !extIsNullOrEmpty(ioSource);
        }
    }
}
