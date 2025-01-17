// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SupportedOperatingSystemsOperations
    /// </summary>
    public static partial class SupportedOperatingSystemsOperationsExtensions
    {
        /// <summary>
        /// Gets the data of supported operating systems by SRS.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='instanceType'>
        /// The instance type.
        /// </param>
        public static SupportedOperatingSystems Get(this ISupportedOperatingSystemsOperations operations, string instanceType = default(string))
        {
                return ((ISupportedOperatingSystemsOperations)operations).GetAsync(instanceType).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the data of supported operating systems by SRS.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='instanceType'>
        /// The instance type.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SupportedOperatingSystems> GetAsync(this ISupportedOperatingSystemsOperations operations, string instanceType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(instanceType, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
