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

namespace LanguageExtensions.CSharp.Internal.L0_ObjectExtensions
{
    internal static class CObjectExtensions
    {
        /// <summary>
        /// <para>Equals may be overridden.</para>
        /// <para>Structure may be nullable or be boxed like an object class.</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ioSource"></param>
        /// <returns></returns>
        internal static bool extIsNotNull<T>(this T ioSource)
        {
            //try
            //{
            //    ioSource.GetType();

            //    return true;
            //}
            //catch (Exception mException)
            //{
            //    return false;
            //}
            //finally
            //{ }

            return (ioSource is T);
        }

        /// <summary>
        /// <para>Equals may be overridden.</para>
        /// <para>Structure may be nullable or be boxed like an object class.</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ioSource"></param>
        /// <returns></returns>
        internal static bool extIsNull<T>(this T ioSource)
        {
            return !extIsNotNull(ioSource);
        }
    }
}
