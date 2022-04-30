using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.BranchProtectionV3Config")]
    public class BranchProtectionV3Config : github.IBranchProtectionV3Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#branch BranchProtectionV3#branch}.</summary>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public string Branch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#repository BranchProtectionV3#repository}.</summary>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public string Repository
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#enforce_admins BranchProtectionV3#enforce_admins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enforceAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnforceAdmins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_conversation_resolution BranchProtectionV3#require_conversation_resolution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireConversationResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireConversationResolution
        {
            get;
            set;
        }

        /// <summary>required_pull_request_reviews block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_pull_request_reviews BranchProtectionV3#required_pull_request_reviews}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requiredPullRequestReviews", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredPullRequestReviews\"}", isOptional: true)]
        public github.IBranchProtectionV3RequiredPullRequestReviews? RequiredPullRequestReviews
        {
            get;
            set;
        }

        /// <summary>required_status_checks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_status_checks BranchProtectionV3#required_status_checks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requiredStatusChecks", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredStatusChecks\"}", isOptional: true)]
        public github.IBranchProtectionV3RequiredStatusChecks? RequiredStatusChecks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_signed_commits BranchProtectionV3#require_signed_commits}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireSignedCommits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireSignedCommits
        {
            get;
            set;
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#restrictions BranchProtectionV3#restrictions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"github.BranchProtectionV3Restrictions\"}", isOptional: true)]
        public github.IBranchProtectionV3Restrictions? Restrictions
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
