using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiByValue(fqn: "github.GithubProviderConfig")]
    public class GithubProviderConfig : github.IGithubProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#alias GithubProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>app_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#app_auth GithubProvider#app_auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appAuth", typeJson: "{\"fqn\":\"github.GithubProviderAppAuth\"}", isOptional: true)]
        public github.IGithubProviderAppAuth? AppAuth
        {
            get;
            set;
        }

        /// <summary>The GitHub Base API URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#base_url GithubProvider#base_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseUrl
        {
            get;
            set;
        }

        /// <summary>Enable `insecure` mode for testing purposes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#insecure GithubProvider#insecure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Insecure
        {
            get;
            set;
        }

        /// <summary>The GitHub organization name to manage. Use this field instead of `owner` when managing organization accounts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#organization GithubProvider#organization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Organization
        {
            get;
            set;
        }

        /// <summary>The GitHub owner name to manage. Use this field instead of `organization` when managing individual accounts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#owner GithubProvider#owner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Owner
        {
            get;
            set;
        }

        /// <summary>Amount of time in milliseconds to sleep in between non-write requests to GitHub API.</summary>
        /// <remarks>
        /// Defaults to 0ms if not set.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#read_delay_ms GithubProvider#read_delay_ms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readDelayMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadDelayMs
        {
            get;
            set;
        }

        /// <summary>The OAuth token used to connect to GitHub.</summary>
        /// <remarks>
        /// Anonymous mode is enabled if both <c>token</c> and <c>app_auth</c> are not set.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#token GithubProvider#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }

        /// <summary>Amount of time in milliseconds to sleep in between writes to GitHub API.</summary>
        /// <remarks>
        /// Defaults to 1000ms or 1s if not set.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#write_delay_ms GithubProvider#write_delay_ms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "writeDelayMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WriteDelayMs
        {
            get;
            set;
        }
    }
}
