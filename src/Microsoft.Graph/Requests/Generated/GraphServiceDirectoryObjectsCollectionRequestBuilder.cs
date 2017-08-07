// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceDirectoryObjectsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceDirectoryObjectsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceDirectoryObjectsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceDirectoryObjectsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceDirectoryObjectsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceDirectoryObjectsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceDirectoryObjectsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceDirectoryObjectsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectRequestBuilder"/> for the specified GraphServiceDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectRequestBuilder"/>.</returns>
        public IDirectoryObjectRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetByIds.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetByIdsRequestBuilder"/>.</returns>
        public IDirectoryObjectGetByIdsRequestBuilder GetByIds(
            IEnumerable<string> ids = null,
            IEnumerable<string> types = null)
        {
            return new DirectoryObjectGetByIdsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getByIds"),
                this.Client,
                ids,
                types);
        }
    }
}
