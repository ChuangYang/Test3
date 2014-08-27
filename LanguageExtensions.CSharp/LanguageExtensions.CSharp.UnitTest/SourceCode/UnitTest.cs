using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#region .NET Framework namespace.
#endregion

#region Third party library.
#endregion

#region Company's library.
using LanguageExtensions.CSharp.Const;
#endregion

#region Set the aliases.
#endregion

namespace LanguageExtensions.CSharp.UnitTest
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class CUnitTest
    {
        #region Fields and properties.
        #endregion

        #region Singleton, factory or constructor.
        #endregion

        #region Methods.
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Sample1()
        {
            //arrange
            int mArgument1 = 1;
            int mArgument2 = 2;
            int mExpected = 3;
            int mActual = CConst.ZERO;

            //act
            mActual = (mArgument1 + mArgument2);

            //assert
            Assert.AreEqual(mExpected, mActual);
            //Assert.AreNotEqual(mExpected, mActual);
        }
        #endregion
    }
}
