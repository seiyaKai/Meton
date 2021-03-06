﻿using Meton.Liegen.DataModels;
using Meton.Liegen.Utility;
using System;
using System.Net.Http;
using System.Reactive.Linq;

namespace Meton.Liegen.Method.Rest
{
    public static class Activity
    {
        public static IObservable<StatusActivitySummary> ActivityStatusSummary(
            this AccountInfo info,
            long id,
            bool? includeUserEntities = null)
        {
            var param = new ParameterCollection()
            {
                {"include_user_entities", includeUserEntities}
            };

            return info
                .GetClient(HttpMethod.Get)
                .SetEndpoint(Endpoints.ActivityStatusSummary.Replace(":id", id.ToString()))
                .SetParameters(param)
                .GetResponse()
                .Parse<StatusActivitySummary>()
                .Select(_ => _.Fix());
        }
    }
}
