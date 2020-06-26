﻿using System.Security.Policy;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Adapters;
using Microsoft.Bot.Schema;
using Microsoft.Bot.Solutions.Feedback;
using Microsoft.Bot.Solutions.Middleware;
using Microsoft.Bot.Solutions.Proactive;
using Microsoft.Bot.Solutions.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Bot.Solutions.Tests.Util
{
    [TestClass]
    [TestCategory("UnitTests")]
    public class UtilTests
    {
        [TestMethod]
        public void Recognizer_Helper_Prompt_Yes_Test()
        {
            var recognizerHelper = ConfirmRecognizerHelper.ConfirmYesOrNo("yes", "en-us");
            Assert.IsNotNull(recognizerHelper);
            Assert.IsTrue(recognizerHelper.Value);
        }

        [TestMethod]
        public void Recognizer_Helper_Prompt_No_Test()
        {
            var recognizerHelper = ConfirmRecognizerHelper.ConfirmYesOrNo("no", "en-us");
            Assert.IsNotNull(recognizerHelper);
            Assert.IsFalse(recognizerHelper.Value);
        }

        [TestMethod]
        public void ConfigData_Test()
        {
            var configData = ConfigData.GetInstance();
            Assert.IsNotNull(configData);
            Assert.AreEqual(CommonUtil.MaxReadSize, configData.MaxReadSize);
            Assert.AreEqual(CommonUtil.MaxDisplaySize, configData.MaxDisplaySize);
        }

        [TestMethod]
        public void MD5Util_Test()
        {
            var hashString = MD5Util.ComputeHash("Test");
            Assert.IsNotNull(hashString);
            Assert.AreEqual("0cbc6611f5540bd0809a388dc95a615b", hashString);
        }
    }
}
