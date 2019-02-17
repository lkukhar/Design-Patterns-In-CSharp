using System;
using System.Data.Common;
using System.IO;

namespace ObjectPoolPatternImplementation
{
    public class MemoryStreamPool : ObjectPool<MemoryStream>
    {
        protected MemoryStreamPool(TimeSpan timeSpan) : base(timeSpan) { }
        protected override MemoryStream CreateObject() => new MemoryStream();
        protected override void DestroyObject(MemoryStream obj) => obj.Dispose();
    }
}
