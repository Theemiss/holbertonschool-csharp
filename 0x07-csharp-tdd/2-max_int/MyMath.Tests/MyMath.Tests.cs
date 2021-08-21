using NUnit.Framework;
using MyMath;
using System.Collections.Generic;
namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckEmpty()
        {
            var Mylist = new List<int>();
            var res = Operations.Max(Mylist);
            Assert.AreEqual(res,0);
        }
        [Test]
        public void checkMax()
        {
            var Mylist = new List<int>();
            Mylist.Add(1);
            Mylist.Add(5);
            var res = Operations.Max(Mylist);
            Assert.AreEqual(res, 5);
            Mylist.Add(10);
            Mylist.Add(-5);
            res = Operations.Max(Mylist);
            Assert.AreEqual(res, 10);
            Mylist.Clear();
            Mylist.Add(0);
            Mylist.Add(-1);
            res = Operations.Max(Mylist);
            Assert.AreEqual(res, 0);
        }
    }
}