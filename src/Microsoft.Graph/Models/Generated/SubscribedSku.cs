// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Subscribed Sku.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SubscribedSku : Entity
    {
    
        /// <summary>
        /// Gets or sets capability status.
        /// For example, "Enabled".
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "capabilityStatus", Required = Newtonsoft.Json.Required.Default)]
        public string CapabilityStatus { get; set; }
    
        /// <summary>
        /// Gets or sets consumed units.
        /// The number of licenses that have been assigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "consumedUnits", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ConsumedUnits { get; set; }
    
        /// <summary>
        /// Gets or sets prepaid units.
        /// Information about the number and status of prepaid licenses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prepaidUnits", Required = Newtonsoft.Json.Required.Default)]
        public LicenseUnitsDetail PrepaidUnits { get; set; }
    
        /// <summary>
        /// Gets or sets service plans.
        /// Information about the service plans that are available with the SKU. Not nullable
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ServicePlanInfo> ServicePlans { get; set; }
    
        /// <summary>
        /// Gets or sets sku id.
        /// The unique identifier (GUID) for the service SKU.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? SkuId { get; set; }
    
        /// <summary>
        /// Gets or sets sku part number.
        /// The SKU part number; for example: "AAD_PREMIUM" or "RMSBASIC".
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuPartNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SkuPartNumber { get; set; }
    
        /// <summary>
        /// Gets or sets applies to.
        /// For example, "User" or "Company".
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliesTo", Required = Newtonsoft.Json.Required.Default)]
        public string AppliesTo { get; set; }
    
    }
}

