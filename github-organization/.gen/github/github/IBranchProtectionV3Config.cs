using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IBranchProtectionV3Config), fullyQualifiedName: "github.BranchProtectionV3Config")]
    public interface IBranchProtectionV3Config : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#branch BranchProtectionV3#branch}.</summary>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        string Branch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#repository BranchProtectionV3#repository}.</summary>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        string Repository
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#enforce_admins BranchProtectionV3#enforce_admins}.</summary>
        [JsiiProperty(name: "enforceAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnforceAdmins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_conversation_resolution BranchProtectionV3#require_conversation_resolution}.</summary>
        [JsiiProperty(name: "requireConversationResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireConversationResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>required_pull_request_reviews block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_pull_request_reviews BranchProtectionV3#required_pull_request_reviews}
        /// </remarks>
        [JsiiProperty(name: "requiredPullRequestReviews", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredPullRequestReviews\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        github.IBranchProtectionV3RequiredPullRequestReviews? RequiredPullRequestReviews
        {
            get
            {
                return null;
            }
        }

        /// <summary>required_status_checks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_status_checks BranchProtectionV3#required_status_checks}
        /// </remarks>
        [JsiiProperty(name: "requiredStatusChecks", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredStatusChecks\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        github.IBranchProtectionV3RequiredStatusChecks? RequiredStatusChecks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_signed_commits BranchProtectionV3#require_signed_commits}.</summary>
        [JsiiProperty(name: "requireSignedCommits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireSignedCommits
        {
            get
            {
                return null;
            }
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#restrictions BranchProtectionV3#restrictions}
        /// </remarks>
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"github.BranchProtectionV3Restrictions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        github.IBranchProtectionV3Restrictions? Restrictions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchProtectionV3Config), fullyQualifiedName: "github.BranchProtectionV3Config")]
        internal sealed class _Proxy : DeputyBase, github.IBranchProtectionV3Config
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#branch BranchProtectionV3#branch}.</summary>
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
            public string Branch
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#repository BranchProtectionV3#repository}.</summary>
            [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
            public string Repository
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#enforce_admins BranchProtectionV3#enforce_admins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enforceAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnforceAdmins
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_conversation_resolution BranchProtectionV3#require_conversation_resolution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireConversationResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireConversationResolution
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>required_pull_request_reviews block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_pull_request_reviews BranchProtectionV3#required_pull_request_reviews}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requiredPullRequestReviews", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredPullRequestReviews\"}", isOptional: true)]
            public github.IBranchProtectionV3RequiredPullRequestReviews? RequiredPullRequestReviews
            {
                get => GetInstanceProperty<github.IBranchProtectionV3RequiredPullRequestReviews?>();
            }

            /// <summary>required_status_checks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_status_checks BranchProtectionV3#required_status_checks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requiredStatusChecks", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredStatusChecks\"}", isOptional: true)]
            public github.IBranchProtectionV3RequiredStatusChecks? RequiredStatusChecks
            {
                get => GetInstanceProperty<github.IBranchProtectionV3RequiredStatusChecks?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_signed_commits BranchProtectionV3#require_signed_commits}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireSignedCommits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireSignedCommits
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>restrictions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#restrictions BranchProtectionV3#restrictions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"github.BranchProtectionV3Restrictions\"}", isOptional: true)]
            public github.IBranchProtectionV3Restrictions? Restrictions
            {
                get => GetInstanceProperty<github.IBranchProtectionV3Restrictions?>();
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
