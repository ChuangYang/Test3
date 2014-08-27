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

namespace LanguageExtensions.CSharp.Internal.L1_StringHelper
{
    internal static class CStringHelper
    {
        internal static bool isTrue(ref string ioSource)
        {
            if (string.IsNullOrWhiteSpace(ioSource))
            {
                return false;
            }

            return (ioSource.Equals(bool.TrueString, StringComparison.OrdinalIgnoreCase) || ioSource.Equals(CConfigValue.TRUE));
        }

        internal static bool extIsTrue(this string iSource)
        {
            return isTrue(ref iSource);
        }

        internal static bool isFalse(ref string ioSource)
        {
            if (string.IsNullOrWhiteSpace(ioSource))
            {
                return false;
            }

            return (ioSource.Equals(bool.FalseString, StringComparison.OrdinalIgnoreCase) || ioSource.Equals(CConfigValue.FALSE));
        }

        internal static bool extIsFalse(this string iSource)
        {
            return isFalse(ref iSource);
        }

        internal static Tuple<bool, int> tryToInt(ref string ioSource, int iWhileFailed = CConst.ZERO)
        {
            if (string.IsNullOrWhiteSpace(ioSource))
            {
                return new Tuple<bool, int>(false, iWhileFailed);
            }
            else if (ioSource.Equals(CConfigValue.MIN, StringComparison.OrdinalIgnoreCase))
            {
                return new Tuple<bool, int>(true, int.MinValue);
            }
            else if (ioSource.Equals(CConfigValue.MAX, StringComparison.OrdinalIgnoreCase))
            {
                return new Tuple<bool, int>(true, int.MaxValue);
            }

            int mResult = CConst.ZERO;

            return (int.TryParse(ioSource, out mResult) ? new Tuple<bool, int>(true, mResult) : new Tuple<bool, int>(false, iWhileFailed));
        }

        internal static Tuple<bool, int> extTryToInt(this string iSource, int iWhileFailed = CConst.ZERO)
        {
            return tryToInt(ref iSource, iWhileFailed);
        }

        internal static Tuple<bool, long> tryToLong(ref string ioSource, long iWhileFailed = CConst.ZERO)
        {
            if (string.IsNullOrWhiteSpace(ioSource))
            {
                return new Tuple<bool, long>(false, iWhileFailed);
            }
            else if (ioSource.Equals(CConfigValue.MIN, StringComparison.OrdinalIgnoreCase))
            {
                return new Tuple<bool, long>(true, long.MinValue);
            }
            else if (ioSource.Equals(CConfigValue.MAX, StringComparison.OrdinalIgnoreCase))
            {
                return new Tuple<bool, long>(true, long.MaxValue);
            }

            long mResult = CConst.ZERO;

            return (long.TryParse(ioSource, out mResult) ? new Tuple<bool, long>(true, mResult) : new Tuple<bool, long>(false, iWhileFailed));
        }

        internal static Tuple<bool, long> extTryToLong(this string iSource, long iWhileFailed = CConst.ZERO)
        {
            return tryToLong(ref iSource, iWhileFailed);
        }

        internal static bool Equals(ref string ioSource, ref string ioTarget, StringComparison? iStringComparison = null)
        {
            if (ioSource == null)
            {
                return (ioTarget == null);
            }
            else if (ioTarget == null)
            {
                return false;
            }

            return ((iStringComparison == null) ? ioSource.Equals(ioTarget) : ioSource.Equals(ioTarget, iStringComparison.Value));
        }

        internal static bool extEquals(this string iSource, ref string ioTarget, StringComparison? iStringComparison = null)
        {
            return Equals(ref iSource, ref ioTarget, iStringComparison);
        }

        internal static bool extEquals(this string iSource, string iTarget, StringComparison? iStringComparison = null)
        {
            return Equals(ref iSource, ref iTarget, iStringComparison);
        }
    }
}
