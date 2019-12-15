using System;
using HyperTomlProcessor.Test;
using NUnit.Framework;

namespace HyperTomlProcessor.P8Test
{
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


            System.Diagnostics.Debug.WriteLine(res);
        }
    }
}
