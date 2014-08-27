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
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L1_CollectionTExtensions
{
    internal static class CCollectionTExtensions
    {
        internal static bool extIsNullOrEmpty<T>(this ICollection<T> ioSource)
        {
            return (ioSource.extIsNull() || (ioSource.Count == CConst.EMPTY));
        }

        internal static bool extIsNotEmpty<T>(this ICollection<T> ioSource)
        {
            return !extIsNullOrEmpty(ioSource);
        }
    }
}
