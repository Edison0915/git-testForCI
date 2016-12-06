using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryForCi;

namespace UnitTestProjectForCi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetNameTest()
        {
            Class1 testclass = new Class1();
            string name = "Edison";
            string expected  = "My Name is Edison";

            string actual = testclass.GetName(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest()
        {
            Class1 testclass = new Class1();
            int firstnumber = 1;
            int secondnumber = 2;
            int expected = 3;

            int actual = testclass.Add(firstnumber, secondnumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
