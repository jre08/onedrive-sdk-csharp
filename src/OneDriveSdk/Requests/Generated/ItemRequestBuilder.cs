// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.Graph;

    /// <summary>
    /// The type ItemRequestBuilder.
    /// </summary>
    public partial class ItemRequestBuilder : BaseRequestBuilder, IItemRequestBuilder
    {

        /// <summary>
        /// Constructs a new ItemRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ItemRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IItemRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IItemRequest Request(IEnumerable<Option> options)
        {
            return new ItemRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for Permissions.
        /// </summary>
        /// <returns>The <see cref="IItemPermissionsCollectionRequestBuilder"/>.</returns>
        public IItemPermissionsCollectionRequestBuilder Permissions
        {
            get
            {
                return new ItemPermissionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("permissions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Versions.
        /// </summary>
        /// <returns>The <see cref="IItemVersionsCollectionRequestBuilder"/>.</returns>
        public IItemVersionsCollectionRequestBuilder Versions
        {
            get
            {
                return new ItemVersionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("versions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Children.
        /// </summary>
        /// <returns>The <see cref="IItemChildrenCollectionRequestBuilder"/>.</returns>
        public IItemChildrenCollectionRequestBuilder Children
        {
            get
            {
                return new ItemChildrenCollectionRequestBuilder(this.AppendSegmentToRequestUrl("children"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Thumbnails.
        /// </summary>
        /// <returns>The <see cref="IItemThumbnailsCollectionRequestBuilder"/>.</returns>
        public IItemThumbnailsCollectionRequestBuilder Thumbnails
        {
            get
            {
                return new ItemThumbnailsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("thumbnails"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for Content.
        /// </summary>
        /// <returns>The <see cref="IItemContentRequestBuilder"/>.</returns>
        public IItemContentRequestBuilder Content
        {
            get
            {
                return new ItemContentRequestBuilder(this.AppendSegmentToRequestUrl("content"), this.Client);
            }
        }
        
        /// <summary>
        /// Gets the request builder for ItemCreateSession.
        /// </summary>
        /// <returns>The <see cref="IItemCreateSessionRequestBuilder"/>.</returns>
        public IItemCreateSessionRequestBuilder CreateSession(
            ChunkedUploadSessionDescriptor item = null)
        {
            return new ItemCreateSessionRequestBuilder(
                this.AppendSegmentToRequestUrl("oneDrive.createSession"),
                this.Client,
                item);
        }

        /// <summary>
        /// Gets the request builder for ItemCopy.
        /// </summary>
        /// <returns>The <see cref="IItemCopyRequestBuilder"/>.</returns>
        public IItemCopyRequestBuilder Copy(
            string name = null,
            ItemReference parentReference = null)
        {
            return new ItemCopyRequestBuilder(
                this.AppendSegmentToRequestUrl("oneDrive.copy"),
                this.Client,
                name,
                parentReference);
        }

        /// <summary>
        /// Gets the request builder for ItemCreateLink.
        /// </summary>
        /// <returns>The <see cref="IItemCreateLinkRequestBuilder"/>.</returns>
        public IItemCreateLinkRequestBuilder CreateLink(
            string type)
        {
            return new ItemCreateLinkRequestBuilder(
                this.AppendSegmentToRequestUrl("oneDrive.createLink"),
                this.Client,
                type);
        }

        /// <summary>
        /// Gets the request builder for ItemDelta.
        /// </summary>
        /// <returns>The <see cref="IItemDeltaRequestBuilder"/>.</returns>
        public IItemDeltaRequestBuilder Delta(
            string token = null)
        {
            return new ItemDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("oneDrive.delta"),
                this.Client,
                token);
        }

        /// <summary>
        /// Gets the request builder for ItemSearch.
        /// </summary>
        /// <returns>The <see cref="IItemSearchRequestBuilder"/>.</returns>
        public IItemSearchRequestBuilder Search(
            string q = null)
        {
            return new ItemSearchRequestBuilder(
                this.AppendSegmentToRequestUrl("oneDrive.search"),
                this.Client,
                q);
        }
    
    }
}
