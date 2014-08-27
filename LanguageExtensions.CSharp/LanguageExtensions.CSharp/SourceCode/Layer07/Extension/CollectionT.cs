using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Data;
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

namespace LanguageExtensions.CSharp.Internal.L7_CollectionTExtensions
{
    internal static class CCollectionTExtensions
    {
        internal static int extLastIndex<T>(this ICollection<T> ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return CConst.NOT_FOUND;
            }

            return (ioSource.Count - 1);
        }

        internal static bool extIsReadOnly<T>(this ICollection<T> ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return true;
            }

            return ioSource.IsReadOnly;
        }

        internal static bool extAdd<T>(this ICollection<T> ioSource, T ioItem, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return false;
            }
            else if (ioSource.IsReadOnly)
            {
                iExceptionHandler.extInvoke(new ReadOnlyException("else if (ioSource.IsReadOnly)"));

                return false;
            }

            ioSource.Add(ioItem);

            return true;
        }

        internal static bool extAdd<T>(this ICollection<T> ioSource, IEnumerable<T> ioItems, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return false;
            }
            else if (ioSource.IsReadOnly)
            {
                iExceptionHandler.extInvoke(new ReadOnlyException("else if (ioSource.IsReadOnly)"));

                return false;
            }
            else if (ioItems.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (ioItems.extIsNull())"));

                return false;
            }

            foreach (T mItem in ioItems)
            {
                ioSource.Add(mItem);
            }

            return true;
        }

        internal static bool extClear<T>(this ICollection<T> ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return false;
            }
            else if (ioSource.IsReadOnly)
            {
                iExceptionHandler.extInvoke(new ReadOnlyException("else if (ioSource.IsReadOnly)"));

                return false;
            }

            ioSource.Clear();

            return true;
        }

        internal static IEnumerable<bool> extContains<T>(this ICollection<T> ioSource, IEnumerable<T> ioItems, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                yield break;
            }
            else if (ioItems.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (ioItems.extIsNull())"));

                yield break;
            }

            foreach (T mItem in ioItems)
            {
                yield return ioSource.Contains(mItem);
            }
        }

        internal static bool extRemove<T>(this ICollection<T> ioSource, T ioItem, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return false;
            }
            else if (ioSource.IsReadOnly)
            {
                iExceptionHandler.extInvoke(new ReadOnlyException("else if (ioSource.IsReadOnly)"));

                return false;
            }

            return ioSource.Remove(ioItem);
        }

        internal static IEnumerable<bool> extRemove<T>(this ICollection<T> ioSource, IEnumerable<T> ioItems, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                yield break;
            }
            else if (ioSource.IsReadOnly)
            {
                iExceptionHandler.extInvoke(new ReadOnlyException("else if (ioSource.IsReadOnly)"));

                yield break;
            }
            else if (ioItems.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (ioItems.extIsNull())"));

                yield break;
            }

            foreach (T mItem in ioItems)
            {
                yield return ioSource.Remove(mItem);
            }
        }
    }
}
