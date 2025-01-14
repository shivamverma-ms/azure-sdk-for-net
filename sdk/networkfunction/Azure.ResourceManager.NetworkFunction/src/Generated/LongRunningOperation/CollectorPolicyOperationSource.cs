// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetworkFunction
{
    internal class CollectorPolicyOperationSource : IOperationSource<CollectorPolicyResource>
    {
        private readonly ArmClient _client;

        internal CollectorPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        CollectorPolicyResource IOperationSource<CollectorPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CollectorPolicyData.DeserializeCollectorPolicyData(document.RootElement);
            return new CollectorPolicyResource(_client, data);
        }

        async ValueTask<CollectorPolicyResource> IOperationSource<CollectorPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CollectorPolicyData.DeserializeCollectorPolicyData(document.RootElement);
            return new CollectorPolicyResource(_client, data);
        }
    }
}
