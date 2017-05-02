// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IPostRequestBuilder.
    /// </summary>
    public partial interface IPostRequestBuilder : IOutlookItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPostRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPostRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IPostExtensionsCollectionRequestBuilder"/>.</returns>
        IPostExtensionsCollectionRequestBuilder Extensions { get; }

        /// <summary>
        /// Gets the request builder for InReplyTo.
        /// </summary>
        /// <returns>The <see cref="IPostRequestBuilder"/>.</returns>
        IPostRequestBuilder InReplyTo { get; }

        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IPostAttachmentsCollectionRequestBuilder"/>.</returns>
        IPostAttachmentsCollectionRequestBuilder Attachments { get; }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IPostSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IPostSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IPostMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IPostMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties { get; }
    
        /// <summary>
        /// Gets the request builder for PostForward.
        /// </summary>
        /// <returns>The <see cref="IPostForwardRequestBuilder"/>.</returns>
        IPostForwardRequestBuilder Forward(
            IEnumerable<Recipient> ToRecipients,
            string Comment = null);

        /// <summary>
        /// Gets the request builder for PostReply.
        /// </summary>
        /// <returns>The <see cref="IPostReplyRequestBuilder"/>.</returns>
        IPostReplyRequestBuilder Reply(
            Post Post);
    
    }
}
