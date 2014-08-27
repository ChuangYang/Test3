using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Text.RegularExpressions;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
using LanguageExtensions.CSharp.Internal.L1_EnumerableExtensions;
using LanguageExtensions.CSharp.Internal.L1_Readonly;
using LanguageExtensions.CSharp.Observer;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L7_StringHelper
{
    internal static class CStringHelper
    {
        internal static Guid toGUID(ref string ioSource, Action<Exception> iExceptionHandler = null)
        {
            try
            {
                return new Guid(ioSource);
            }
            catch (Exception mException)
            {
                iExceptionHandler.extInvoke(mException);

                return Guid.Empty;
            }
            finally
            { }
        }

        internal static Guid extToGUID(this string iSource, Action<Exception> iExceptionHandler = null)
        {
            return toGUID(ref iSource, iExceptionHandler);
        }

        internal static string extJoin(this string iSeparator, Action<Exception> iExceptionHandler, params string[] ioValues)
        {
            if (string.IsNullOrEmpty(iSeparator))
            {
                iSeparator = CReadonly.getSeparator();
            }
            else if (iSeparator.Equals(CConst.SEPARATOR, StringComparison.OrdinalIgnoreCase))
            {
                iSeparator = CReadonly.getSeparator();
            }

            return CTryCatchObserver.Return(
                () => (
                    CReadonly.getBucket().Equals(CConst.FORMAT_INITIAL) ?
                    string.Join(iSeparator, ioValues) :
                    string.Format(CReadonly.getBucket(), string.Join(iSeparator, ioValues))
                ),
                iExceptionHandler
                ).Item2;
        }

        internal static string extJoin(this string iSeparator, string[] ioValues, Action<Exception> iExceptionHandler = null)
        {
            return extJoin(iSeparator, iExceptionHandler, ioValues);
        }

        internal static string extJoin(this string iSeparator, params string[] ioValues)
        {
            return extJoin(iSeparator, null, ioValues);
        }

        internal static int IndexOfTail(ref string ioSource, string iKeyword, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            if (string.IsNullOrEmpty(ioSource))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (string.IsNullOrEmpty(ioSource))"));

                return CConst.NOT_FOUND;
            }
            else if (string.IsNullOrEmpty(iKeyword))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (string.IsNullOrEmpty(iTarget))"));

                return CConst.NOT_FOUND;
            }

            int mIndex = ((iComparisonType == null) ? ioSource.IndexOf(iKeyword) : ioSource.IndexOf(iKeyword, iComparisonType.Value));

            return ((mIndex == CConst.NOT_FOUND) ? mIndex : (mIndex + iKeyword.Length));
        }

        internal static int extIndexOfTail(this string iSource, string iKeyword, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            if (string.IsNullOrEmpty(iSource))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (string.IsNullOrEmpty(iSource))"));

                return CConst.NOT_FOUND;
            }
            else if (string.IsNullOrEmpty(iKeyword))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (string.IsNullOrEmpty(iTarget))"));

                return CConst.NOT_FOUND;
            }

            int mIndex = ((iComparisonType == null) ? iSource.IndexOf(iKeyword) : iSource.IndexOf(iKeyword, iComparisonType.Value));

            return ((mIndex == CConst.NOT_FOUND) ? mIndex : (mIndex + iKeyword.Length));
        }

        internal static int LastIndexOfTail(ref string ioSource, string iKeyword, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            if (string.IsNullOrEmpty(ioSource))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (string.IsNullOrEmpty(ioSource))"));

                return CConst.NOT_FOUND;
            }
            else if (string.IsNullOrEmpty(iKeyword))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (string.IsNullOrEmpty(iTarget))"));

                return CConst.NOT_FOUND;
            }

            int mIndex = ((iComparisonType == null) ? ioSource.LastIndexOf(iKeyword) : ioSource.LastIndexOf(iKeyword, iComparisonType.Value));

            return ((mIndex == CConst.NOT_FOUND) ? mIndex : (mIndex + iKeyword.Length));
        }

        internal static int extLastIndexOfTail(this string iSource, string iKeyword, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            if (string.IsNullOrEmpty(iSource))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (string.IsNullOrEmpty(iSource))"));

                return CConst.NOT_FOUND;
            }
            else if (string.IsNullOrEmpty(iKeyword))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (string.IsNullOrEmpty(iTarget))"));

                return CConst.NOT_FOUND;
            }

            int mIndex = ((iComparisonType == null) ? iSource.LastIndexOf(iKeyword) : iSource.LastIndexOf(iKeyword, iComparisonType.Value));

            return ((mIndex == CConst.NOT_FOUND) ? mIndex : (mIndex + iKeyword.Length));
        }

        internal static string Substring(ref string ioSource, string iBegin, bool iSearchBeginFromHead, string iEnd, bool iSearchEndFromHead, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            int mBeginIndex = CConst.NOT_FOUND;
            int mEndIndex = CConst.NOT_FOUND;

            if ((mBeginIndex = ((iSearchBeginFromHead) ? IndexOfTail(ref ioSource, iBegin, iComparisonType, iExceptionHandler) : LastIndexOfTail(ref ioSource, iBegin, iComparisonType, iExceptionHandler))) == CConst.NOT_FOUND)
            {
                return CConst.STRING_EMPTY;
            }
            else if (string.IsNullOrEmpty(iEnd))
            {
                return ioSource.Substring(mBeginIndex);
            }

            string mBegin = ioSource.Substring(mBeginIndex);

            if (iComparisonType == null)
            {
                mEndIndex = ((iSearchEndFromHead) ? mBegin.IndexOf(iEnd) : mBegin.LastIndexOf(iEnd));
            }
            else
            {
                mEndIndex = ((iSearchEndFromHead) ? mBegin.IndexOf(iEnd, iComparisonType.Value) : mBegin.LastIndexOf(iEnd, iComparisonType.Value));
            }

            return ((mEndIndex == CConst.NOT_FOUND) ? mBegin : mBegin.Substring(CConst.BEGIN_INDEX, mEndIndex));
        }

        internal static string extSubstring(this string iSource, string iBegin, bool iSearchBeginFromHead, string iEnd, bool iSearchEndFromHead, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            int mBeginIndex = CConst.NOT_FOUND;
            int mEndIndex = CConst.NOT_FOUND;

            if ((mBeginIndex = ((iSearchBeginFromHead) ? IndexOfTail(ref iSource, iBegin, iComparisonType, iExceptionHandler) : LastIndexOfTail(ref iSource, iBegin, iComparisonType, iExceptionHandler))) == CConst.NOT_FOUND)
            {
                return CConst.STRING_EMPTY;
            }
            else if (string.IsNullOrEmpty(iEnd))
            {
                return iSource.Substring(mBeginIndex);
            }

            string mBegin = iSource.Substring(mBeginIndex);

            if (iComparisonType == null)
            {
                mEndIndex = ((iSearchEndFromHead) ? mBegin.IndexOf(iEnd) : mBegin.LastIndexOf(iEnd));
            }
            else
            {
                mEndIndex = ((iSearchEndFromHead) ? mBegin.IndexOf(iEnd, iComparisonType.Value) : mBegin.LastIndexOf(iEnd, iComparisonType.Value));
            }

            return ((mEndIndex == CConst.NOT_FOUND) ? mBegin : mBegin.Substring(CConst.BEGIN_INDEX, mEndIndex));
        }

        internal static string FirstSubstring(ref string ioSource, string iBegin, string iEnd, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            return Substring(ref ioSource, iBegin, true, iEnd, true, iComparisonType, iExceptionHandler);
        }

        internal static string extFirstSubstring(this string iSource, string iBegin, string iEnd, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            return Substring(ref iSource, iBegin, true, iEnd, true, iComparisonType, iExceptionHandler);
        }

        internal static string LastSubstring(ref string ioSource, string iBegin, string iEnd, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            return Substring(ref ioSource, iBegin, false, iEnd, false, iComparisonType, iExceptionHandler);
        }

        internal static string extLastSubstring(this string iSource, string iBegin, string iEnd, StringComparison? iComparisonType = null, Action<Exception> iExceptionHandler = null)
        {
            return Substring(ref iSource, iBegin, false, iEnd, false, iComparisonType, iExceptionHandler);
        }

        internal static string toValidString(ref string ioSource, Regex ioEscapes, ref string ioReplacement, Action<Exception> iExceptionHandler = null)
        {
            try
            {
                return ioEscapes.Replace(ioSource, ioReplacement);
            }
            catch (Exception mException)
            {
                iExceptionHandler.extInvoke(mException);

                return CConst.STRING_EMPTY;
            }
            finally
            { }
        }

        internal static string toValidString(ref string ioSource, IEnumerable<char> ioInvalidChars, ref string ioReplacement, Action<Exception> iExceptionHandler = null)
        {
            if (ioInvalidChars.extIsNullOrEmpty())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioInvalidChars.extIsNullOrEmpty())"));

                return CConst.STRING_EMPTY;
            }

            string mInvalidChars = new string((ioInvalidChars is char[]) ? (ioInvalidChars as char[]) : ioInvalidChars.ToArray());

            //http://stackoverflow.com/questions/146134/how-to-remove-illegal-characters-from-path-and-filenames
            //http://stackoverflow.com/questions/62771/how-check-if-given-string-is-legal-allowed-file-name-under-windows
            //http://stackoverflow.com/questions/12688985/validate-folder-name-in-c-sharp
            return toValidString(ref ioSource, new Regex(string.Format("[{0}]", Regex.Escape(mInvalidChars))), ref ioReplacement, iExceptionHandler);
        }

        internal static string extToValidString(this string iSource, Regex ioEscapes, string iReplacement, Action<Exception> iExceptionHandler = null)
        {
            return toValidString(ref iSource, ioEscapes, ref iReplacement, iExceptionHandler);
        }

        internal static string extToValidString(this string iSource, IEnumerable<char> ioInvalidChars, string iReplacement, Action<Exception> iExceptionHandler = null)
        {
            return toValidString(ref iSource, ioInvalidChars, ref iReplacement, iExceptionHandler);
        }
    }
}
