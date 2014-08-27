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
using LanguageExtensions.CSharp.Internal.L5_ExceptionHelper;
using LanguageExtensions.CSharp.Model;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Observer
{
    /// <summary>
    /// ExceptionObserver (Event Observer) (Delegate Extensions)
    /// </summary>
    public static class CExceptionObserver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioException"></param>
        public static void extInvoke(this Action<Exception> iExceptionHandler, Exception ioException)
        {
            if (iExceptionHandler == null)
            {
                if (CExceptionHelper.getDefaultExceptionHandler() == null)
                {
                    CExceptionHelper.throwException(ioException);

                    return;
                }

                CExceptionHelper.getDefaultExceptionHandler()(new CExceptionObject(ioException));

                return;
            }

            iExceptionHandler(ioException);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioExceptionData"></param>
        public static void extInvoke<T>(this Action<CExceptionData<T>> iExceptionHandler, CExceptionData<T> ioExceptionData)
        {
            if (iExceptionHandler == null)
            {
                if (CExceptionHelper.getDefaultExceptionHandler() == null)
                {
                    CExceptionHelper.throwExceptionData(ioExceptionData);

                    return;
                }

                CExceptionHelper.getDefaultExceptionHandler()(ioExceptionData.extTryToObject().Item2);

                return;
            }

            iExceptionHandler(ioExceptionData);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioException"></param>
        public static void extInvoke<T>(this Action<CExceptionData<T>> iExceptionHandler, Exception ioException)
        {
            extInvoke(iExceptionHandler, new CExceptionData<T>(ioException));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioExceptionObject"></param>
        public static void extInvoke(this Action<CExceptionObject> iExceptionHandler, CExceptionObject ioExceptionObject)
        {
            if (iExceptionHandler == null)
            {
                if (CExceptionHelper.getDefaultExceptionHandler() == null)
                {
                    CExceptionHelper.throwExceptionObject(ioExceptionObject);

                    return;
                }

                CExceptionHelper.getDefaultExceptionHandler()(ioExceptionObject);

                return;
            }

            iExceptionHandler(ioExceptionObject);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioException"></param>
        public static void extInvoke(this Action<CExceptionObject> iExceptionHandler, Exception ioException)
        {
            extInvoke(iExceptionHandler, new CExceptionObject(ioException));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioException"></param>
        /// <returns></returns>
        public static TResult extInvoke<TResult>(this Func<Exception, TResult> iExceptionHandler, Exception ioException)
        {
            if (iExceptionHandler == null)
            {
                if (CExceptionHelper.getDefaultExceptionHandler() != null)
                {
                    CExceptionHelper.getDefaultExceptionHandler()(new CExceptionObject(ioException));
                }

                CExceptionHelper.throwException(ioException);

                return default(TResult);
            }

            return iExceptionHandler(ioException);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioExceptionData"></param>
        /// <returns></returns>
        public static TResult extInvoke<TData, TResult>(this Func<CExceptionData<TData>, TResult> iExceptionHandler, CExceptionData<TData> ioExceptionData)
        {
            if (iExceptionHandler == null)
            {
                if (CExceptionHelper.getDefaultExceptionHandler() != null)
                {
                    CExceptionHelper.getDefaultExceptionHandler()(ioExceptionData.extTryToObject().Item2);
                }

                CExceptionHelper.throwExceptionData(ioExceptionData);

                return default(TResult);
            }

            return iExceptionHandler(ioExceptionData);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioException"></param>
        /// <returns></returns>
        public static TResult extInvoke<TData, TResult>(this Func<CExceptionData<TData>, TResult> iExceptionHandler, Exception ioException)
        {
            return extInvoke(iExceptionHandler, new CExceptionData<TData>(ioException));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioExceptionObject"></param>
        /// <returns></returns>
        public static TResult extInvoke<TResult>(this Func<CExceptionObject, TResult> iExceptionHandler, CExceptionObject ioExceptionObject)
        {
            if (iExceptionHandler == null)
            {
                if (CExceptionHelper.getDefaultExceptionHandler() != null)
                {
                    CExceptionHelper.getDefaultExceptionHandler()(ioExceptionObject);
                }

                CExceptionHelper.throwExceptionObject(ioExceptionObject);

                return default(TResult);
            }

            return iExceptionHandler(ioExceptionObject);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iExceptionHandler"></param>
        /// <param name="ioException"></param>
        /// <returns></returns>
        public static TResult extInvoke<TResult>(this Func<CExceptionObject, TResult> iExceptionHandler, Exception ioException)
        {
            return extInvoke(iExceptionHandler, new CExceptionObject(ioException));
        }
    }
}
