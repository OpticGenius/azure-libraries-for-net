// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The maximum size capability.
    /// </summary>
    public partial class MaxSizeCapability
    {
        /// <summary>
        /// Initializes a new instance of the MaxSizeCapability class.
        /// </summary>
        public MaxSizeCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MaxSizeCapability class.
        /// </summary>
        /// <param name="limit">The maximum size limit (see 'unit' for the
        /// units).</param>
        /// <param name="unit">The units that the limit is expressed in.
        /// Possible values include: 'Megabytes', 'Gigabytes', 'Terabytes',
        /// 'Petabytes'</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="reason">The reason for the capability not being
        /// available.</param>
        public MaxSizeCapability(int? limit = default(int?), MaxSizeUnits? unit = default(MaxSizeUnits?), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))
        {
            Limit = limit;
            Unit = unit;
            Status = status;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the maximum size limit (see 'unit' for the units).
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; private set; }

        /// <summary>
        /// Gets the units that the limit is expressed in. Possible values
        /// include: 'Megabytes', 'Gigabytes', 'Terabytes', 'Petabytes'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public MaxSizeUnits? Unit { get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets or sets the reason for the capability not being available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}