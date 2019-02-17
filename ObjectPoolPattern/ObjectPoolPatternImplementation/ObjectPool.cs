using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ObjectPoolPatternImplementation
{
    public abstract class ObjectPool<T>
    {
        private TimeSpan _expirationTime;
        private Dictionary<T, DateTime> _locked, _unlocked;

        protected ObjectPool(TimeSpan expirationTime)
        {
            _expirationTime = expirationTime;
            _locked = new Dictionary<T, DateTime>();
            _unlocked = new Dictionary<T, DateTime>();
        }

        protected abstract T CreateObject();
        protected abstract void DestroyObject(T obj);

        [MethodImpl(MethodImplOptions.Synchronized)]
        protected T CheckOutObject()
        {
            DateTime now = DateTime.Now;
            T obj;

            if(_unlocked.Count > 0)
            {
                while(_unlocked.Count > 0)
                {
                    obj = GetAvailableObject();
                    if((now - _unlocked[obj]) > _expirationTime)
                    {
                        _unlocked.Remove(obj);
                        DestroyObject(obj);
                        obj = default(T);
                    }
                    else
                    {
                        _unlocked.Remove(obj);
                        _locked.Add(obj, DateTime.Now);
                        return obj;
                    }
                }
            }
            obj = CreateObject();
            _locked.Add(obj, now);
            return obj;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        protected void CheckInObject(T obj)
        {
            _locked.Remove(obj);
            _unlocked.Add(obj, DateTime.Now);
        }
        
        private T GetAvailableObject()
        {
            Random random = new Random();
            return _unlocked.ElementAt(random.Next(_unlocked.Count)).Key;
        }
    }
}
