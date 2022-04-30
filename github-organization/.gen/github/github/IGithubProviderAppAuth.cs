using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IGithubProviderAppAuth), fullyQualifiedName: "github.GithubProviderAppAuth")]
    public interface IGithubProviderAppAuth
    {
        /// <summary>The GitHub App ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#id GithubProvider#id}
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>The GitHub App installation instance ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#installation_id GithubProvider#installation_id}
        /// </remarks>
        [JsiiProperty(name: "installationId", typeJson: "{\"primitive\":\"string\"}")]
        string InstallationId
        {
            get;
        }

        /// <summary>The GitHub App PEM file contents.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#pem_file GithubProvider#pem_file}
        /// </remarks>
        [JsiiProperty(name: "pemFile", typeJson: "{\"primitive\":\"string\"}")]
        string PemFile
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGithubProviderAppAuth), fullyQualifiedName: "github.GithubProviderAppAuth")]
        internal sealed class _Proxy : DeputyBase, github.IGithubProviderAppAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The GitHub App ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#id GithubProvider#id}
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The GitHub App installation instance ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#installation_id GithubProvider#installation_id}
            /// </remarks>
            [JsiiProperty(name: "installationId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstallationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The GitHub App PEM file contents.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#pem_file GithubProvider#pem_file}
            /// </remarks>
            [JsiiProperty(name: "pemFile", typeJson: "{\"primitive\":\"string\"}")]
            public string PemFile
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
