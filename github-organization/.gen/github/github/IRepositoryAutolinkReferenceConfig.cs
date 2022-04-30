using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IRepositoryAutolinkReferenceConfig), fullyQualifiedName: "github.RepositoryAutolinkReferenceConfig")]
    public interface IRepositoryAutolinkReferenceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>This prefix appended by a number will generate a link any time it is found in an issue, pull request, or commit.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_autolink_reference#key_prefix RepositoryAutolinkReference#key_prefix}
        /// </remarks>
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}")]
        string KeyPrefix
        {
            get;
        }

        /// <summary>The repository name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_autolink_reference#repository RepositoryAutolinkReference#repository}
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        string Repository
        {
            get;
        }

        /// <summary>The template of the target URL used for the links;</summary>
        /// <remarks>
        /// must be a valid URL and contain <c>&lt;num&gt;</c> for the reference number
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_autolink_reference#target_url_template RepositoryAutolinkReference#target_url_template}
        /// </remarks>
        [JsiiProperty(name: "targetUrlTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string TargetUrlTemplate
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRepositoryAutolinkReferenceConfig), fullyQualifiedName: "github.RepositoryAutolinkReferenceConfig")]
        internal sealed class _Proxy : DeputyBase, github.IRepositoryAutolinkReferenceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>This prefix appended by a number will generate a link any time it is found in an issue, pull request, or commit.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_autolink_reference#key_prefix RepositoryAutolinkReference#key_prefix}
            /// </remarks>
            [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyPrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The repository name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_autolink_reference#repository RepositoryAutolinkReference#repository}
            /// </remarks>
            [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
            public string Repository
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The template of the target URL used for the links;</summary>
            /// <remarks>
            /// must be a valid URL and contain <c>&lt;num&gt;</c> for the reference number
            ///
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_autolink_reference#target_url_template RepositoryAutolinkReference#target_url_template}
            /// </remarks>
            [JsiiProperty(name: "targetUrlTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetUrlTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
