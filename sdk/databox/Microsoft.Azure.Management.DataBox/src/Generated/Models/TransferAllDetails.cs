// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details to transfer all data.
    /// </summary>
    public partial class TransferAllDetails
    {
        /// <summary>
        /// Initializes a new instance of the TransferAllDetails class.
        /// </summary>
        public TransferAllDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransferAllDetails class.
        /// </summary>
        /// <param name="dataAccountType">Type of the account of data. Possible
        /// values include: 'StorageAccount', 'ManagedDisk'</param>
        /// <param name="transferAllBlobs">To indicate if all Azure blobs have
        /// to be transferred</param>
        /// <param name="transferAllFiles">To indicate if all Azure Files have
        /// to be transferred</param>
        public TransferAllDetails(DataAccountType dataAccountType, bool? transferAllBlobs = default(bool?), bool? transferAllFiles = default(bool?))
        {
            DataAccountType = dataAccountType;
            TransferAllBlobs = transferAllBlobs;
            TransferAllFiles = transferAllFiles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the account of data. Possible values include:
        /// 'StorageAccount', 'ManagedDisk'
        /// </summary>
        [JsonProperty(PropertyName = "dataAccountType")]
        public DataAccountType DataAccountType { get; set; }

        /// <summary>
        /// Gets or sets to indicate if all Azure blobs have to be transferred
        /// </summary>
        [JsonProperty(PropertyName = "transferAllBlobs")]
        public bool? TransferAllBlobs { get; set; }

        /// <summary>
        /// Gets or sets to indicate if all Azure Files have to be transferred
        /// </summary>
        [JsonProperty(PropertyName = "transferAllFiles")]
        public bool? TransferAllFiles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
