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
using LanguageExtensions.CSharp.Model;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Interface
{
    /// <summary>
    /// toStringT
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IToString_ExceptionData<T> : ICreate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iWithFieldNames"></param>
        /// <param name="iDateTimeKind"></param>
        /// <param name="iExceptionHandler"></param>
        /// <returns></returns>
        string[] toStrings(bool iWithFieldNames, DateTimeKind? iDateTimeKind = null, Action<CExceptionData<T>> iExceptionHandler = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iWithFieldNames"></param>
        /// <param name="iSeparator"></param>
        /// <param name="iDateTimeKind"></param>
        /// <param name="iExceptionHandler"></param>
        /// <returns></returns>
        string toString(bool iWithFieldNames, string iSeparator = CConst.SEPARATOR, DateTimeKind? iDateTimeKind = null, Action<CExceptionData<T>> iExceptionHandler = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iExceptionHandler"></param>
        /// <returns></returns>
        string toString(Action<CExceptionData<T>> iExceptionHandler = null);
    }
}
