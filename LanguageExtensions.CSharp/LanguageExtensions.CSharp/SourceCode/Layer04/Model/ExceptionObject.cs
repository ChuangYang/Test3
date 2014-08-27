using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Runtime.InteropServices;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Model
{
    /// <summary>
    /// ExceptionObject
    /// </summary>
    [ComVisible(false)]
    public class CExceptionObject : CExceptionData<object>
    {
        #region Fields and properties.
        #endregion

        #region Singleton, factory or constructor.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ioException"></param>
        /// <param name="ioData"></param>
        /// <param name="iLevel"></param>
        public CExceptionObject(Exception ioException, object ioData = null, int iLevel = CConst.DEFAULT_EXCEPTION_LEVEL)
            : base(ioException, ioData, iLevel)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iLevel"></param>
        /// <param name="ioException"></param>
        /// <param name="ioData"></param>
        public CExceptionObject(int iLevel, Exception ioException, object ioData = null)
            : base(iLevel, ioException, ioData)
        { }
        #endregion

        #region Methods.
        #endregion
    }
}
