using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiByValue(fqn: "github.BranchProtectionV3RequiredPullRequestReviews")]
    public class BranchProtectionV3RequiredPullRequestReviews : github.IBranchProtectionV3RequiredPullRequestReviews
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismissal_teams BranchProtectionV3#dismissal_teams}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dismissalTeams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DismissalTeams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismissal_users BranchProtectionV3#dismissal_users}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dismissalUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DismissalUsers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#dismiss_stale_reviews BranchProtectionV3#dismiss_stale_reviews}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dismissStaleReviews", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DismissStaleReviews
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#include_admins BranchProtectionV3#include_admins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeAdmins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#require_code_owner_reviews BranchProtectionV3#require_code_owner_reviews}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireCodeOwnerReviews", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireCodeOwnerReviews
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#required_approving_review_count BranchProtectionV3#required_approving_review_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requiredApprovingReviewCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RequiredApprovingReviewCount
        {
            get;
            set;
        }
    }
}
