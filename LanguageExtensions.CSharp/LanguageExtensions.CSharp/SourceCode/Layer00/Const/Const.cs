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
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.Const
{
    /// <summary>
    /// Const
    /// </summary>
    public static class CConst
    {
        /// <summary>
        /// 0
        /// </summary>
        public const int BEGIN_INDEX = 0;

        /// <summary>
        /// 0
        /// </summary>
        public const int EMPTY = 0;

        /// <summary>
        /// 0
        /// </summary>
        public const int ZERO = 0;

        /// <summary>
        /// -1
        /// </summary>
        public const int ALL_ITEMS = -1;

        /// <summary>
        /// -1
        /// </summary>
        public const int NOT_FOUND = (BEGIN_INDEX - 1);

        /// <summary>
        /// 1 == 100%
        /// </summary>
        public const int COMPLETED = 1;

        /// <summary>
        /// 1
        /// </summary>
        public const int DEFAULT_EXCEPTION_LEVEL = 1;

        /// <summary>
        /// ""
        /// </summary>
        public const string STRING_EMPTY = "";

        /// <summary>
        /// " "
        /// </summary>
        public const string STRING_BLANK = " ";

        /// <summary>
        /// "{"
        /// </summary>
        public const string FORMAT_HEAD = "{";

        /// <summary>
        /// "}"
        /// </summary>
        public const string FORMAT_TAIL = "}";

        /// <summary>
        /// "{0}"
        /// </summary>
        public const string FORMAT_INITIAL = "{0}";

        /// <summary>
        /// "\r\n"
        /// </summary>
        public const string NEWLINE = "\r\n";

        /// <summary>
        /// "SEPARATOR"
        /// </summary>
        public const string SEPARATOR = "SEPARATOR";
    }
}
