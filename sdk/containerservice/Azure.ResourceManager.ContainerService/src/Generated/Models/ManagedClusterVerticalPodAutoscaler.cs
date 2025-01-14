// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The ManagedClusterVerticalPodAutoscaler. </summary>
    public partial class ManagedClusterVerticalPodAutoscaler
    {
        /// <summary> Initializes a new instance of ManagedClusterVerticalPodAutoscaler. </summary>
        /// <param name="isEnabled"> Whether to enable VPA. Default value is false. </param>
        /// <param name="controlledValues"> Controls which resource value autoscaler will change. Default value is RequestsAndLimits. </param>
        /// <param name="updateMode"> Each update mode level is a superset of the lower levels. Off&lt;Initial&lt;Recreate&lt;=Auto. For example: if UpdateMode is Initial, it means VPA sets the recommended resources in the VerticalPodAutoscaler Custom Resource (from UpdateMode Off) and also assigns resources on pod creation (from Initial). The default value is Off. </param>
        public ManagedClusterVerticalPodAutoscaler(bool isEnabled, ManagedClusterWorkloadAutoScalerControlledValue controlledValues, ManagedClusterVerticalPodAutoscalerUpdateMode updateMode)
        {
            IsEnabled = isEnabled;
            ControlledValues = controlledValues;
            UpdateMode = updateMode;
        }

        /// <summary> Whether to enable VPA. Default value is false. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> Controls which resource value autoscaler will change. Default value is RequestsAndLimits. </summary>
        public ManagedClusterWorkloadAutoScalerControlledValue ControlledValues { get; set; }
        /// <summary> Each update mode level is a superset of the lower levels. Off&lt;Initial&lt;Recreate&lt;=Auto. For example: if UpdateMode is Initial, it means VPA sets the recommended resources in the VerticalPodAutoscaler Custom Resource (from UpdateMode Off) and also assigns resources on pod creation (from Initial). The default value is Off. </summary>
        public ManagedClusterVerticalPodAutoscalerUpdateMode UpdateMode { get; set; }
    }
}
