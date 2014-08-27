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
using LanguageExtensions.CSharp.Interface;
using LanguageExtensions.CSharp.Internal.L2_DateTimeHelper;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Model
{
    /// <summary>
    /// ExceptionData
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CExceptionData<T> : Tuple<DateTime, int, Exception, T>, ICreate
    {
        #region Fields and properties.
        #endregion

        #region Singleton, factory or constructor.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ioException"></param>
        /// <param name="ioData"></param>
        /// <param name="iLevel"></param>
        public CExceptionData(Exception ioException, T ioData = default(T), int iLevel = CConst.DEFAULT_EXCEPTION_LEVEL)
            : base(CDateTimeHelper.getTimeNow(), iLevel, (ioException ?? new ArgumentNullException("ioException == null")), ioData)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iLevel"></param>
        /// <param name="ioException"></param>
        /// <param name="ioData"></param>
        public CExceptionData(int iLevel, Exception ioException, T ioData = default(T))
            : this(ioException, ioData, iLevel)
        { }
        #endregion

        #region Methods.
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime getCreationTime()
        {
            return Item1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TimeSpan getElapsedTime()
        {
            return (CDateTimeHelper.getTimeNow() - getCreationTime());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getLevel()
        {
            return Item2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Exception getException()
        {
            return Item3;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T getData()
        {
            return Item4;
        }
        #endregion
    }
}
