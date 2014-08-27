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
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Interface
{
    /// <summary>
    /// Dispose
    /// </summary>
    public interface IDispose : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        DateTime getDisposedTime();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool isDisposed();
    }
}
