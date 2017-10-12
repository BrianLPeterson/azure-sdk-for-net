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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// TODO
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TableService : Resource
    {
        /// <summary>
        /// Initializes a new instance of the TableService class.
        /// </summary>
        public TableService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TableService class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="version">TODO</param>
        /// <param name="healthStatus">Possible values include: 'Unknown',
        /// 'Healthy', 'Warning', 'Critical'</param>
        /// <param name="frontEndCallbackThreadsCount">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingEnabled">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds">TODO</param>
        /// <param name="frontEndMemoryThrottlingEnabled">TODO</param>
        /// <param
        /// name="frontEndMaxMillisecondsBetweenMemorySamples">TODO</param>
        /// <param name="frontEndMemoryThrottleThresholdSettings">TODO</param>
        /// <param name="frontEndMinThreadPoolThreads">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveIOCompletionThreshold">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAlivePercentage">TODO</param>
        /// <param name="frontEndUseSlaTimeInAvailability">TODO</param>
        public TableService(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string version = default(string), string healthStatus = default(string), int? frontEndCallbackThreadsCount = default(int?), bool? frontEndCpuBasedKeepAliveThrottlingEnabled = default(bool?), double? frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold = default(double?), double? frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle = default(double?), int? frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds = default(int?), bool? frontEndMemoryThrottlingEnabled = default(bool?), int? frontEndMaxMillisecondsBetweenMemorySamples = default(int?), string frontEndMemoryThrottleThresholdSettings = default(string), int? frontEndMinThreadPoolThreads = default(int?), int? frontEndThreadPoolBasedKeepAliveIOCompletionThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds = default(int?), double? frontEndThreadPoolBasedKeepAlivePercentage = default(double?), bool? frontEndUseSlaTimeInAvailability = default(bool?), int? frontEndHttpListenPort = default(int?), int? backEndHttpListenPort = default(int?))
            : base(id, name, type, location, tags)
        {
            Version = version;
            HealthStatus = healthStatus;
            FrontEndCallbackThreadsCount = frontEndCallbackThreadsCount;
            FrontEndCpuBasedKeepAliveThrottlingEnabled = frontEndCpuBasedKeepAliveThrottlingEnabled;
            FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold = frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold;
            FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle = frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle;
            FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds = frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds;
            FrontEndMemoryThrottlingEnabled = frontEndMemoryThrottlingEnabled;
            FrontEndMaxMillisecondsBetweenMemorySamples = frontEndMaxMillisecondsBetweenMemorySamples;
            FrontEndMemoryThrottleThresholdSettings = frontEndMemoryThrottleThresholdSettings;
            FrontEndMinThreadPoolThreads = frontEndMinThreadPoolThreads;
            FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold = frontEndThreadPoolBasedKeepAliveIOCompletionThreshold;
            FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold = frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold;
            FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds = frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds;
            FrontEndThreadPoolBasedKeepAlivePercentage = frontEndThreadPoolBasedKeepAlivePercentage;
            FrontEndUseSlaTimeInAvailability = frontEndUseSlaTimeInAvailability;
            FrontEndHttpListenPort = frontEndHttpListenPort;
            BackEndHttpListenPort = backEndHttpListenPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.version ")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Unknown', 'Healthy',
        /// 'Warning', 'Critical'
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthStatus")]
        public string HealthStatus { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndCallbackThreadsCount")]
        public int? FrontEndCallbackThreadsCount { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndCpuBasedKeepAliveThrottlingEnabled")]
        public bool? FrontEndCpuBasedKeepAliveThrottlingEnabled { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold")]
        public double? FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle")]
        public double? FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds")]
        public int? FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndMemoryThrottlingEnabled")]
        public bool? FrontEndMemoryThrottlingEnabled { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndMaxMillisecondsBetweenMemorySamples")]
        public int? FrontEndMaxMillisecondsBetweenMemorySamples { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndMemoryThrottleThresholdSettings")]
        public string FrontEndMemoryThrottleThresholdSettings { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndMinThreadPoolThreads")]
        public int? FrontEndMinThreadPoolThreads { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndThreadPoolBasedKeepAliveIOCompletionThreshold")]
        public int? FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold")]
        public int? FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds")]
        public int? FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndThreadPoolBasedKeepAlivePercentage")]
        public double? FrontEndThreadPoolBasedKeepAlivePercentage { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndUseSlaTimeInAvailability")]
        public bool? FrontEndUseSlaTimeInAvailability { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.frontEndHttpListenPort")]
        public int? FrontEndHttpListenPort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.backEndHttpListenPort")]
        public int? BackEndHttpListenPort { get; set; }

    }
}
