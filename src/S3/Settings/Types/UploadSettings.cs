﻿#region Using Statements
    using System;

    using Amazon.S3;
    using Amazon.S3.Model;
#endregion



namespace Cake.AWS.S3
{
    /// <summary>
    /// The settings to use with upload requests to Amazon S3
    /// </summary>
    public class UploadSettings : S3Settings
    {
        #region Constructor (1)
            /// <summary>
            /// Initializes a new instance of the <see cref="UploadSettings" /> class.
            /// </summary>
            public UploadSettings()
            {
                CannedACL = S3CannedACL.Private;
                StorageClass = S3StorageClass.Standard;

                KeyManagementServiceKeyId = "";

                Headers = new HeadersCollection();
                GenerateContentType = true;
                GenerateETag = true;
            }
        #endregion





        #region Properties (5)
            /// <summary>
            /// The ACL to be used for S3 Buckets or S3 Objects.
            /// </summary>
            public S3CannedACL CannedACL { get; set; }

            /// <summary>
            /// Specifies the Storage Class of of an S3 object. Possible values are: ReducedRedundancy:
            /// provides a 99.99% durability guarantee Standard: provides a 99.999999999% durability guarantee
            /// </summary>
            public S3StorageClass StorageClass { get; set; }


        
            /// <summary>
            /// The id of the AWS Key Management Service key that Amazon S3 should use to encrypt
            /// and decrypt the object. If a key id is not specified, the default key will be
            /// </summary>
            public string KeyManagementServiceKeyId { get; set; }


                
            /// <summary>
            /// Used to set the http-headers for an S3 object.
            /// </summary>
            public HeadersCollection Headers { get; set; }
        

                
            /// <summary>
            /// Generate the ContentType based on the file extension
            /// </summary>
            public bool GenerateContentType { get; set; }

            /// <summary>
            /// Generate an ETag based on the hash of the file
            /// </summary>
            public bool GenerateETag { get; set; }
        #endregion
    }
}
