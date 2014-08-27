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
using LanguageExtensions.CSharp.Model;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Observer
{
    /// <summary>
    /// ActionObserver (Event Observer) (Delegate Extensions)
    /// </summary>
    public static class CActionObserver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iEventHandler"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke(this Action iEventHandler, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument>(this Action<TArgument> iEventHandler, TArgument ioArgument, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2>(this Action<TArgument1, TArgument2> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3>(this Action<TArgument1, TArgument2, TArgument3> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4>(this Action<TArgument1, TArgument2, TArgument3, TArgument4> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <typeparam name="TArgument7"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <typeparam name="TArgument7"></typeparam>
        /// <typeparam name="TArgument8"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="ioArgument8"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, TArgument8 ioArgument8, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7, ioArgument8), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TExceptionData>(this Action iEventHandler, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument, TExceptionData>(this Action<TArgument> iEventHandler, TArgument ioArgument, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TExceptionData>(this Action<TArgument1, TArgument2> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TExceptionData>(this Action<TArgument1, TArgument2, TArgument3> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TExceptionData>(this Action<TArgument1, TArgument2, TArgument3, TArgument4> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TExceptionData>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TExceptionData>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <typeparam name="TArgument7"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TExceptionData>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <typeparam name="TArgument7"></typeparam>
        /// <typeparam name="TArgument8"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="ioArgument8"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TExceptionData>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, TArgument8 ioArgument8, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7, ioArgument8), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iEventHandler"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke(this Action iEventHandler, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument>(this Action<TArgument> iEventHandler, TArgument ioArgument, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2>(this Action<TArgument1, TArgument2> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3>(this Action<TArgument1, TArgument2, TArgument3> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4>(this Action<TArgument1, TArgument2, TArgument3, TArgument4> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <typeparam name="TArgument7"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TArgument6"></typeparam>
        /// <typeparam name="TArgument7"></typeparam>
        /// <typeparam name="TArgument8"></typeparam>
        /// <param name="iEventHandler"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="ioArgument8"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        public static void extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>(this Action<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8> iEventHandler, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, TArgument8 ioArgument8, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            CTryCatchObserver.Register(() => iEventHandler(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7, ioArgument8), iExceptionHandler, iFinalHandler);
        }
    }
}
