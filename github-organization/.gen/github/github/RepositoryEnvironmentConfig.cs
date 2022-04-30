using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.RepositoryEnvironmentConfig")]
    public class RepositoryEnvironmentConfig : github.IRepositoryEnvironmentConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#environment RepositoryEnvironment#environment}.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public string Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#repository RepositoryEnvironment#repository}.</summary>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public string Repository
        {
            get;
            set;
        }

        /// <summary>deployment_branch_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#deployment_branch_policy RepositoryEnvironment#deployment_branch_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentBranchPolicy", typeJson: "{\"fqn\":\"github.RepositoryEnvironmentDeploymentBranchPolicy\"}", isOptional: true)]
        public github.IRepositoryEnvironmentDeploymentBranchPolicy? DeploymentBranchPolicy
        {
            get;
            set;
        }

        /// <summary>reviewers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#reviewers RepositoryEnvironment#reviewers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reviewers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"github.RepositoryEnvironmentReviewers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Reviewers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#wait_timer RepositoryEnvironment#wait_timer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitTimer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WaitTimer
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
