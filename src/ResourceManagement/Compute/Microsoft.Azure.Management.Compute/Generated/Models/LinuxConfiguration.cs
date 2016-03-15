// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes Windows Configuration of the OS Profile.
    /// </summary>
    public partial class LinuxConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the LinuxConfiguration class.
        /// </summary>
        public LinuxConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the LinuxConfiguration class.
        /// </summary>
        public LinuxConfiguration(bool? disablePasswordAuthentication = default(bool?), SshConfiguration ssh = default(SshConfiguration))
        {
            DisablePasswordAuthentication = disablePasswordAuthentication;
            Ssh = ssh;
        }

        /// <summary>
        /// Gets or sets whether Authentication using user name and password
        /// is allowed or not
        /// </summary>
        [JsonProperty(PropertyName = "disablePasswordAuthentication")]
        public bool? DisablePasswordAuthentication { get; set; }

        /// <summary>
        /// Gets or sets the SSH configuration for linux VMs
        /// </summary>
        [JsonProperty(PropertyName = "ssh")]
        public SshConfiguration Ssh { get; set; }

    }
}
