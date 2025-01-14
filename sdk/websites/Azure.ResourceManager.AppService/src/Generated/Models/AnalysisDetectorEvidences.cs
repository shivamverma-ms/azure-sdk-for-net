// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class Representing Detector Evidence used for analysis. </summary>
    public partial class AnalysisDetectorEvidences
    {
        /// <summary> Initializes a new instance of AnalysisDetectorEvidences. </summary>
        public AnalysisDetectorEvidences()
        {
            Metrics = new ChangeTrackingList<DiagnosticMetricSet>();
            Data = new ChangeTrackingList<IList<AppServiceNameValuePair>>();
        }

        /// <summary> Initializes a new instance of AnalysisDetectorEvidences. </summary>
        /// <param name="source"> Name of the Detector. </param>
        /// <param name="detectorDefinition"> Detector Definition. </param>
        /// <param name="metrics"> Source Metrics. </param>
        /// <param name="data"> Additional Source Data. </param>
        /// <param name="detectorMetaData"> Detector Meta Data. </param>
        internal AnalysisDetectorEvidences(string source, DetectorDefinition detectorDefinition, IList<DiagnosticMetricSet> metrics, IList<IList<AppServiceNameValuePair>> data, DetectorMetadata detectorMetaData)
        {
            Source = source;
            DetectorDefinition = detectorDefinition;
            Metrics = metrics;
            Data = data;
            DetectorMetaData = detectorMetaData;
        }

        /// <summary> Name of the Detector. </summary>
        public string Source { get; set; }
        /// <summary> Detector Definition. </summary>
        public DetectorDefinition DetectorDefinition { get; set; }
        /// <summary> Source Metrics. </summary>
        public IList<DiagnosticMetricSet> Metrics { get; }
        /// <summary> Additional Source Data. </summary>
        public IList<IList<AppServiceNameValuePair>> Data { get; }
        /// <summary> Detector Meta Data. </summary>
        internal DetectorMetadata DetectorMetaData { get; set; }
        /// <summary> Source of the Data. </summary>
        public DetectorDataSource DataSource
        {
            get => DetectorMetaData is null ? default : DetectorMetaData.DataSource;
            set
            {
                if (DetectorMetaData is null)
                    DetectorMetaData = new DetectorMetadata();
                DetectorMetaData.DataSource = value;
            }
        }
    }
}
