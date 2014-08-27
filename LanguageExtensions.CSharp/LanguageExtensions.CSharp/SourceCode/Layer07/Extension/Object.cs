using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace LanguageExtensions.CSharp.Internal.L7_ObjectExtensions
{
    internal static class CObjectExtensions
    {
        /// <summary>
        /// <para>Equals may be overridden.</para>
        /// <para>Structure may be nullable or be boxed like an object class.</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ioSource"></param>
        /// <param name="iExceptionHandler"></param>
        /// <returns></returns>
        internal static bool extIsDefault<T>(this T ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                return true;
            }

            Type mType = ioSource.GetType();

            if (mType.IsClass)
            {
                return false;
            }

            //IsValueType.
            return CTryCatchObserver.Return(() => ioSource.Equals(default(T)), iExceptionHandler).Item2;
        }

        internal static MemoryStream extToMemoryStream<T>(this T ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return null;
            }
            else if (!ioSource.GetType().IsSerializable)
            {
                iExceptionHandler.extInvoke(new NotSupportedException("else if (!ioSource.GetType().IsSerializable)"));

                return null;
            }

            MemoryStream mMemoryStream = new MemoryStream();

            (new BinaryFormatter()).Serialize(mMemoryStream, ioSource);

            mMemoryStream.Position = CConst.BEGIN_INDEX;

            return mMemoryStream;
        }

        internal static byte[] extToBytes<T>(this T ioSource, Action<Exception> iExceptionHandler = null)
        {
            using (MemoryStream mMemoryStream = extToMemoryStream(ioSource, iExceptionHandler))
            {
                return ((mMemoryStream == null) ? new byte[CConst.EMPTY] : mMemoryStream.ToArray());
            }
        }

        internal static Tuple<bool, T> extDeepCopy<T>(this T ioSource, Action<Exception> iExceptionHandler = null)
        {
            if (ioSource.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioSource.extIsNull())"));

                return new Tuple<bool, T>(false, default(T));
            }
            else if (ioSource is string) //Call by Copy.
            {
                return new Tuple<bool, T>(true, ioSource);
            }
            else if (ioSource is decimal) //Call by Copy.
            {
                return new Tuple<bool, T>(true, ioSource);
            }
            else if (ioSource.GetType().IsPrimitive) //Call by Copy.
            {
                return new Tuple<bool, T>(true, ioSource);
            }
            //else if (ioSource.GetType().IsValueType) //The member of the structure may be class or not be serializable.
            //{
            //    return new Tuple<bool, T>(true, ioSource);
            //}

            using (MemoryStream mMemoryStream = extToMemoryStream(ioSource, iExceptionHandler))
            {
                return (
                    (mMemoryStream == null) ?
                    new Tuple<bool, T>(false, default(T)) :
                    new Tuple<bool, T>(true, (T)(new BinaryFormatter().Deserialize(mMemoryStream)))
                    );
            }
        }
    }
}
