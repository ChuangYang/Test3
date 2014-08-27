using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region .NET Framework namespace.
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
using LanguageExtensions.CSharp.Internal.L0_ObjectExtensions;
using LanguageExtensions.CSharp.Internal.L1_CollectionExtensions;
using LanguageExtensions.CSharp.Internal.L1_EnumerableExtensions;
using LanguageExtensions.CSharp.Observer;
#endregion

#region Set the aliases.
using CL0TypeExtensions = LanguageExtensions.CSharp.Internal.L0_TypeExtensions.CTypeExtensions;
#endregion

namespace LanguageExtensions.CSharp.Internal.L7_TypeExtensions
{
    internal static class CTypeExtensions
    {
        internal static bool extIsFlagEnum(this _Type ioType, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return false;
            }
            else if (!ioType.IsEnum)
            {
                return false;
            }

            return ioType.GetCustomAttributes(typeof(FlagsAttribute), false).extIsNotEmpty();
        }

        internal static bool extIsFlagEnum(this Type ioType, Action<Exception> iExceptionHandler = null)
        {
            return extIsFlagEnum((ioType as _Type), iExceptionHandler);
        }

        internal static bool extIsStaticClass(this _Type ioType, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return false;
            }
            else if (ioType.BaseType.extIsNull())
            {
                return false;
            }
            else if (!ioType.BaseType.Equals(typeof(object)))
            {
                return false;
            }
            else if (!(ioType.IsClass && ioType.IsAbstract && ioType.IsSealed))
            {
                return false;
            }

            ConstructorInfo[] mConstructors = ioType.GetConstructors(BindingFlags.Static | BindingFlags.NonPublic);

            if (mConstructors.Length == CConst.EMPTY) //If these is no definition in the code.
            {
                return true;
            }
            else if (mConstructors.Length > 1) //Static class only has one constructor.
            {
                return false;
            }

            ConstructorInfo mConstructor = mConstructors[CConst.BEGIN_INDEX];

            return (mConstructor.IsPrivate && mConstructor.IsSpecialName && mConstructor.IsStatic);
        }

        internal static bool extIsStaticClass(this Type ioType, Action<Exception> iExceptionHandler = null)
        {
            return extIsStaticClass((ioType as _Type), iExceptionHandler);
        }

        internal static string[] extGetDescriptions(this _Type ioType, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return new string[CConst.EMPTY];
            }

            return Array.ConvertAll((ioType.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[]), (ioAttribute => ioAttribute.Description));
        }

        internal static string[] extGetDescriptions(this Type ioType, Action<Exception> iExceptionHandler = null)
        {
            return extGetDescriptions((ioType as _Type), iExceptionHandler);
        }

        internal static string[] extGetMemberDescriptions(this _Type ioType, string iName, MemberTypes iMemberTypes = MemberTypes.All, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return new string[CConst.EMPTY];
            }
            else if (string.IsNullOrWhiteSpace(iName))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (string.IsNullOrWhiteSpace(iName))"));

                return new string[CConst.EMPTY];
            }

            MemberInfo[] mMemberInfos = ioType.GetMember(iName, iMemberTypes, (iBindingFlags ?? CL0TypeExtensions.getDefaultBindingFlags()));

            IEnumerable<DescriptionAttribute> mDescriptions = mMemberInfos.SelectMany(ioMemberInfo => (ioMemberInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[]));

            return mDescriptions.Select(ioAttribute => ioAttribute.Description).ToArray();
        }

        internal static string[] extGetMemberDescriptions(this Type ioType, string iName, MemberTypes iMemberTypes = MemberTypes.All, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            return extGetMemberDescriptions((ioType as _Type), iName, iMemberTypes, iBindingFlags, iExceptionHandler);
        }

        internal static FieldInfo extGetField(this _Type ioType, string iName, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return null;
            }
            else if (string.IsNullOrWhiteSpace(iName))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (string.IsNullOrWhiteSpace(iName))"));

                return null;
            }

            return CL0TypeExtensions.extGetField(ioType, iName, iBindingFlags);
        }

        internal static FieldInfo extGetField(this Type ioType, string iName, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            return extGetField((ioType as _Type), iName, iBindingFlags, iExceptionHandler);
        }

        internal static FieldInfo[] extGetFields(this _Type ioType, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return new FieldInfo[CConst.EMPTY];
            }

            return CL0TypeExtensions.extGetFields(ioType, iBindingFlags);
        }

        internal static FieldInfo[] extGetFields(this Type ioType, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            return extGetFields((ioType as _Type), iBindingFlags, iExceptionHandler);
        }

        internal static FieldInfo[] extGetFields(this _Type ioType, IEnumerable<string> ioNames, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return new FieldInfo[CConst.EMPTY];
            }
            else if (ioNames.extIsNullOrEmpty())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (ioNames.enumerableIsNullOrEmpty())"));

                return new FieldInfo[CConst.EMPTY];
            }

            return ioNames.Select(iName => ioType.extGetField(iName, iBindingFlags, iExceptionHandler)).ToArray();
        }

        internal static FieldInfo[] extGetFields(this Type ioType, IEnumerable<string> ioNames, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            return extGetFields((ioType as _Type), ioNames, iBindingFlags, iExceptionHandler);
        }

        internal static MethodInfo extGetMethod(this _Type ioType, string iName, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return null;
            }
            else if (string.IsNullOrWhiteSpace(iName))
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (string.IsNullOrWhiteSpace(iName))"));

                return null;
            }

            return CL0TypeExtensions.extGetMethod(ioType, iName, iBindingFlags);
        }

        internal static MethodInfo extGetMethod(this Type ioType, string iName, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            return extGetMethod((ioType as _Type), iName, iBindingFlags, iExceptionHandler);
        }

        internal static MethodInfo[] extGetMethods(this _Type ioType, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return new MethodInfo[CConst.EMPTY];
            }

            return CL0TypeExtensions.extGetMethods(ioType, iBindingFlags);
        }

        internal static MethodInfo[] extGetMethods(this Type ioType, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            return extGetMethods((ioType as _Type), iBindingFlags, iExceptionHandler);
        }

        internal static MethodInfo[] extGetMethods(this _Type ioType, IEnumerable<string> ioNames, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            if (ioType.extIsNull())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("if (ioType.extIsNull())"));

                return new MethodInfo[CConst.EMPTY];
            }
            else if (ioNames.extIsNullOrEmpty())
            {
                iExceptionHandler.extInvoke(new ArgumentNullException("else if (ioNames.enumerableIsNullOrEmpty())"));

                return new MethodInfo[CConst.EMPTY];
            }

            return ioNames.Select(iName => ioType.extGetMethod(iName, iBindingFlags, iExceptionHandler)).ToArray();
        }

        internal static MethodInfo[] extGetMethods(this Type ioType, IEnumerable<string> ioNames, BindingFlags? iBindingFlags = null, Action<Exception> iExceptionHandler = null)
        {
            return extGetMethods((ioType as _Type), ioNames, iBindingFlags, iExceptionHandler);
        }
    }
}
