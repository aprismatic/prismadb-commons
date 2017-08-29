using System;
using System.Collections.Generic;
using Xunit;

namespace CommonsTests
{
    public class CommonsTests
    {
        [Fact]
        public void TestGetUniqueString()
        {
            const int iterations = 1000;
            var hs = new HashSet<string>(iterations);

            for (var i = 0; i < iterations; i++)
            {
                Assert.Equal(true, hs.Add(PrismaDB.Commons.Helper.GetUniqueString()));
            }
        }

        [Fact]
        public void TestByteArrayToHex()
        {
            byte[] data = { 1, 2, 4, 8, 16, 32 };
            var hex = PrismaDB.Commons.Helper.ByteArrayToHex(data);
            Assert.Equal("010204081020", hex);
        }
    }
}
