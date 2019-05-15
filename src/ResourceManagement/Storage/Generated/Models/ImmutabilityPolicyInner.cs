// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The ImmutabilityPolicy property of a blob container, including Id,
    /// resource name, resource type, Etag.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ImmutabilityPolicyInner : AzureEntityResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the ImmutabilityPolicyInner class.
        /// </summary>
        public ImmutabilityPolicyInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImmutabilityPolicyInner class.
        /// </summary>
        /// <param name="immutabilityPeriodSinceCreationInDays">The
        /// immutability period for the blobs in the container since the policy
        /// creation, in days.</param>
        /// <param name="etag">Resource Etag.</param>
        /// <param name="state">The ImmutabilityPolicy state of a blob
        /// container, possible values include: Locked and Unlocked. Possible
        /// values include: 'Locked', 'Unlocked'</param>
        public ImmutabilityPolicyInner(int immutabilityPeriodSinceCreationInDays, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string state = default(string))
            : base(location, id, name, type, tags, etag)
        {
            ImmutabilityPeriodSinceCreationInDays = immutabilityPeriodSinceCreationInDays;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the immutability period for the blobs in the container
        /// since the policy creation, in days.
        /// </summary>
        [JsonProperty(PropertyName = "properties.immutabilityPeriodSinceCreationInDays")]
        public int ImmutabilityPeriodSinceCreationInDays { get; set; }

        /// <summary>
        /// Gets the ImmutabilityPolicy state of a blob container, possible
        /// values include: Locked and Unlocked. Possible values include:
        /// 'Locked', 'Unlocked'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}