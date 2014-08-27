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

namespace LanguageExtensions.CSharp.Internal.L5_ExceptionHelper
{
    internal static class CExceptionHelper
    {
        #region Fields and properties.
        private static Action<CExceptionData<object>> fDefaultExceptionHandler;
        #endregion

        #region Singleton, factory or constructor.
        static CExceptionHelper()
        {
            fDefaultExceptionHandler = null;
        }
        #endregion

        #region Methods.
        internal static void ignoreException(Exception ioException)
        {
            return;
        }

        internal static void ignoreExceptionData<T>(CExceptionData<T> ioExceptionData)
        {
            return;
        }

        internal static void ignoreExceptionObject(CExceptionObject ioExceptionObject)
        {
            return;
        }

        internal static void throwException(Exception ioException)
        {
            throw ioException;
        }

        internal static void throwExceptionData<T>(CExceptionData<T> ioExceptionData)
        {
            if (ioExceptionData == null)
            {
                throw new ArgumentNullException("if (ioExceptionData == null)");
            }

            throw ioExceptionData.getException();
        }

        internal static void throwExceptionObject(CExceptionObject ioExceptionObject)
        {
            if (ioExceptionObject == null)
            {
                throw new ArgumentNullException("if (ioExceptionObject == null)");
            }

            throw ioExceptionObject.getException();
        }

        internal static Action<CExceptionData<object>> getDefaultExceptionHandler()
        {
            return fDefaultExceptionHandler;
        }

        internal static Tuple<bool, CExceptionObject> extTryToObject<T>(this CExceptionData<T> ioExceptionData)
        {
            return (
                (ioExceptionData == null) ?
                new Tuple<bool, CExceptionObject>(false, new CExceptionObject(new ArgumentNullException("(ioExceptionData == null)"))) :
                new Tuple<bool, CExceptionObject>(true, new CExceptionObject(ioExceptionData.getException(), ioExceptionData.getData(), ioExceptionData.getLevel()))
                );
        }
        #endregion
    }
}
