// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.OneDrive.Sdk
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Microsoft.Graph;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ItemChildrenCollectionResponse.
    /// </summary>
    [DataContract]
    public class ItemChildrenCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IItemChildrenCollectionPage"/> value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public IItemChildrenCollectionPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
