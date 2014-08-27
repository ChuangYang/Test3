using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Threading;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
using LanguageExtensions.CSharp.Model;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Observer
{
    /// <summary>
    /// TryCatchObserver
    /// </summary>
    public static class CTryCatchObserver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        public static void Register(Action iTry, Action<Exception> iException, Action iFinally = null)
        {
            try
            {
                iTry();
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        public static void Register<T>(Action iTry, Action<CExceptionData<T>> iException, Action iFinally = null)
        {
            try
            {
                iTry();
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        public static void Register(Action iTry, Action<CExceptionObject> iException, Action iFinally = null)
        {
            try
            {
                iTry();
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException, null);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTryLock"></typeparam>
        /// <param name="ioSyncRoot"></param>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static bool Register<TTryLock>(TTryLock ioSyncRoot, Action iTry, Action<Exception> iException, Action iFinally = null)
        {
            if (ioSyncRoot.extIsNull())
            {
                iException.extInvoke(new ArgumentNullException("if (ioSyncRoot.extIsNull())"));

                return false;
            }
            else if (!Monitor.TryEnter(ioSyncRoot))
            {
                return false;
            }

            try
            {
                iTry();

                return true;
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return false;
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException);
                }

                Register(() => Monitor.Exit(ioSyncRoot), iException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTryLock"></typeparam>
        /// <typeparam name="TData"></typeparam>
        /// <param name="ioSyncRoot"></param>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static bool Register<TTryLock, TData>(TTryLock ioSyncRoot, Action iTry, Action<CExceptionData<TData>> iException, Action iFinally = null)
        {
            if (ioSyncRoot.extIsNull())
            {
                iException.extInvoke(new ArgumentNullException("if (ioSyncRoot.extIsNull())"));

                return false;
            }
            else if (!Monitor.TryEnter(ioSyncRoot))
            {
                return false;
            }

            try
            {
                iTry();

                return true;
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return false;
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException);
                }

                Register(() => Monitor.Exit(ioSyncRoot), iException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTryLock"></typeparam>
        /// <param name="ioSyncRoot"></param>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static bool Register<TTryLock>(TTryLock ioSyncRoot, Action iTry, Action<CExceptionObject> iException, Action iFinally = null)
        {
            if (ioSyncRoot.extIsNull())
            {
                iException.extInvoke(new ArgumentNullException("if (ioSyncRoot.extIsNull())"));

                return false;
            }
            else if (!Monitor.TryEnter(ioSyncRoot))
            {
                return false;
            }

            try
            {
                iTry();

                return true;
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return false;
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException, null);
                }

                Register(() => Monitor.Exit(ioSyncRoot), iException, null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> Return<TResult>(Func<TResult> iTry, Action<Exception> iException, Action iFinally = null)
        {
            try
            {
                return new Tuple<bool, TResult>(true, iTry());
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> Return<TData, TResult>(Func<TResult> iTry, Action<CExceptionData<TData>> iException, Action iFinally = null)
        {
            try
            {
                return new Tuple<bool, TResult>(true, iTry());
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> Return<TResult>(Func<TResult> iTry, Action<CExceptionObject> iException, Action iFinally = null)
        {
            try
            {
                return new Tuple<bool, TResult>(true, iTry());
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException, null);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTryLock"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="ioSyncRoot"></param>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> Return<TTryLock, TResult>(TTryLock ioSyncRoot, Func<TResult> iTry, Action<Exception> iException, Action iFinally = null)
        {
            if (ioSyncRoot.extIsNull())
            {
                iException.extInvoke(new ArgumentNullException("if (ioSyncRoot.extIsNull())"));

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            else if (!Monitor.TryEnter(ioSyncRoot))
            {
                return new Tuple<bool, TResult>(false, default(TResult));
            }

            try
            {
                return new Tuple<bool, TResult>(true, iTry());
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException);
                }

                Register(() => Monitor.Exit(ioSyncRoot), iException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTryLock"></typeparam>
        /// <typeparam name="TData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="ioSyncRoot"></param>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> Return<TTryLock, TData, TResult>(TTryLock ioSyncRoot, Func<TResult> iTry, Action<CExceptionData<TData>> iException, Action iFinally = null)
        {
            if (ioSyncRoot.extIsNull())
            {
                iException.extInvoke(new ArgumentNullException("if (ioSyncRoot.extIsNull())"));

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            else if (!Monitor.TryEnter(ioSyncRoot))
            {
                return new Tuple<bool, TResult>(false, default(TResult));
            }

            try
            {
                return new Tuple<bool, TResult>(true, iTry());
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException);
                }

                Register(() => Monitor.Exit(ioSyncRoot), iException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTryLock"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="ioSyncRoot"></param>
        /// <param name="iTry"></param>
        /// <param name="iException"></param>
        /// <param name="iFinally"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> Return<TTryLock, TResult>(TTryLock ioSyncRoot, Func<TResult> iTry, Action<CExceptionObject> iException, Action iFinally = null)
        {
            if (ioSyncRoot.extIsNull())
            {
                iException.extInvoke(new ArgumentNullException("if (ioSyncRoot.extIsNull())"));

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            else if (!Monitor.TryEnter(ioSyncRoot))
            {
                return new Tuple<bool, TResult>(false, default(TResult));
            }

            try
            {
                return new Tuple<bool, TResult>(true, iTry());
            }
            catch (Exception mException)
            {
                iException.extInvoke(mException);

                return new Tuple<bool, TResult>(false, default(TResult));
            }
            finally
            {
                if (iFinally != null)
                {
                    Register(iFinally, iException, null);
                }

                Register(() => Monitor.Exit(ioSyncRoot), iException, null);
            }
        }
    }
}
