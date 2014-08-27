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

namespace LanguageExtensions.CSharp.Internal.L1_Readonly
{
    internal static class CReadonly
    {
        #region Fields and properties.
        private static bool fIsComVisible;

        private static DateTimeKind fDateTimeKind;
        private static string fDateTimeSQLFormat;

        private static string fSeparatorHead;
        private static string fSeparatorTail;
        private static string fSeparator;
        private static string fBucket;

        private static SynchronizedReadOnlyCollection<string> fExceptionFormat;

        private static int fUniqueIntBegin;
        private static long fUniqueLongBegin;
        #endregion

        #region Singleton, factory or constructor.
        static CReadonly()
        {
            fIsComVisible = true;

            fDateTimeKind = DateTimeKind.Local;
            fDateTimeSQLFormat = "yyyy-MM-dd HH:mm:ss.fffffff";

            fSeparatorHead = "[";
            fSeparatorTail = "]";
            fSeparator = "]["; //string.Format("{0}{1}", fSeparatorTail, fSeparatorHead);
            fBucket = "[{0}]"; //string.Format("{0}{1}{2}", fSeparatorHead, CConst.FORMAT_INITIAL, fSeparatorTail);

            fExceptionFormat = new SynchronizedReadOnlyCollection<string>(new object(), new string[] { CConfigValue.EXCEPTION_TYPE, CConfigValue.EXCEPTION_MESSAGE, CConfigValue.EXCEPTION_RESPONSE_STRING, CConfigValue.EXCEPTION_HELPLINK, CConfigValue.EXCEPTION_RESPONSE_URI, CConfigValue.EXCEPTION_STACKTRACE });

            fUniqueIntBegin = 1;
            fUniqueLongBegin = 1;
        }
        #endregion

        #region Methods.
        internal static bool isComVisible()
        {
            return fIsComVisible;
        }

        internal static DateTimeKind getDateTimeKind()
        {
            return fDateTimeKind;
        }

        internal static string getDateTimeSQLFormat()
        {
            return fDateTimeSQLFormat;
        }

        internal static string getSeparatorHead()
        {
            return fSeparatorHead;
        }

        internal static string getSeparatorTail()
        {
            return fSeparatorTail;
        }

        internal static string getSeparator()
        {
            return fSeparator;
        }

        internal static string getBucket()
        {
            return fBucket;
        }

        internal static SynchronizedReadOnlyCollection<string> getExceptionFormat()
        {
            return fExceptionFormat;
        }

        internal static int getUniqueIntBegin()
        {
            return fUniqueIntBegin;
        }

        internal static long getUniqueLongBegin()
        {
            return fUniqueLongBegin;
        }
        #endregion
    }
}
