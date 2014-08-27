using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Deployment.Application;
using System.Diagnostics;
using System.Reflection;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
using LanguageExtensions.CSharp.Internal.L5_ExceptionHelper;
using LanguageExtensions.CSharp.Observer;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L7_StaticToolbox
{
    internal static class CStaticToolbox
    {
        internal static Tuple<int, int> getModifiedBeginIndexAndCount(int iSourceLength, int iBeginIndex = CConst.BEGIN_INDEX, int iCount = CConst.ALL_ITEMS, Action<Exception> iExceptionHandler = null)
        {
            if (iSourceLength <= CConst.EMPTY)
            {
                return new Tuple<int, int>(CConst.BEGIN_INDEX, CConst.EMPTY);
            }
            else if ((iBeginIndex == CConst.BEGIN_INDEX) && (iCount == CConst.ALL_ITEMS))
            {
                return new Tuple<int, int>(iBeginIndex, iSourceLength);
            }
            else if (iBeginIndex >= iSourceLength)
            {
                iExceptionHandler.extInvoke(new ArgumentOutOfRangeException(string.Format("else if ({0} >= {1})", iBeginIndex, iSourceLength)));

                return new Tuple<int, int>(CConst.BEGIN_INDEX, CConst.EMPTY);
            }
            else if (iCount == CConst.EMPTY)
            {
                return new Tuple<int, int>(((iBeginIndex < CConst.BEGIN_INDEX) ? CConst.BEGIN_INDEX : iBeginIndex), CConst.EMPTY);
            }

            int mBeginIndex = ((iBeginIndex < CConst.BEGIN_INDEX) ? CConst.BEGIN_INDEX : iBeginIndex);
            int mCount = (((iCount < CConst.EMPTY) || (iCount >= (iSourceLength - mBeginIndex))) ? (iSourceLength - mBeginIndex) : iCount);

            return new Tuple<int, int>(mBeginIndex, mCount);
        }

        internal static string getAppVersion(Action<Exception> iExceptionHandler = null)
        {
            Version mVersion = CTryCatchObserver.Return(() => ApplicationDeployment.CurrentDeployment.CurrentVersion, CExceptionHelper.ignoreException).Item2;

            if (mVersion.extIsNotNull())
            {
                return mVersion.ToString();
            }

            return CTryCatchObserver.Return(() => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion, iExceptionHandler).Item2;
        }
    }
}
