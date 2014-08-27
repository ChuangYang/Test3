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
using LanguageExtensions.CSharp.Model;
using LanguageExtensions.CSharp.Observer;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L7_CollectionExtensions
{
    internal static class CCollectionExtensions
    {
        internal static int extLastIndex(this ICollection ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return CConst.NOT_FOUND;
            }

            return (ioSource.Count - 1);
        }

        internal static object extGetSyncRoot(this ICollection ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return null;
            }

            return CTryCatchObserver.Return(() => ioSource.SyncRoot, iExceptionHandler).Item2;
        }
    }
}
