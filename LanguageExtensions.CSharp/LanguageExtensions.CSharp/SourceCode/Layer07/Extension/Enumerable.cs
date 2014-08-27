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
using LanguageExtensions.CSharp.Observer;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L7_EnumerableExtensions
{
    internal static class CEnumerableExtensions
    {
        internal static Type extGetItemType(this IEnumerable ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return null;
            }

            foreach (var mCurrent in ioSource)
            {
                if (mCurrent.extIsNotNull())
                {
                    return mCurrent.GetType();
                }
            }

            iExceptionHandler.extInvoke(new ArgumentNullException("foreach (var mCurrent in ioSource)"));

            return null;
        }

        private static IEnumerable<T> SkipThanTake<T>(IEnumerable ioSource, int iBeginIndex = CConst.BEGIN_INDEX, int iCount = CConst.ALL_ITEMS)
        {
            if (iCount == CConst.EMPTY)
            {
                yield break;
            }

            if (iBeginIndex < CConst.BEGIN_INDEX)
            {
                iBeginIndex = CConst.BEGIN_INDEX;
            }

            if ((iBeginIndex == CConst.BEGIN_INDEX) && (iCount <= CConst.ALL_ITEMS))
            {
                foreach (T mItem in ioSource)
                {
                    yield return mItem;
                }

                yield break;
            }

            int mIndex = CConst.BEGIN_INDEX;

            if (iCount <= CConst.ALL_ITEMS)
            {
                foreach (T mItem in ioSource)
                {
                    if ((mIndex++) >= iBeginIndex)
                    {
                        yield return mItem;
                    }
                }

                yield break;
            }

            int mCount = CConst.EMPTY;

            foreach (T mItem in ioSource)
            {
                if ((mIndex++) >= iBeginIndex)
                {
                    yield return mItem;

                    if ((++mCount) == iCount)
                    {
                        yield break;
                    }
                }
            }
        }

        internal static IEnumerable<T> extSkipThanTake<T>(this IEnumerable ioSource, int iBeginIndex = CConst.BEGIN_INDEX, int iCount = CConst.ALL_ITEMS, Action<Exception> iExceptionHandler = null)
        {
            return CTryCatchObserver.Return(() => SkipThanTake<T>(ioSource, iBeginIndex, iCount), iExceptionHandler).Item2;
        }

        internal static IEnumerable<T> extSkipThanTake<T>(this IEnumerable ioSource, Action<Exception> iExceptionHandler)
        {
            return ioSource.extSkipThanTake<T>(CConst.BEGIN_INDEX, CConst.ALL_ITEMS, iExceptionHandler);
        }
    }
}
