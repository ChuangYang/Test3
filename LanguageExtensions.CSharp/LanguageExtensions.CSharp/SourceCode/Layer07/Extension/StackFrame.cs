using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Diagnostics;
using System.Reflection;
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

namespace LanguageExtensions.CSharp.Internal.L7_StackFrameExtensions
{
    internal static class CStackFrameExtensions
    {
        internal static string extGetFileName(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            if (ioStackFrame.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioStackFrame.extIsNull())"));

                return CConst.STRING_EMPTY;
            }

            return ioStackFrame.GetFileName();
        }

        internal static Type extGetDeclaringType(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            if (ioStackFrame.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioStackFrame.extIsNull())"));

                return null;
            }

            return ioStackFrame.GetMethod().DeclaringType;
        }

        internal static string extGetNamespace(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            Type mType = extGetDeclaringType(ioStackFrame, iExceptionHandler);

            return (mType.extIsNull() ? CConst.STRING_EMPTY : mType.Namespace);
        }

        internal static string extGetClassName(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            Type mType = extGetDeclaringType(ioStackFrame, iExceptionHandler);

            return (mType.extIsNull() ? CConst.STRING_EMPTY : mType.Name);
        }

        internal static string extGetMethodName(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            if (ioStackFrame.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioStackFrame.extIsNull())"));

                return CConst.STRING_EMPTY;
            }

            return ioStackFrame.GetMethod().Name;
        }

        internal static ParameterInfo[] extGetParameters(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            if (ioStackFrame.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioStackFrame.extIsNull())"));

                return new ParameterInfo[CConst.EMPTY];
            }

            return ioStackFrame.GetMethod().GetParameters();
        }

        internal static string[] extGetParametersNames(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            ParameterInfo[] mParameterInfos = extGetParameters(ioStackFrame, iExceptionHandler);

            return Array.ConvertAll(mParameterInfos, mParameterInfo => mParameterInfo.Name);
        }

        /// <summary>
        /// MethodName(ParametersName1,ParametersName2,ParametersName3,etc.)
        /// </summary>
        /// <param name="ioStackFrame"></param>
        /// <param name="iExceptionHandler"></param>
        /// <returns>MethodName(ParametersName1,ParametersName2,ParametersName3,etc.)</returns>
        internal static string extGetFullMethodName(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            if (ioStackFrame.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioStackFrame.extIsNull())"));

                return CConst.STRING_EMPTY;
            }

            return string.Format("{0}({1})", extGetMethodName(ioStackFrame, iExceptionHandler), string.Join(",", extGetParametersNames(ioStackFrame, iExceptionHandler)));
        }

        internal static int extGetLineNumber(this StackFrame ioStackFrame, Action<Exception> iExceptionHandler = null)
        {
            if (ioStackFrame.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioStackFrame.extIsNull())"));

                return CConst.NOT_FOUND;
            }

            return ioStackFrame.GetFileLineNumber();
        }
    }
}
