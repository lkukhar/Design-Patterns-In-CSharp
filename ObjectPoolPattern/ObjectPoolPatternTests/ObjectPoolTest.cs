using ObjectPoolPatternImplementation;
using System;
using System.IO;
using System.Threading;
using Xunit;

namespace ObjectPoolPatternTests
{
    public class ObjectPoolTest
    {
        [Fact]
        public void Object_Pool_Checks_Out_Object()
        {
            MemoryStreamPool memoryStreamPool = new MemoryStreamPool(new TimeSpan());
            memoryStreamPool.CheckOutObject();

            Assert.Single(memoryStreamPool._locked);
            Assert.Empty(memoryStreamPool._unlocked);
        }

        [Fact]
        public void Object_Pool_Checks_In_Object()
        {
            MemoryStreamPool memoryStreamPool = new MemoryStreamPool(new TimeSpan());
            MemoryStream memoryStream = memoryStreamPool.CheckOutObject();

            Assert.Single(memoryStreamPool._locked);
            Assert.Empty(memoryStreamPool._unlocked);

            memoryStreamPool.CheckInObject(memoryStream);

            Assert.Empty(memoryStreamPool._locked);
            Assert.Single(memoryStreamPool._unlocked);
        }

        [Fact]
        public void Object_Pool_Returns_Same_Object_If_Not_Expired()
        {
            MemoryStreamPool memoryStreamPool = new MemoryStreamPool(new TimeSpan(0, 1, 0));
            MemoryStream memoryStreamOne = memoryStreamPool.CheckOutObject();
            memoryStreamPool.CheckInObject(memoryStreamOne);
            MemoryStream memoryStreamTwo = memoryStreamPool.CheckOutObject();

            Assert.Equal(memoryStreamOne, memoryStreamTwo);
        }

        [Fact]
        public void Object_Pool_Expires_Object()
        {
            MemoryStreamPool memoryStreamPool = new MemoryStreamPool(new TimeSpan(0, 0, 1));
            MemoryStream memoryStreamOne = memoryStreamPool.CheckOutObject();
            memoryStreamPool.CheckInObject(memoryStreamOne);

            Thread.Sleep(new TimeSpan(0, 0, 2));

            MemoryStream memoryStreamTwo = memoryStreamPool.CheckOutObject();
            //Checkout object should expire memoryStreamOne, which destroys it, and returned a new object
         
            Assert.Single(memoryStreamPool._locked);
            Assert.Empty(memoryStreamPool._unlocked);
            Assert.NotEqual(memoryStreamOne, memoryStreamTwo);


        }
    }
}
