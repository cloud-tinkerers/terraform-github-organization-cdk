using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiByValue(fqn: "github.BranchProtectionRequiredPullRequestReviews")]
    public class BranchProtectionRequiredPullRequestReviews : github.IBranchProtectionRequiredPullRequestReviews
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection#dismissal_restrictions BranchProtection#dismissal_restrictions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dismissalRestrictions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DismissalRestrictions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection#dismiss_stale_reviews BranchProtection#dismiss_stale_reviews}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dismissStaleReviews", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DismissStaleReviews
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection#pull_request_bypassers BranchProtection#pull_request_bypassers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pullRequestBypassers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PullRequestBypassers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection#require_code_owner_reviews BranchProtection#require_code_owner_reviews}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireCodeOwnerReviews", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireCodeOwnerReviews
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection#required_approving_review_count BranchProtection#required_approving_review_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requiredApprovingReviewCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RequiredApprovingReviewCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection#restrict_dismissals BranchProtection#restrict_dismissals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restrictDismissals", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RestrictDismissals
        {
            get;
            set;
        }
    }
}
