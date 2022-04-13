using NUnit.Framework;
using DotNetRemoting;
using System;
using System.Collections.Generic;
using System.Text;
using RemoteClass;

namespace DotNetRemoting.Tests
{
    [TestFixture]
    public class RemoteClassTests
    {
        [TestCase(1, 1, 2)]
        [TestCase(100, 100, 200)]
        [TestCase(150, 120, 270)]
        public void IsCorrect_Add(int a, int b, int expected)
        {
            IRemoteClass remoteClass = new RemoteClass();
            Assert.AreEqual(expected, remoteClass.Add(a, b));
        }

        [TestCase(1, 1, 1)]
        [TestCase(100, 20, 5)]
        [TestCase(20, 4, 5)]
        public void IsCorrect_Divide(int a, int b, int expected)
        {
            IRemoteClass remoteClass = new RemoteClass();
            Assert.AreEqual(expected, remoteClass.Divide(a, b));
        }
        [TestCase(1, 0)]
        public void IsCorrect_Divide_Exception_Throws(int a, int b)
        {
            IRemoteClass remoteClass = new RemoteClass();
            var ex = Assert.Throws<Exception>(() => remoteClass.Divide(a, b));

            StringAssert.Contains("Can't divid Zero", ex.Message);
        }
        [TestCase(1, 0)]
        public void IsCorrect_Divide_Exception_ThrowsFluent(int a, int b)
        {
            IRemoteClass remoteClass = new RemoteClass();
            var ex = Assert.Throws<Exception>(() => remoteClass.Divide(a, b));
            Assert.That(ex.Message, Does.Contain("Can't divid Zero"));
        }
        [TestCase(1, 0, 0)]
        [TestCase(100, 100, 10000)]
        [TestCase(150, 100, 15000)]
        [TestCase(20, 5, 100)]
        public void IsCorrect_Mutly(int a, int b, int expected)
        {
            IRemoteClass remoteClass = new RemoteClass();
            Assert.AreEqual(expected, remoteClass.Multy(a, b));
        }

        [TestCase(1, 0, 1)]
        [TestCase(-1, 5, -6)]
        [TestCase(100, 20, 80)]
        public void SubstractTest(int a, int b, int expected)
        {
            IRemoteClass remoteClass = new RemoteClass();
            Assert.AreEqual(expected, remoteClass.Substract(a, b));
        }
    }
}