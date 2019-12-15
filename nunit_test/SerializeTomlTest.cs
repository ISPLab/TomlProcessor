using System;
using HyperTomlProcessor.Test;
using NUnit.Framework;

namespace HyperTomlProcessor.P8Test
{

    public class CustomObjTest
    {
        [System.ComponentModel.Description("uncoment to set /n #X=11")]
        public int X { get; set; }
        public int Y { get; set; }
    }
    [TestFixture]
    public class SerializeTomlTest
    {
        public SerializeTomlTest()
        {
        }
        [Test]
        public void SerializeTestObjects()
        {
            var res = Toml.V04.SerializeObject(TestObject.Create());
            Assert.AreEqual(689, res.Length);
        }

        [Test]
        public void SerializeCustomObjTest()
        {
            CustomObjTest obj = new CustomObjTest();
            obj.X = 11;
            string res = Toml.V04.SerializeObject(obj);
            res= res.Replace("11", "12");
            var obj2 =Toml.V04.DeserializeObject<CustomObjTest>(res);
            Assert.AreEqual(obj2.X, 12);
        }
    }
}
