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
using LanguageExtensions.CSharp.Internal.L1_Readonly;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L2_DateTimeHelper
{
    internal static class CDateTimeHelper
    {
        #region Fields and properties.
        private static DateTime fDateTimeMin; //For reflection.
        private static DateTime fDateTimeMax; //For reflection.
        private static readonly TimeSpan fInfinite;
        #endregion

        #region Singleton, factory or constructor.
        static CDateTimeHelper()
        {
            fDateTimeMin = new DateTime(DateTime.MinValue.Ticks, CReadonly.getDateTimeKind());
            fDateTimeMax = new DateTime(DateTime.MaxValue.Ticks, CReadonly.getDateTimeKind());
            fInfinite = new TimeSpan(CConst.NOT_FOUND);
        }
        #endregion

        #region Methods.
        internal static DateTime getDateTimeMin()
        {
            return fDateTimeMin;
        }

        internal static DateTime getDateTimeMax()
        {
            return fDateTimeMax;
        }

        internal static TimeSpan getInfinite()
        {
            return fInfinite;
        }

        internal static DateTime getTimeNow()
        {
            return ((CReadonly.getDateTimeKind() == DateTimeKind.Utc) ? DateTime.UtcNow : DateTime.Now);
        }

        internal static DateTime extToKind(this DateTime iSource, DateTimeKind? iKind = null)
        {
            if (iKind == null)
            {
                iKind = CReadonly.getDateTimeKind();
            }

            if (iKind == DateTimeKind.Unspecified)
            {
                throw new ArgumentException("if (iKind == DateTimeKind.Unspecified)");
            }
            else if (iKind == iSource.Kind)
            {
                return iSource;
            }

            return ((iKind == DateTimeKind.Utc) ? iSource.ToUniversalTime() : iSource.ToLocalTime());
        }

        internal static string extToSQLDateTime(this DateTime iSource, DateTimeKind? iKind = null)
        {
            return extToKind(iSource, iKind).ToString(CReadonly.getDateTimeSQLFormat());
        }
        #endregion
    }
}
