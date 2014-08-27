using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Configuration;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Internal.L0_TypeExtensions;
using LanguageExtensions.CSharp.Model;
#endregion

#region Set the aliases.
using CL7Entrance = LanguageExtensions.CSharp.Internal.L7_Entrance.CEntrance;
#endregion

namespace LanguageExtensions.CSharp
{
    /// <summary>
    /// Entrance
    /// </summary>
    public static class CEntrance
    {
        #region Fields and properties.
        private static readonly object fSyncRoot;
        #endregion

        #region Singleton, factory or constructor.
        static CEntrance()
        {
            fSyncRoot = new object();
        }
        #endregion

        #region Methods.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ioDefaultExceptionHandler"></param>
        /// <param name="ioConfiguration"></param>
        public static void Register(Action<CExceptionData<object>> ioDefaultExceptionHandler, Configuration ioConfiguration = null)
        {
            lock (fSyncRoot)
            {
                typeof(CL7Entrance).extGetMethod("Register").Invoke(null, new object[] { ioDefaultExceptionHandler, ioConfiguration });
            }
        }
        #endregion
    }
}
