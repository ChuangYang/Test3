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
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
using LanguageExtensions.CSharp.Observer;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L7_EnumerableTExtensions
{
    internal static class CEnumerableTExtensions
    {
        internal const int DEFAULT_SHUFFLING_TIMES = 2;

        internal static Tuple<bool, T> extFirstOrDefault<T>(this IEnumerable<T> ioSource, Action<Exception> iExceptionHandler = null)
        {
            return CTryCatchObserver.Return(() => ioSource.First(), iExceptionHandler);
        }

        internal static Tuple<bool, T> extFirstOrDefault<T>(this IEnumerable<T> ioSource, Func<T, bool> iPredicate, Action<Exception> iExceptionHandler = null)
        {
            return CTryCatchObserver.Return(() => ((iPredicate == null) ? ioSource.First() : ioSource.First(iPredicate)), iExceptionHandler);
        }

        internal static Tuple<bool, T> extSingleOrDefault<T>(this IEnumerable<T> ioSource, Action<Exception> iExceptionHandler = null)
        {
            Tuple<bool, T> mSingleOrDefault = CTryCatchObserver.Return(() => ioSource.SingleOrDefault(), iExceptionHandler);

            return (mSingleOrDefault.Item1 ? mSingleOrDefault : new Tuple<bool, T>(false, ioSource.First()));
        }

        internal static Tuple<bool, T> extSingleOrDefault<T>(this IEnumerable<T> ioSource, Func<T, bool> iPredicate, Action<Exception> iExceptionHandler = null)
        {
            Tuple<bool, T> mSingleOrDefault = CTryCatchObserver.Return(() => ((iPredicate == null) ? ioSource.SingleOrDefault() : ioSource.SingleOrDefault(iPredicate)), iExceptionHandler);

            return (mSingleOrDefault.Item1 ? mSingleOrDefault : new Tuple<bool, T>(false, ((iPredicate == null) ? ioSource.First() : ioSource.First(iPredicate))));
        }

        private static IEnumerable<T> SkipThanTake<T>(this IEnumerable<T> ioSource, int iBeginIndex = CConst.BEGIN_INDEX, int iCount = CConst.ALL_ITEMS)
        {
            //if (iCount == CConst.EMPTY)
            //{
            //    yield break;
            //}

            //if (iBeginIndex < CConst.BEGIN_INDEX)
            //{
            //    iBeginIndex = CConst.BEGIN_INDEX;
            //}

            //if ((iBeginIndex == CConst.BEGIN_INDEX) && (iCount <= CConst.ALL_ITEMS))
            //{
            //    foreach (T mItem in ioSource)
            //    {
            //        yield return mItem;
            //    }

            //    yield break;
            //}

            //int mIndex = CConst.BEGIN_INDEX;

            //if (iCount <= CConst.ALL_ITEMS)
            //{
            //    foreach (T mItem in ioSource)
            //    {
            //        if ((mIndex++) >= iBeginIndex)
            //        {
            //            yield return mItem;
            //        }
            //    }

            //    yield break;
            //}

            //int mCount = CConst.EMPTY;

            //foreach (T mItem in ioSource)
            //{
            //    if ((mIndex++) >= iBeginIndex)
            //    {
            //        yield return mItem;

            //        if ((++mCount) == iCount)
            //        {
            //            yield break;
            //        }
            //    }
            //}

            if (iCount == CConst.EMPTY)
            {
                return new T[CConst.EMPTY];
            }
            else if (iBeginIndex < CConst.BEGIN_INDEX)
            {
                iBeginIndex = CConst.BEGIN_INDEX;
            }

            return ((iCount <= CConst.ALL_ITEMS) ? ioSource.Skip(iBeginIndex) : ioSource.Skip(iBeginIndex).Take(iCount));
        }

        internal static IEnumerable<T> extSkipThanTake<T>(this IEnumerable<T> ioSource, int iBeginIndex = CConst.BEGIN_INDEX, int iCount = CConst.ALL_ITEMS, Action<Exception> iExceptionHandler = null)
        {
            return CTryCatchObserver.Return(() => SkipThanTake<T>(ioSource, iBeginIndex, iCount), iExceptionHandler).Item2;
        }

        internal static IEnumerable<T> extSkipThanTake<T>(this IEnumerable<T> ioSource, Action<Exception> iExceptionHandler)
        {
            return ioSource.extSkipThanTake<T>(CConst.BEGIN_INDEX, CConst.ALL_ITEMS, iExceptionHandler);
        }

        internal static T[] extShuffleItems<T>(this IEnumerable<T> ioBucket, Random ioRandom, int iShufflingTimes = DEFAULT_SHUFFLING_TIMES, Action<Exception> iExceptionHandler = null)
        {
            if (ioBucket.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioBucket.extIsNull())"));

                return new T[CConst.EMPTY];
            }
            else if (ioRandom.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (ioRandom.extIsNull())"));

                return ioBucket.ToArray();
            }

            T[] mBucket = ((ioBucket is T[]) ? (ioBucket as T[]) : ioBucket.ToArray());
            int mLength = mBucket.Length;

            if (mLength <= 1)
            {
                return mBucket;
            }
            else if (iShufflingTimes <= CConst.ZERO)
            {
                return mBucket;
            }

            int mHelfRight = ((int)Math.Ceiling(mLength / 2.0f) + 1);
            int mHelfLeft = ((int)Math.Floor(mLength / 2.0f) - 1);

            for (int i = CConst.BEGIN_INDEX; i < mHelfRight; i++)
            {
                int mRandomNumber = (ioRandom.Next(mHelfRight) + mHelfLeft);

                T mItem = mBucket[i];
                mBucket[i] = mBucket[mRandomNumber];
                mBucket[mRandomNumber] = mItem;
            }

            return (((--iShufflingTimes) > CConst.ZERO) ? extShuffleItems(mBucket, ioRandom, iShufflingTimes, iExceptionHandler) : mBucket);
        }

        internal static T[] extShuffleItems<T>(this IEnumerable<T> ioBucket, Random ioRandom, Action<Exception> iExceptionHandler, int iShufflingTimes = DEFAULT_SHUFFLING_TIMES)
        {
            return extShuffleItems<T>(ioBucket, ioRandom, iShufflingTimes, iExceptionHandler);
        }
    }
}
