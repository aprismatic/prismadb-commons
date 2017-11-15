using System.Collections.Generic;
using System.ComponentModel;
using Xunit;

namespace CommonsTests
{
    public class CommonsTests
    {
        [Fact(DisplayName = "Unique string generation")]
        public void TestGetUniqueString()
        {
            const int iterations = 100000;
            var hs = new HashSet<string>(iterations);

            for (var i = 0; i < iterations; i++)
            {
                Assert.True(hs.Add(PrismaDB.Commons.Helper.GetUniqueString()));
            }
        }

        [Fact(DisplayName = "Byte array -> Hex")]
        public void TestByteArrayToHex()
        {
            byte[] data = { 1, 2, 4, 8, 16, 32 };
            var hex = PrismaDB.Commons.Helper.ByteArrayToHex(data);
            Assert.Equal("010204081020", hex);
        }
    }
}
