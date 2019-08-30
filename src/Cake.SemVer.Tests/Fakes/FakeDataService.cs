using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using Cake.Core;

namespace Cake.SemVer.Tests.Fakes
{
    internal class FakeDataService : ICakeDataService
    {
        private readonly ConcurrentDictionary<Type, object> _cache = new ConcurrentDictionary<Type, object>();

        public TData Get<TData>() where TData : class
        {
            if (_cache.TryGetValue(typeof(TData), out var data))
            {
                return (TData) data;
            }

            return null;
        }

        public void Add<TData>(TData value) where TData : class
        {
            _cache.AddOrUpdate(typeof(TData), value, (_, __) => value);
        }
    }
}