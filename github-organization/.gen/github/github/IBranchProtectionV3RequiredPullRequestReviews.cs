using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IBranchProtectionV3RequiredPullRequestReviews), fullyQualifiedName: "github.BranchProtectionV3RequiredPullRequestReviews")]
    public interface IBranchProtectionV3RequiredPullRequestReviews
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismissal_teams BranchProtectionV3#dismissal_teams}.</summary>
        [JsiiProperty(name: "dismissalTeams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DismissalTeams
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismissal_users BranchProtectionV3#dismissal_users}.</summary>
        [JsiiProperty(name: "dismissalUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DismissalUsers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismiss_stale_reviews BranchProtectionV3#dismiss_stale_reviews}.</summary>
        [JsiiProperty(name: "dismissStaleReviews", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DismissStaleReviews
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#include_admins BranchProtectionV3#include_admins}.</summary>
        [JsiiProperty(name: "includeAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeAdmins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_code_owner_reviews BranchProtectionV3#require_code_owner_reviews}.</summary>
        [JsiiProperty(name: "requireCodeOwnerReviews", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireCodeOwnerReviews
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_approving_review_count BranchProtectionV3#required_approving_review_count}.</summary>
        [JsiiProperty(name: "requiredApprovingReviewCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RequiredApprovingReviewCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchProtectionV3RequiredPullRequestReviews), fullyQualifiedName: "github.BranchProtectionV3RequiredPullRequestReviews")]
        internal sealed class _Proxy : DeputyBase, github.IBranchProtectionV3RequiredPullRequestReviews
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismissal_teams BranchProtectionV3#dismissal_teams}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dismissalTeams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DismissalTeams
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismissal_users BranchProtectionV3#dismissal_users}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dismissalUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DismissalUsers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismiss_stale_reviews BranchProtectionV3#dismiss_stale_reviews}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dismissStaleReviews", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DismissStaleReviews
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#include_admins BranchProtectionV3#include_admins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeAdmins
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_code_owner_reviews BranchProtectionV3#require_code_owner_reviews}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireCodeOwnerReviews", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireCodeOwnerReviews
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_approving_review_count BranchProtectionV3#required_approving_review_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requiredApprovingReviewCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RequiredApprovingReviewCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
