using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.RepositoryAutolinkReferenceConfig")]
    public class RepositoryAutolinkReferenceConfig : github.IRepositoryAutolinkReferenceConfig
    {
        /// <summary>This prefix appended by a number will generate a link any time it is found in an issue, pull request, or commit.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_autolink_reference#key_prefix RepositoryAutolinkReference#key_prefix}
        /// </remarks>
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyPrefix
        {
            get;
            set;
        }

        /// <summary>The repository name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_autolink_reference#repository RepositoryAutolinkReference#repository}
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public string Repository
        {
            get;
            set;
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
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
