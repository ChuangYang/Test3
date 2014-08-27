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
    public interface IToString_ExceptionObject : ICreate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iWithFieldNames"></param>
        /// <param name="iDateTimeKind"></param>
        /// <param name="iExceptionHandler"></param>
        /// <returns></returns>
        string[] toStrings(bool iWithFieldNames, DateTimeKind? iDateTimeKind = null, Action<CExceptionObject> iExceptionHandler = null);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string toString(bool iWithFieldNames, string iSeparator = CConst.SEPARATOR, DateTimeKind? iDateTimeKind = null, Action<CExceptionObject> iExceptionHandler = null);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string toString(Action<CExceptionObject> iExceptionHandler = null);
    }
}
