using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.Configuration;
using System.Diagnostics;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
using LanguageExtensions.CSharp.Internal.L0_ConfigurationExtensions;
using LanguageExtensions.CSharp.Internal.L0_TypeExtensions;
using LanguageExtensions.CSharp.Internal.L1_Readonly;
using LanguageExtensions.CSharp.Internal.L1_StringHelper;
using LanguageExtensions.CSharp.Internal.L2_DateTimeHelper;
using LanguageExtensions.CSharp.Internal.L3_StaticToolbox;
using LanguageExtensions.CSharp.Internal.L5_ExceptionHelper;
using LanguageExtensions.CSharp.Model;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L7_Entrance
{
    internal static class CEntrance
    {
        #region Fields and properties.
        #endregion

        #region Singleton, factory or constructor.
        static CEntrance()
        { }
        #endregion

        #region Methods.
        private static void Register(Action<CExceptionData<object>> ioDefaultExceptionHandler, Configuration ioConfiguration = null)
        {
            Stopwatch mStopwatch = new Stopwatch();
            mStopwatch.Start();

            if (CExceptionHelper.getDefaultExceptionHandler() != null)
            {
                throw new MethodAccessException("if (CExceptionHelper.getDefaultExceptionHandler() != null)");
            }
            else if (ioDefaultExceptionHandler == null)
            {
                throw new ArgumentNullException("else if (ioDefaultExceptionHandler == null)");
            }
            else if (CStaticToolbox.getElapsedTime() > default(TimeSpan))
            {
                throw new MethodAccessException(string.Format("else if ({0} > default(TimeSpan))", CStaticToolbox.getElapsedTime()));
            }

            typeof(CExceptionHelper).extGetField("fDefaultExceptionHandler").SetValue(null, ioDefaultExceptionHandler);

            Configuration mConfiguration = null;

            try
            {
                mConfiguration = (ioConfiguration ?? ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None));
            }
            catch //(Exception mException)
            { }
            finally
            { }

            if (mConfiguration != null)
            {
                foreach (string mKey in mConfiguration.extSettings().AllKeys)
                {
                    string mValue = mConfiguration.extSettings()[mKey].Value;

                    if (mValue == null)
                    {
                        continue;
                    }

                    switch (mKey)
                    {
                        case CConfigKey.COM_VISIBLE:
                            {
                                if (CStringHelper.isFalse(ref mValue))
                                {
                                    typeof(CReadonly).extGetField("fIsComVisible").SetValue(null, false);
                                }
                            }
                            break;

                        case CConfigKey.DATETIME_KIND:
                            {
                                if (!mValue.extEquals(CConfigValue.UTC, StringComparison.OrdinalIgnoreCase))
                                {
                                    break;
                                }

                                typeof(CReadonly).extGetField("fDateTimeKind").SetValue(null, DateTimeKind.Utc);
                                typeof(CDateTimeHelper).extGetField("fDateTimeMin").SetValue(null, new DateTime(DateTime.MinValue.Ticks, CReadonly.getDateTimeKind()));
                                typeof(CDateTimeHelper).extGetField("fDateTimeMax").SetValue(null, new DateTime(DateTime.MaxValue.Ticks, CReadonly.getDateTimeKind()));
                            }
                            break;

                        case CConfigKey.DATETIME_FORMAT_SQL:
                            {
                                typeof(CReadonly).extGetField("fDateTimeSQLFormat").SetValue(null, (string.IsNullOrWhiteSpace(mValue) ? CConst.STRING_EMPTY : mValue));
                            }
                            break;

                        case CConfigKey.SEPARATOR_HEAD:
                            {
                                typeof(CReadonly).extGetField("fSeparatorHead").SetValue(null, mValue);
                                typeof(CReadonly).extGetField("fSeparator").SetValue(null, string.Format("{0}{1}", CReadonly.getSeparatorTail(), CReadonly.getSeparatorHead()));

                                typeof(CReadonly).extGetField("fBucket").SetValue(null,
                                    ((string.IsNullOrWhiteSpace(CReadonly.getSeparatorHead()) || CReadonly.getSeparatorTail().Contains(CConst.NEWLINE)) ?
                                    CConst.FORMAT_INITIAL :
                                    string.Format("{0}{1}{2}", CReadonly.getSeparatorHead(), CConst.FORMAT_INITIAL, CReadonly.getSeparatorTail()))
                                    );
                            }
                            break;

                        case CConfigKey.SEPARATOR_TAIL:
                            {
                                typeof(CReadonly).extGetField("fSeparatorTail").SetValue(null, mValue);
                                typeof(CReadonly).extGetField("fSeparator").SetValue(null, string.Format("{0}{1}", CReadonly.getSeparatorTail(), CReadonly.getSeparatorHead()));

                                typeof(CReadonly).extGetField("fBucket").SetValue(null,
                                    ((string.IsNullOrWhiteSpace(CReadonly.getSeparatorHead()) || CReadonly.getSeparatorTail().Contains(CConst.NEWLINE)) ?
                                    CConst.FORMAT_INITIAL :
                                    string.Format("{0}{1}{2}", CReadonly.getSeparatorHead(), CConst.FORMAT_INITIAL, CReadonly.getSeparatorTail()))
                                    );
                            }
                            break;

                        case CConfigKey.EXCEPTION_FORMAT:
                            {
                                List<string> mFormats = new List<string>();

                                foreach (string mFormat in mValue.Replace(CConst.STRING_BLANK, CConst.STRING_EMPTY).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                                {
                                    switch (mFormat.ToUpper())
                                    {
                                        case CConfigValue.EXCEPTION_TYPE:
                                        case CConfigValue.EXCEPTION_MESSAGE:
                                        case CConfigValue.EXCEPTION_RESPONSE_STRING:
                                        case CConfigValue.EXCEPTION_RESPONSE_URI:
                                        case CConfigValue.EXCEPTION_HELPLINK:
                                        case CConfigValue.EXCEPTION_STACKTRACE:
                                        case CConfigValue.EXCEPTION_TOSTRING:
                                            mFormats.Add(mFormat);
                                            break;

                                        default:
                                            break;
                                    }
                                }

                                typeof(CReadonly).extGetField("fExceptionFormat").SetValue(null, new SynchronizedReadOnlyCollection<string>(new object(), mFormats));
                            }
                            break;

                        case CConfigKey.UNIQUE_INT_BEGIN:
                            {
                                Tuple<bool, int> mResult = CStringHelper.tryToInt(ref mValue);

                                if (!mResult.Item1)
                                {
                                    break;
                                }

                                typeof(CStaticToolbox).extGetField("fUniqueInt").SetValue(null, mResult.Item2);
                            }
                            break;

                        case CConfigKey.UNIQUE_LONG_BEGIN:
                            {
                                Tuple<bool, long> mResult = CStringHelper.tryToLong(ref mValue);

                                if (!mResult.Item1)
                                {
                                    break;
                                }

                                typeof(CStaticToolbox).extGetField("fUniqueLong").SetValue(null, mResult.Item2);
                            }
                            break;

                        default:
                            break;
                    }
                }
            }

            typeof(CStaticToolbox).extGetField("fStopwatch").SetValue(null, mStopwatch);
            typeof(CStaticToolbox).extGetField("fCreationTime").SetValue(null, (CDateTimeHelper.getTimeNow() - mStopwatch.Elapsed));
        }
        #endregion
    }
}
