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
    /// Specifies the list of virtual machine scale set instance IDs.
    /// </summary>
    public partial class VirtualMachineScaleSetVMInstanceIDs
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceIDs class.
        /// </summary>
        public VirtualMachineScaleSetVMInstanceIDs() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceIDs class.
        /// </summary>
        public VirtualMachineScaleSetVMInstanceIDs(IList<string> instanceIds = default(IList<string>))
        {
            InstanceIds = instanceIds;
        }

        /// <summary>
        /// Gets or sets the virtual machine scale set instance ids.
        /// </summary>
        [JsonProperty(PropertyName = "instanceIds")]
        public IList<string> InstanceIds { get; set; }

    }
}
