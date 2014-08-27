using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Diagnostics;
using System.Threading;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
using LanguageExtensions.CSharp.Internal.L1_Readonly;
using LanguageExtensions.CSharp.Internal.L2_DateTimeHelper;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L3_StaticToolbox
{
    internal static class CStaticToolbox
    {
        #region Fields and properties.
        private static Stopwatch fStopwatch; //For reflection.
        private static DateTime fCreationTime; //For reflection.

        private static readonly Process fCurrentProcess;

        private static readonly object fUniqueInt_SyncRoot;
        private static int fUniqueInt; //For reflection.

        private static readonly object fUniqueLong_SyncRoot;
        private static long fUniqueLong; //For reflection.

        private static readonly object fUniqueTime_SyncRoot;
        private static readonly TimeSpan fMinTimeUnit;
        #endregion

        #region Singleton, factory or constructor.
        static CStaticToolbox()
        {
            fStopwatch = new Stopwatch();
            //fStopwatch.Start();

            fCreationTime = (CDateTimeHelper.getTimeNow() - getElapsedTime());

            fCurrentProcess = Process.GetCurrentProcess();

            fUniqueInt_SyncRoot = new object();
            fUniqueInt = CReadonly.getUniqueIntBegin();

            fUniqueLong_SyncRoot = new object();
            fUniqueLong = CReadonly.getUniqueLongBegin();

            fUniqueTime_SyncRoot = new object();
            fMinTimeUnit = new TimeSpan(1); //0.0001 millisecond.
        }
        #endregion

        #region Methods.
        internal static DateTime getCreationTime()
        {
            return fCreationTime;
        }

        internal static TimeSpan getElapsedTime()
        {
            return fStopwatch.Elapsed;
        }

        internal static Process getCurrentProcess()
        {
            return fCurrentProcess;
        }

        internal static int getUniqueInt()
        {
            lock (fUniqueInt_SyncRoot)
            {
                return fUniqueInt++;
            }
        }

        internal static long getUniqueLong()
        {
            lock (fUniqueLong_SyncRoot)
            {
                return fUniqueLong++;
            }
        }

        /// <summary>
        /// 0.0001 millisecond.
        /// </summary>
        /// <returns></returns>
        internal static TimeSpan getMinTimeUnit()
        {
            return fMinTimeUnit;
        }

        /// <summary>
        /// 0.0001 millisecond.
        /// </summary>
        internal static void MinSleeping()
        {
            //Thread.Sleep(MinTimeUnit);
            SpinWait.SpinUntil(() => false, fMinTimeUnit);
        }

        internal static DateTime getUniqueTime()
        {
            lock (fUniqueTime_SyncRoot)
            {
                MinSleeping();

                return DateTime.UtcNow;
            }
        }

        internal static long getUniqueTicks()
        {
            return getUniqueTime().Ticks;
        }
        #endregion
    }
}
