// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Managed Device Overview.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedDeviceOverview : Entity
    {
    
		///<summary>
		/// The ManagedDeviceOverview constructor
		///</summary>
        public ManagedDeviceOverview()
        {
            this.ODataType = "microsoft.graph.managedDeviceOverview";
        }
	
        /// <summary>
        /// Gets or sets enrolled device count.
        /// Total enrolled device count. Does not include PC devices managed via Intune PC Agent
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrolledDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EnrolledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets mdm enrolled count.
        /// The number of devices enrolled in MDM
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmEnrolledCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MdmEnrolledCount { get; set; }
    
        /// <summary>
        /// Gets or sets dual enrolled device count.
        /// The number of devices enrolled in both MDM and EAS
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dualEnrolledDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DualEnrolledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets device operating system summary.
        /// Device operating system summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceOperatingSystemSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceOperatingSystemSummary DeviceOperatingSystemSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device exchange access state summary.
        /// Distribution of Exchange Access State in Intune
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceExchangeAccessStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceExchangeAccessStateSummary DeviceExchangeAccessStateSummary { get; set; }
    
    }
}

