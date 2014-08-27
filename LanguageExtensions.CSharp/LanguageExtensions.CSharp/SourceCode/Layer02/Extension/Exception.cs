using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.IO;
using System.Net;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
using LanguageExtensions.CSharp.Internal.L1_EnumerableExtensions;
using LanguageExtensions.CSharp.Internal.L1_Readonly;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L2_ExceptionExtensions
{
    internal static class CExceptionExtensions
    {
        /// <summary>
        /// Get the exceptions that each exception has Message.
        /// </summary>
        /// <param name="ioSource"></param>
        /// <returns>The exceptions that each exception has Message.</returns>
        internal static IEnumerable<Exception> extGetAllExceptions(this Exception ioSource)
        {
            Exception mSource = ioSource;

            if (mSource.extIsNull()) //Exception may be overridden.
            {
                yield break;
            }

            do
            {
                string mMessage = CConst.STRING_EMPTY;

                try //Exception may be overridden.
                {
                    mMessage = mSource.Message;
                }
                catch //(Exception mException)
                { }
                finally
                { }

                if (!string.IsNullOrWhiteSpace(mMessage))
                {
                    yield return mSource;
                }

                if (mSource is AggregateException)
                {
                    AggregateException mAggregateException = (mSource as AggregateException);

                    if (mAggregateException.InnerExceptions.extIsNull())
                    {
                        continue;
                    }

                    foreach (Exception mInnerException in mAggregateException.InnerExceptions)
                    {
                        foreach (Exception mException in extGetAllExceptions(mInnerException))
                        {
                            yield return mException;
                        }
                    }
                }
            } while ((mSource = mSource.InnerException).extIsNotNull());
        }

        internal static Tuple<bool, string> extGetResponseString(this WebException ioSource)
        {
            try //Exception may be overridden.
            {
                using (StreamReader mStreamReader = new StreamReader(ioSource.Response.GetResponseStream()))
                {
                    return new Tuple<bool, string>(true, mStreamReader.ReadToEnd());
                }
            }
            catch (Exception mException)
            {
                return new Tuple<bool, string>(false, extToString(mException));
            }
            finally
            { }
        }

        /// <summary>
        /// Get the exceptions that each exception has Message.
        /// Then merging all the exceptions to be one string.
        /// </summary>
        /// <param name="ioSource"></param>
        /// <param name="iSeparator"></param>
        /// <returns>The exceptions that each exception has Message.</returns>
        internal static string extToString(this Exception ioSource, string iSeparator = CConst.NEWLINE)
        {
            IEnumerable<Exception> mExceptions = extGetAllExceptions(ioSource);

            if (mExceptions.extIsNullOrEmpty())
            {
                return CConst.STRING_EMPTY;
            }
            else if (string.IsNullOrEmpty(iSeparator))
            {
                iSeparator = CConst.NEWLINE;
            }

            StringBuilder mExceptionString = new StringBuilder();

            return string.Join(iSeparator, mExceptions.Select(ioException =>
            {
                mExceptionString.Clear();

                try //Exception may be overridden.
                {
                    for (int i = CConst.BEGIN_INDEX; i < CReadonly.getExceptionFormat().Count; i++)
                    {
                        switch (CReadonly.getExceptionFormat()[i])
                        {
                            case CConfigValue.EXCEPTION_TYPE:
                                {
                                    mExceptionString.Append(ioException.GetType().Name).Append(CReadonly.getSeparator());
                                }
                                break;

                            case CConfigValue.EXCEPTION_MESSAGE:
                                {
                                    mExceptionString.Append(ioException.Message).Append(CReadonly.getSeparator());
                                }
                                break;

                            case CConfigValue.EXCEPTION_RESPONSE_STRING:
                                {
                                    WebException mWebException = (ioException as WebException);

                                    if (mWebException == null)
                                    {
                                        break;
                                    }

                                    string mResponse = extGetResponseString(mWebException).Item2;

                                    if (string.IsNullOrWhiteSpace(mResponse))
                                    {
                                        break;
                                    }

                                    mExceptionString.Append(mResponse).Append(CReadonly.getSeparator());
                                }
                                break;

                            case CConfigValue.EXCEPTION_HELPLINK:
                                {
                                    string mHelpLink = ioException.HelpLink;

                                    if (string.IsNullOrWhiteSpace(mHelpLink))
                                    {
                                        break;
                                    }

                                    mExceptionString.Append(mHelpLink).Append(CReadonly.getSeparator());
                                }
                                break;

                            case CConfigValue.EXCEPTION_RESPONSE_URI:
                                {
                                    WebException mWebException = (ioException as WebException);

                                    if (mWebException == null)
                                    {
                                        break;
                                    }

                                    Uri mURI = mWebException.Response.ResponseUri;

                                    if (mURI == null)
                                    {
                                        break;
                                    }

                                    mExceptionString.Append(mURI).Append(CReadonly.getSeparator());
                                }
                                break;

                            case CConfigValue.EXCEPTION_STACKTRACE:
                                {
                                    string mStackTrace = ioException.StackTrace;

                                    if (string.IsNullOrWhiteSpace(mStackTrace))
                                    {
                                        break;
                                    }

                                    mExceptionString.Append(mStackTrace).Append(CReadonly.getSeparator());
                                }
                                break;

                            case CConfigValue.EXCEPTION_TOSTRING:
                                {
                                    string mString = ioException.ToString();

                                    if (string.IsNullOrWhiteSpace(mString))
                                    {
                                        break;
                                    }

                                    mExceptionString.Append(mString).Append(CReadonly.getSeparator());
                                }
                                break;

                            default:
                                break;
                        }
                    }

                    if ((CReadonly.getSeparatorHead().Length > CConst.ZERO) && (mExceptionString.Length >= CReadonly.getSeparatorHead().Length))
                    {
                        mExceptionString.Replace(CReadonly.getSeparatorHead(), CConst.STRING_EMPTY, (mExceptionString.Length - CReadonly.getSeparatorHead().Length), CReadonly.getSeparatorHead().Length);
                    }

                    if (!CReadonly.getBucket().Equals(CConst.FORMAT_INITIAL))
                    {
                        mExceptionString = new StringBuilder(string.Format(CReadonly.getBucket(), mExceptionString));
                    }
                }
                catch //(Exception mException)
                { }
                finally
                { }

                return mExceptionString.ToString();
            }));
        }
    }
}
