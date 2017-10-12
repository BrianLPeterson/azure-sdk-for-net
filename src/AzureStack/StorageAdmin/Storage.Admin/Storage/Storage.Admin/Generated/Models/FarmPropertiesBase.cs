// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// TODO
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FarmPropertiesBase
    {
        /// <summary>
        /// Initializes a new instance of the FarmPropertiesBase class.
        /// </summary>
        public FarmPropertiesBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FarmPropertiesBase class.
        /// </summary>
        public FarmPropertiesBase(int? settingsPollingIntervalInSecond = default(int?), int? retentionPeriodForDeletedStorageAccountsInDays = default(int?), int? hostStyleHttpPort = default(int?), int? hostStyleHttpsPort = default(int?), string corsAllowedOriginsList = default(string), string dataCenterUriHostSuffixes = default(string), bool? bandwidthThrottleIsEnabled = default(bool?), int? usageCollectionIntervalInSeconds = default(int?), int? feedbackRefreshIntervalInSeconds = default(int?), int? numberOfAccountsToSync = default(int?), int? defaultThrottleProbabilityDecayIntervalInSeconds = default(int?), int? gracePeriodForFullThrottlingInRefreshIntervals = default(int?), double? gracePeriodMaxThrottleProbability = default(double?), double? overallRequestThresholdInTps = default(double?), double? defaultRequestThresholdInTps = default(double?), double? minimumRequestThresholdInTps = default(double?), double? toleranceFactorForTps = default(double?), double? overallIngressThresholdInGbps = default(double?), double? defaultIngressThresholdInGbps = default(double?), double? minimumIngressThresholdInGbps = default(double?), double? toleranceFactorForIngress = default(double?), double? overallIntranetIngressThresholdInGbps = default(double?), double? defaultIntranetIngressThresholdInGbps = default(double?), double? minimumIntranetIngressThresholdInGbps = default(double?), double? toleranceFactorForIntranetIngress = default(double?), double? overallEgressThresholdInGbps = default(double?), double? defaultEgressThresholdInGbps = default(double?), double? minimumEgressThresholdInGbps = default(double?), double? toleranceFactorForEgress = default(double?), double? overallIntranetEgressThresholdInGbps = default(double?), double? defaultIntranetEgressThresholdInGbps = default(double?), double? minimumIntranetEgressThresholdInGbps = default(double?), double? toleranceFactorForIntranetEgress = default(double?), double? overallTotalIngressThresholdInGbps = default(double?), double? defaultTotalIngressThresholdInGbps = default(double?), double? minimumTotalIngressThresholdInGbps = default(double?), double? toleranceFactorForTotalIngress = default(double?), double? overallTotalEgressThresholdInGbps = default(double?), double? defaultTotalEgressThresholdInGbps = default(double?), double? minimumTotalEgressThresholdInGbps = default(double?), double? toleranceFactorForTotalEgress = default(double?))
        {
            SettingsPollingIntervalInSecond = settingsPollingIntervalInSecond;
            RetentionPeriodForDeletedStorageAccountsInDays = retentionPeriodForDeletedStorageAccountsInDays;
            HostStyleHttpPort = hostStyleHttpPort;
            HostStyleHttpsPort = hostStyleHttpsPort;
            CorsAllowedOriginsList = corsAllowedOriginsList;
            DataCenterUriHostSuffixes = dataCenterUriHostSuffixes;
            BandwidthThrottleIsEnabled = bandwidthThrottleIsEnabled;
            UsageCollectionIntervalInSeconds = usageCollectionIntervalInSeconds;
            FeedbackRefreshIntervalInSeconds = feedbackRefreshIntervalInSeconds;
            NumberOfAccountsToSync = numberOfAccountsToSync;
            DefaultThrottleProbabilityDecayIntervalInSeconds = defaultThrottleProbabilityDecayIntervalInSeconds;
            GracePeriodForFullThrottlingInRefreshIntervals = gracePeriodForFullThrottlingInRefreshIntervals;
            GracePeriodMaxThrottleProbability = gracePeriodMaxThrottleProbability;
            OverallRequestThresholdInTps = overallRequestThresholdInTps;
            DefaultRequestThresholdInTps = defaultRequestThresholdInTps;
            MinimumRequestThresholdInTps = minimumRequestThresholdInTps;
            ToleranceFactorForTps = toleranceFactorForTps;
            OverallIngressThresholdInGbps = overallIngressThresholdInGbps;
            DefaultIngressThresholdInGbps = defaultIngressThresholdInGbps;
            MinimumIngressThresholdInGbps = minimumIngressThresholdInGbps;
            ToleranceFactorForIngress = toleranceFactorForIngress;
            OverallIntranetIngressThresholdInGbps = overallIntranetIngressThresholdInGbps;
            DefaultIntranetIngressThresholdInGbps = defaultIntranetIngressThresholdInGbps;
            MinimumIntranetIngressThresholdInGbps = minimumIntranetIngressThresholdInGbps;
            ToleranceFactorForIntranetIngress = toleranceFactorForIntranetIngress;
            OverallEgressThresholdInGbps = overallEgressThresholdInGbps;
            DefaultEgressThresholdInGbps = defaultEgressThresholdInGbps;
            MinimumEgressThresholdInGbps = minimumEgressThresholdInGbps;
            ToleranceFactorForEgress = toleranceFactorForEgress;
            OverallIntranetEgressThresholdInGbps = overallIntranetEgressThresholdInGbps;
            DefaultIntranetEgressThresholdInGbps = defaultIntranetEgressThresholdInGbps;
            MinimumIntranetEgressThresholdInGbps = minimumIntranetEgressThresholdInGbps;
            ToleranceFactorForIntranetEgress = toleranceFactorForIntranetEgress;
            OverallTotalIngressThresholdInGbps = overallTotalIngressThresholdInGbps;
            DefaultTotalIngressThresholdInGbps = defaultTotalIngressThresholdInGbps;
            MinimumTotalIngressThresholdInGbps = minimumTotalIngressThresholdInGbps;
            ToleranceFactorForTotalIngress = toleranceFactorForTotalIngress;
            OverallTotalEgressThresholdInGbps = overallTotalEgressThresholdInGbps;
            DefaultTotalEgressThresholdInGbps = defaultTotalEgressThresholdInGbps;
            MinimumTotalEgressThresholdInGbps = minimumTotalEgressThresholdInGbps;
            ToleranceFactorForTotalEgress = toleranceFactorForTotalEgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.settingsPollingIntervalInSecond")]
        public int? SettingsPollingIntervalInSecond { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.retentionPeriodForDeletedStorageAccountsInDays")]
        public int? RetentionPeriodForDeletedStorageAccountsInDays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.hostStyleHttpPort")]
        public int? HostStyleHttpPort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.hostStyleHttpsPort")]
        public int? HostStyleHttpsPort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.corsAllowedOriginsList")]
        public string CorsAllowedOriginsList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.dataCenterUriHostSuffixes")]
        public string DataCenterUriHostSuffixes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.bandwidthThrottleIsEnabled")]
        public bool? BandwidthThrottleIsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.usageCollectionIntervalInSeconds")]
        public int? UsageCollectionIntervalInSeconds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.feedbackRefreshIntervalInSeconds")]
        public int? FeedbackRefreshIntervalInSeconds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.numberOfAccountsToSync")]
        public int? NumberOfAccountsToSync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultThrottleProbabilityDecayIntervalInSeconds")]
        public int? DefaultThrottleProbabilityDecayIntervalInSeconds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.gracePeriodForFullThrottlingInRefreshIntervals")]
        public int? GracePeriodForFullThrottlingInRefreshIntervals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.gracePeriodMaxThrottleProbability")]
        public double? GracePeriodMaxThrottleProbability { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallRequestThresholdInTps")]
        public double? OverallRequestThresholdInTps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultRequestThresholdInTps")]
        public double? DefaultRequestThresholdInTps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumRequestThresholdInTps")]
        public double? MinimumRequestThresholdInTps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForTps")]
        public double? ToleranceFactorForTps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallIngressThresholdInGbps")]
        public double? OverallIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultIngressThresholdInGbps")]
        public double? DefaultIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumIngressThresholdInGbps")]
        public double? MinimumIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForIngress")]
        public double? ToleranceFactorForIngress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallIntranetIngressThresholdInGbps")]
        public double? OverallIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultIntranetIngressThresholdInGbps")]
        public double? DefaultIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumIntranetIngressThresholdInGbps")]
        public double? MinimumIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForIntranetIngress")]
        public double? ToleranceFactorForIntranetIngress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallEgressThresholdInGbps")]
        public double? OverallEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultEgressThresholdInGbps")]
        public double? DefaultEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumEgressThresholdInGbps")]
        public double? MinimumEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForEgress")]
        public double? ToleranceFactorForEgress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallIntranetEgressThresholdInGbps")]
        public double? OverallIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultIntranetEgressThresholdInGbps")]
        public double? DefaultIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumIntranetEgressThresholdInGbps")]
        public double? MinimumIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForIntranetEgress")]
        public double? ToleranceFactorForIntranetEgress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallTotalIngressThresholdInGbps")]
        public double? OverallTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultTotalIngressThresholdInGbps")]
        public double? DefaultTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumTotalIngressThresholdInGbps")]
        public double? MinimumTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForTotalIngress")]
        public double? ToleranceFactorForTotalIngress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallTotalEgressThresholdInGbps")]
        public double? OverallTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultTotalEgressThresholdInGbps")]
        public double? DefaultTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumTotalEgressThresholdInGbps")]
        public double? MinimumTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForTotalEgress")]
        public double? ToleranceFactorForTotalEgress { get; set; }

    }
}
