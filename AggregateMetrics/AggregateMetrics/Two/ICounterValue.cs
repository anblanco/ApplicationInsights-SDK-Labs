﻿using Microsoft.ApplicationInsights.DataContracts;

namespace Microsoft.ApplicationInsights.Extensibility.AggregateMetrics.Two
{
    /// <summary>
    /// Interface represents the counter value.
    /// </summary>
    public interface ICounterValue
    {
        /// <summary>
        /// Returns the current value of the counter as a <c ref="MetricTelemetry"/> and resets the metric.
        /// </summary>
        /// <returns></returns>
        MetricTelemetry GetValueAndReset();
    }
}
