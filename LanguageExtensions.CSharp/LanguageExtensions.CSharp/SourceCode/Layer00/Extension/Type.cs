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
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Internal.L0_TypeExtensions
{
    internal static class CTypeExtensions
    {
        #region Fields and properties.
        private static readonly BindingFlags fDefaultBindingFlags;
        #endregion

        #region Singleton, factory or constructor.
        static CTypeExtensions()
        {
            fDefaultBindingFlags = (BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.CreateInstance);
        }
        #endregion

        #region Methods.
        internal static BindingFlags getDefaultBindingFlags()
        {
            return fDefaultBindingFlags;
        }

        internal static FieldInfo extGetField(this _Type ioType, string iName, BindingFlags? iBindingFlags = null)
        {
            return ioType.GetField(iName, (iBindingFlags ?? fDefaultBindingFlags));
        }

        internal static FieldInfo extGetField(this Type ioType, string iName, BindingFlags? iBindingFlags = null)
        {
            return extGetField((ioType as _Type), iName, iBindingFlags);
        }

        internal static FieldInfo[] extGetFields(this _Type ioType, BindingFlags? iBindingFlags = null)
        {
            return ioType.GetFields(iBindingFlags ?? fDefaultBindingFlags);
        }

        internal static FieldInfo[] extGetFields(this Type ioType, BindingFlags? iBindingFlags = null)
        {
            return extGetFields((ioType as _Type), iBindingFlags);
        }

        internal static FieldInfo[] extGetFields(this _Type ioType, IEnumerable<string> ioNames, BindingFlags? iBindingFlags = null)
        {
            return ioNames.Select(iName => extGetField(ioType, iName, iBindingFlags)).ToArray();
        }

        internal static FieldInfo[] extGetFields(this Type ioType, IEnumerable<string> ioNames, BindingFlags? iBindingFlags = null)
        {
            return extGetFields((ioType as _Type), ioNames, iBindingFlags);
        }

        internal static MethodInfo extGetMethod(this _Type ioType, string iName, BindingFlags? iBindingFlags = null)
        {
            return ioType.GetMethod(iName, (iBindingFlags ?? fDefaultBindingFlags));
        }

        internal static MethodInfo extGetMethod(this Type ioType, string iName, BindingFlags? iBindingFlags = null)
        {
            return extGetMethod((ioType as _Type), iName, iBindingFlags);
        }

        internal static MethodInfo[] extGetMethods(this _Type ioType, BindingFlags? iBindingFlags = null)
        {
            return ioType.GetMethods(iBindingFlags ?? fDefaultBindingFlags);
        }

        internal static MethodInfo[] extGetMethods(this Type ioType, BindingFlags? iBindingFlags = null)
        {
            return extGetMethods((ioType as _Type), iBindingFlags);
        }

        internal static MethodInfo[] extGetMethods(this _Type ioType, IEnumerable<string> ioNames, BindingFlags? iBindingFlags = null)
        {
            return ioNames.Select(iName => extGetMethod(ioType, iName, iBindingFlags)).ToArray();
        }

        internal static MethodInfo[] extGetMethods(this Type ioType, IEnumerable<string> ioNames, BindingFlags? iBindingFlags = null)
        {
            return extGetMethods((ioType as _Type), ioNames, iBindingFlags);
        }
        #endregion
    }
}
