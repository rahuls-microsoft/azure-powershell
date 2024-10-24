// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Vpn Profile Response for package generation.
    /// </summary>
    public partial class VpnProfileResponse
    {
        /// <summary>
        /// Initializes a new instance of the VpnProfileResponse class.
        /// </summary>
        public VpnProfileResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnProfileResponse class.
        /// </summary>

        /// <param name="profileUrl">URL to the VPN profile.
        /// </param>
        public VpnProfileResponse(string profileUrl = default(string))

        {
            this.ProfileUrl = profileUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets uRL to the VPN profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "profileUrl")]
        public string ProfileUrl {get; set; }
    }
}