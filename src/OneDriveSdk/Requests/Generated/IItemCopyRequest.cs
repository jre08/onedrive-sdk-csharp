// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    
    using Microsoft.Graph;
    
    /// <summary>
    /// The interface IItemCopyRequest.
    /// </summary>
    public partial interface IItemCopyRequest : IBaseRequest
    {
    
        /// <summary>
        /// Gets the request body.
        /// </summary>
        ItemCopyRequestBody RequestBody { get; }
        
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        Task<IItemCopyAsyncMonitor> PostAsync();

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>TheIItemCopyAsyncMonitor</returns>
        Task<IItemCopyAsyncMonitor> PostAsync(CancellationToken cancellationToken);
            
        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemCopyRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemCopyRequest Select(string value);
    
    }
}
