using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IGithubProviderConfig), fullyQualifiedName: "github.GithubProviderConfig")]
    public interface IGithubProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#alias GithubProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#app_auth GithubProvider#app_auth}
        /// </remarks>
        [JsiiProperty(name: "appAuth", typeJson: "{\"fqn\":\"github.GithubProviderAppAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        github.IGithubProviderAppAuth? AppAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>The GitHub Base API URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#base_url GithubProvider#base_url}
        /// </remarks>
        [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable `insecure` mode for testing purposes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#insecure GithubProvider#insecure}
        /// </remarks>
        [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Insecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>The GitHub organization name to manage. Use this field instead of `owner` when managing organization accounts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#organization GithubProvider#organization}
        /// </remarks>
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Organization
        {
            get
            {
                return null;
            }
        }

        /// <summary>The GitHub owner name to manage. Use this field instead of `organization` when managing individual accounts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#owner GithubProvider#owner}
        /// </remarks>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Owner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amount of time in milliseconds to sleep in between non-write requests to GitHub API.</summary>
        /// <remarks>
        /// Defaults to 0ms if not set.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#read_delay_ms GithubProvider#read_delay_ms}
        /// </remarks>
        [JsiiProperty(name: "readDelayMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadDelayMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OAuth token used to connect to GitHub.</summary>
        /// <remarks>
        /// Anonymous mode is enabled if both <c>token</c> and <c>app_auth</c> are not set.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#token GithubProvider#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amount of time in milliseconds to sleep in between writes to GitHub API.</summary>
        /// <remarks>
        /// Defaults to 1000ms or 1s if not set.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#write_delay_ms GithubProvider#write_delay_ms}
        /// </remarks>
        [JsiiProperty(name: "writeDelayMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteDelayMs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGithubProviderConfig), fullyQualifiedName: "github.GithubProviderConfig")]
        internal sealed class _Proxy : DeputyBase, github.IGithubProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#alias GithubProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>app_auth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#app_auth GithubProvider#app_auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appAuth", typeJson: "{\"fqn\":\"github.GithubProviderAppAuth\"}", isOptional: true)]
            public github.IGithubProviderAppAuth? AppAuth
            {
                get => GetInstanceProperty<github.IGithubProviderAppAuth?>();
            }

            /// <summary>The GitHub Base API URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#base_url GithubProvider#base_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable `insecure` mode for testing purposes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#insecure GithubProvider#insecure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Insecure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The GitHub organization name to manage. Use this field instead of `owner` when managing organization accounts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#organization GithubProvider#organization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Organization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The GitHub owner name to manage. Use this field instead of `organization` when managing individual accounts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github#owner GithubProvider#owner}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Owner
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
