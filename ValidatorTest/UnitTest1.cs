using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValidatorLib;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNameWithNumbers()
        {
            if(MyValidator.CheckName("Emil123") == false)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestNameNoEmpty()
        {
            if(MyValidator.CheckName("") == false)
            {
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public void TestZipAccept()
        {
            String zip = "1234";
            Assert.IsTrue(MyValidator.CheckZip(zip));
        }
        [TestMethod]
        public void TestZipNotAccept()
        {
            String zip = "123";
            Assert.IsFalse(MyValidator.CheckZip(zip));
        }
        [TestMethod]
        public void TestHouseNumberAccept()
        {
            String housenumber = "84A";
            Assert.IsTrue(MyValidator.CheckHouseNumber(housenumber));
        }
        [TestMethod]
        public void TestHouseNumberNotAccept()
        {
            String housenumber = "84Abadadadad12334";
            Assert.IsFalse(MyValidator.CheckHouseNumber(housenumber));
        }
        [TestMethod]
        public void TestPhoneAccept()
        {
            String phoneNumber = "+4526239540";
            Assert.IsTrue(MyValidator.CheckPhone(phoneNumber));
        }
        [TestMethod]
        public void TestPhoneNotAccept()
        {
            String phoneNumber = "2623954";
            Assert.IsFalse(MyValidator.CheckPhone(phoneNumber));
        }
        [TestMethod]
        public void TestEmailAccept()
        {
            String email = "emilg6g@hotmail.com";
            Assert.IsTrue(MyValidator.CheckEmail(email));
        }
        [TestMethod]
        public void TestEmailNotAccept()
        {
            String email = "emilg6ghotmail.com";
            Assert.IsFalse(MyValidator.CheckEmail(email));
        }
    }
}
