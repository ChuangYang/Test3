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
    /// Create
    /// </summary>
    public interface ICreate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        DateTime getCreationTime();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TimeSpan getElapsedTime();
    }
}
