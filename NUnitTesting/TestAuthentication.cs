using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MenuManagement;
using System.IO;
using System;

namespace NUnitTesting
{
    [TestFixture]
    public class TestAuthentication
    {
        private Authentication _authenticate;

        [SetUp]
        public void SetUp()
        {
            _authenticate = new Authentication();
        }

        [Test]
        public void TestObjectExists()
        {
            Assert.IsNotNull(_authenticate);
        }

        [Test]
        public void TestWrongInput()
        {
            string firstmsg = "Hi mate.\nIf you are management, please press 1 \nIf you are customer, please press 2";
            StringReader num3 = new StringReader("3");
            StringWriter errormsg = new StringWriter();
            Console.SetIn(num3);
            Console.SetOut(errormsg);
            _authenticate.Identify();
            Assert.AreEqual(errormsg.ToString(), firstmsg + "\nPlease press 1 or 2\n");
        }
    }
}
