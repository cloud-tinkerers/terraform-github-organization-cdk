using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.DataGithubRepositoryPullRequestsConfig")]
    public class DataGithubRepositoryPullRequestsConfig : github.IDataGithubRepositoryPullRequestsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/d/repository_pull_requests#base_repository DataGithubRepositoryPullRequests#base_repository}.</summary>
        [JsiiProperty(name: "baseRepository", typeJson: "{\"primitive\":\"string\"}")]
        public string BaseRepository
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/d/repository_pull_requests#base_ref DataGithubRepositoryPullRequests#base_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseRef
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/d/repository_pull_requests#head_ref DataGithubRepositoryPullRequests#head_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeadRef
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/d/repository_pull_requests#owner DataGithubRepositoryPullRequests#owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Owner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/d/repository_pull_requests#sort_by DataGithubRepositoryPullRequests#sort_by}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortBy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/d/repository_pull_requests#sort_direction DataGithubRepositoryPullRequests#sort_direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sortDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortDirection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/d/repository_pull_requests#state DataGithubRepositoryPullRequests#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
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
