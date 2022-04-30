using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.GithubProviderAppAuth")]
    public class GithubProviderAppAuth : github.IGithubProviderAppAuth
    {
        /// <summary>The GitHub App ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#id GithubProvider#id}
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>The GitHub App installation instance ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#installation_id GithubProvider#installation_id}
        /// </remarks>
        [JsiiProperty(name: "installationId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstallationId
        {
            get;
            set;
        }

        /// <summary>The GitHub App PEM file contents.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#pem_file GithubProvider#pem_file}
        /// </remarks>
        [JsiiProperty(name: "pemFile", typeJson: "{\"primitive\":\"string\"}")]
        public string PemFile
        {
            get;
            set;
        }
    }
}
