using System;
using System.IO;

namespace ObjectPoolPatternImplementation
{
    public class MemoryStreamPool : ObjectPool<MemoryStream>
    {
        public MemoryStreamPool(TimeSpan timeSpan) : base(timeSpan) { }
        protected override MemoryStream CreateObject() => new MemoryStream();
        protected override void DestroyObject(MemoryStream obj) => obj.Dispose();
    }
}
