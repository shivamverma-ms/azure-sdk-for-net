// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The Object used to describe a Service Provider supported by Bot Service. </summary>
    public partial class BotServiceProviderProperties
    {
        /// <summary> Initializes a new instance of BotServiceProviderProperties. </summary>
        internal BotServiceProviderProperties()
        {
            Parameters = new ChangeTrackingList<BotServiceProviderParameter>();
        }

        /// <summary> Initializes a new instance of BotServiceProviderProperties. </summary>
        /// <param name="id"> Id for Service Provider. </param>
        /// <param name="displayName"> Display Name of the Service Provider. </param>
        /// <param name="serviceProviderName"> Name of the Service Provider. </param>
        /// <param name="devPortalUri"> URL of Dev Portal. </param>
        /// <param name="iconUri"> The URL of icon. </param>
        /// <param name="parameters"> The list of parameters for the Service Provider. </param>
        internal BotServiceProviderProperties(string id, string displayName, string serviceProviderName, Uri devPortalUri, Uri iconUri, IReadOnlyList<BotServiceProviderParameter> parameters)
        {
            Id = id;
            DisplayName = displayName;
            ServiceProviderName = serviceProviderName;
            DevPortalUri = devPortalUri;
            IconUri = iconUri;
            Parameters = parameters;
        }

        /// <summary> Id for Service Provider. </summary>
        public string Id { get; }
        /// <summary> Display Name of the Service Provider. </summary>
        public string DisplayName { get; }
        /// <summary> Name of the Service Provider. </summary>
        public string ServiceProviderName { get; }
        /// <summary> URL of Dev Portal. </summary>
        public Uri DevPortalUri { get; }
        /// <summary> The URL of icon. </summary>
        public Uri IconUri { get; }
        /// <summary> The list of parameters for the Service Provider. </summary>
        public IReadOnlyList<BotServiceProviderParameter> Parameters { get; }
    }
}
