using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab6;
using System.Drawing;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void test_save()
        {
            Settings set = new Settings();
            bool actual = Operations.load_user_settings(ref set);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void test_radiapoint()
        {
            Point actual = Operations.radia_point(new Point(150, 150), 123, 5);
            Point expected = new Point(211, 44);
            Assert.AreEqual(expected, actual);
        }
    }
}
