﻿using Dcode.Pos.Application.External.ApplicationInsights;
using Dcode.Pos.Domain.Models.ApplicationInsights;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;

namespace Dcode.Pos.External.ApplicationInsights
{
    public class InsertApplicationInsightsService : IInsertApplicationInsightsService
    {
        private readonly IConfiguration _configuration;
        public InsertApplicationInsightsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public bool Execute(InsertApplicationInsightsModel metric)
        {
            if (metric == null)
                throw new ArgumentNullException(nameof(metric));

            TelemetryConfiguration config = new TelemetryConfiguration();
            config.ConnectionString = _configuration["ApplicationInsightsConnectionString"];

            var _telemetryClient = new TelemetryClient(config);

            var properties = new Dictionary<string, string>
            {
                {"Id", metric.Id},
                {"Content", metric.Content },
                {"Detail", metric.Detail }
            };

            _telemetryClient.TrackTrace(metric.Type, SeverityLevel.Information, properties);
            return true;
        }
    }
}
