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
    /// FuncObserver (Event Observer) (Delegate Extensions)
    /// </summary>
    public static class CFuncObserver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TResult>(this Func<TResult> iFunc, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument, TResult>(this Func<TArgument, TResult> iFunc, TArgument ioArgument, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TResult>(this Func<TArgument1, TArgument2, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TResult>(this Func<TArgument1, TArgument2, TArgument3, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
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
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, TArgument8 ioArgument8, Action<Exception> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7, ioArgument8), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TExceptionData, TResult>(this Func<TResult> iFunc, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument, TExceptionData, TResult>(this Func<TArgument, TResult> iFunc, TArgument ioArgument, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TExceptionData, TResult>(this Func<TArgument1, TArgument2, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TExceptionData, TResult>(this Func<TArgument1, TArgument2, TArgument3, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TExceptionData"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TExceptionData, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TExceptionData, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TExceptionData, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TExceptionData, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
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
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TExceptionData, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, TArgument8 ioArgument8, Action<CExceptionData<TExceptionData>> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7, ioArgument8), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TResult>(this Func<TResult> iFunc, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument, TResult>(this Func<TArgument, TResult> iFunc, TArgument ioArgument, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TResult>(this Func<TArgument1, TArgument2, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TResult>(this Func<TArgument1, TArgument2, TArgument3, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4), iExceptionHandler, iFinalHandler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgument1"></typeparam>
        /// <typeparam name="TArgument2"></typeparam>
        /// <typeparam name="TArgument3"></typeparam>
        /// <typeparam name="TArgument4"></typeparam>
        /// <typeparam name="TArgument5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
        /// <param name="ioArgument1"></param>
        /// <param name="ioArgument2"></param>
        /// <param name="ioArgument3"></param>
        /// <param name="ioArgument4"></param>
        /// <param name="ioArgument5"></param>
        /// <param name="ioArgument6"></param>
        /// <param name="ioArgument7"></param>
        /// <param name="iExceptionHandler"></param>
        /// <param name="iFinalHandler"></param>
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7), iExceptionHandler, iFinalHandler);
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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="iFunc"></param>
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
        /// <returns></returns>
        public static Tuple<bool, TResult> extInvoke<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TResult>(this Func<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TResult> iFunc, TArgument1 ioArgument1, TArgument2 ioArgument2, TArgument3 ioArgument3, TArgument4 ioArgument4, TArgument5 ioArgument5, TArgument6 ioArgument6, TArgument7 ioArgument7, TArgument8 ioArgument8, Action<CExceptionObject> iExceptionHandler, Action iFinalHandler = null)
        {
            return CTryCatchObserver.Return(() => iFunc(ioArgument1, ioArgument2, ioArgument3, ioArgument4, ioArgument5, ioArgument6, ioArgument7, ioArgument8), iExceptionHandler, iFinalHandler);
        }
    }
}
