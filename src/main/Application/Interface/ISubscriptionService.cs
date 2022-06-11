﻿using ei8.Cortex.Subscriptions.Common;
using ei8.Cortex.Subscriptions.Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ei8.Cortex.Subscriptions.Application.Interface
{
    public interface ISubscriptionService
    {
        Task AddSubscriptionForBrowserAsync(BrowserSubscriptionInfo subscriptionInfo);

        /// <summary>
        /// TODO: Remove later for debugging only
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<IList<Subscription>> GetSubscriptionsForUserAsync(Guid userId);
    }
}
