using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Collections;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L1_EnumerableExtensions
{
    internal static class CEnumerableExtensions
    {
        internal static bool extIsNullOrEmpty(this IEnumerable ioSource)
        {
            if (ioSource.extIsNull())
            {
                return true;
            }

            foreach (var mElement in ioSource)
            {
                return false;
            }

            return true;
        }

        internal static bool extIsNotEmpty(this IEnumerable ioSource)
        {
            return !extIsNullOrEmpty(ioSource);
        }
    }
}
