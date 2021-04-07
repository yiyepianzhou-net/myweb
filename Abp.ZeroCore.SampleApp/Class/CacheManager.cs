using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;

namespace Abp.ZeroCore.SampleApp.Class
{
    public class CacheManager : ICacheManager
    {
        public void Dispose()
        {

        }

        public IReadOnlyList<ICache> GetAllCaches()
        {
            return null;
        }

        public ICache GetCache(string name)
        {
            return null;
        }
    }
}
