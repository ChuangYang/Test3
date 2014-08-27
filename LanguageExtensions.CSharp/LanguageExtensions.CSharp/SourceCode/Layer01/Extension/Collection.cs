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
using LanguageExtensions.CSharp.Const;
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L1_CollectionExtensions
{
    internal static class CCollectionExtensions
    {
        internal static bool extIsNullOrEmpty(this ICollection ioSource)
        {
            return (ioSource.extIsNull() || (ioSource.Count == CConst.EMPTY));
        }

        internal static bool extIsNotEmpty(this ICollection ioSource)
        {
            return !extIsNullOrEmpty(ioSource);
        }
    }
}
