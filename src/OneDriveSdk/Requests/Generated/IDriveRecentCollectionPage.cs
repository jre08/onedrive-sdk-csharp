// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using Microsoft.Graph;
    using Newtonsoft.Json;
    
    /// <summary>
    /// The interface IDriveRecentCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<DriveRecentCollectionPage>))]
    public interface IDriveRecentCollectionPage : ICollectionPage<Item>
    {
        /// <summary>
        /// Gets the next page <see cref="IDriveRecentRequest"/> instance.
        /// </summary>
        IDriveRecentRequest NextPageRequest { get; }
        
        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
