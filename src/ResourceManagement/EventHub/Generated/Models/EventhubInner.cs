// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single item in List or Get Event Hub operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EventhubInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the EventhubInner class.
        /// </summary>
        public EventhubInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventhubInner class.
        /// </summary>
        /// <param name="partitionIds">Current number of shards on the Event
        /// Hub.</param>
        /// <param name="createdAt">Exact time the Event Hub was
        /// created.</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        /// <param name="messageRetentionInDays">Number of days to retain the
        /// events for this Event Hub, value should be 1 to 7 days</param>
        /// <param name="partitionCount">Number of partitions created for the
        /// Event Hub, allowed values are from 1 to 32 partitions.</param>
        /// <param name="status">Enumerates the possible values for the status
        /// of the Event Hub. Possible values include: 'Active', 'Disabled',
        /// 'Restoring', 'SendDisabled', 'ReceiveDisabled', 'Creating',
        /// 'Deleting', 'Renaming', 'Unknown'</param>
        /// <param name="captureDescription">Properties of capture
        /// description</param>
        public EventhubInner(string id = default(string), string name = default(string), string type = default(string), IList<string> partitionIds = default(IList<string>), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), long? messageRetentionInDays = default(long?), long? partitionCount = default(long?), EntityStatus? status = default(EntityStatus?), CaptureDescription captureDescription = default(CaptureDescription))
            : base(id, name, type)
        {
            PartitionIds = partitionIds;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            MessageRetentionInDays = messageRetentionInDays;
            PartitionCount = partitionCount;
            Status = status;
            CaptureDescription = captureDescription;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets current number of shards on the Event Hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionIds")]
        public IList<string> PartitionIds { get; private set; }

        /// <summary>
        /// Gets exact time the Event Hub was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or sets number of days to retain the events for this Event
        /// Hub, value should be 1 to 7 days
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageRetentionInDays")]
        public long? MessageRetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets number of partitions created for the Event Hub,
        /// allowed values are from 1 to 32 partitions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionCount")]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// Gets or sets enumerates the possible values for the status of the
        /// Event Hub. Possible values include: 'Active', 'Disabled',
        /// 'Restoring', 'SendDisabled', 'ReceiveDisabled', 'Creating',
        /// 'Deleting', 'Renaming', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets properties of capture description
        /// </summary>
        [JsonProperty(PropertyName = "properties.captureDescription")]
        public CaptureDescription CaptureDescription { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MessageRetentionInDays < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MessageRetentionInDays", 1);
            }
            if (PartitionCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PartitionCount", 1);
            }
            if (CaptureDescription != null)
            {
                CaptureDescription.Validate();
            }
        }
    }
}
