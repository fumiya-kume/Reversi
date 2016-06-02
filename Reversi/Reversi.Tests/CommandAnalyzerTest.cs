// <copyright file="CommandAnalyzerTest.cs" company="Shaxware">Copyright ©  2016 Kuxumarin</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reversi;

namespace Reversi.Tests
{
    /// <summary>This class contains parameterized unit tests for CommandAnalyzer</summary>
    [PexClass(typeof(CommandAnalyzer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CommandAnalyzerTest
    {
        /// <summary>Test stub for CheckCommand()</summary>
        [PexMethod]
        public bool CheckCommandTest([PexAssumeUnderTest]CommandAnalyzer target)
        {
            bool result = target.CheckCommand();
            return result;
            // TODO: add assertions to method CommandAnalyzerTest.CheckCommandTest(CommandAnalyzer)
        }
    }
}
