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
    /// toString
    /// </summary>
    public interface IToString_ExceptionData : ICreate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iWithFieldNames"></param>
        /// <param name="iDateTimeKind"></param>
        /// <param name="iExceptionHandler"></param>
        /// <returns></returns>
        string[] toStrings<T>(bool iWithFieldNames, DateTimeKind? iDateTimeKind = null, Action<CExceptionData<T>> iExceptionHandler = null);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iWithFieldNames"></param>
        /// <param name="iSeparator"></param>
        /// <param name="iDateTimeKind"></param>
        /// <param name="iExceptionHandler"></param>
        /// <returns></returns>
        string toString<T>(bool iWithFieldNames, string iSeparator = CConst.SEPARATOR, DateTimeKind? iDateTimeKind = null, Action<CExceptionData<T>> iExceptionHandler = null);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iExceptionHandler"></param>
        /// <returns></returns>
        string toString<T>(Action<CExceptionData<T>> iExceptionHandler = null);
    }
}
