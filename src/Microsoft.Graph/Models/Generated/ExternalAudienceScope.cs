// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ExternalAudienceScope.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ExternalAudienceScope
    {
    
        /// <summary>
        /// none
        /// </summary>
        None = 0,
	
        /// <summary>
        /// contacts Only
        /// </summary>
        ContactsOnly = 1,
	
        /// <summary>
        /// all
        /// </summary>
        All = 2,
	
    }
}
