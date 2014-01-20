﻿using System.Web.Caching;
using CacheProvider;

namespace ModelViewPresenter.Demo.Web.WebCacheProviders
{
    public class AspNetKeyCacheDependency : IKeyCacheDependency, IAspNetCacheDependency
    {
        #region IKeyCacheDependency Members

        public string[] Keys
        {
            get;
            set;
        }

        #endregion

        #region IAspNetCacheDependency Members

        public CacheDependency CreateAspNetCacheDependency()
        {
            return new CacheDependency(null, Keys);
        }

        #endregion
    }
}