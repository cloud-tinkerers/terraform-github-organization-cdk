using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IRepositoryEnvironmentConfig), fullyQualifiedName: "github.RepositoryEnvironmentConfig")]
    public interface IRepositoryEnvironmentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#environment RepositoryEnvironment#environment}.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        string Environment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#repository RepositoryEnvironment#repository}.</summary>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        string Repository
        {
            get;
        }

        /// <summary>deployment_branch_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#deployment_branch_policy RepositoryEnvironment#deployment_branch_policy}
        /// </remarks>
        [JsiiProperty(name: "deploymentBranchPolicy", typeJson: "{\"fqn\":\"github.RepositoryEnvironmentDeploymentBranchPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        github.IRepositoryEnvironmentDeploymentBranchPolicy? DeploymentBranchPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>reviewers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#reviewers RepositoryEnvironment#reviewers}
        /// </remarks>
        [JsiiProperty(name: "reviewers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"github.RepositoryEnvironmentReviewers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Reviewers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#wait_timer RepositoryEnvironment#wait_timer}.</summary>
        [JsiiProperty(name: "waitTimer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitTimer
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRepositoryEnvironmentConfig), fullyQualifiedName: "github.RepositoryEnvironmentConfig")]
        internal sealed class _Proxy : DeputyBase, github.IRepositoryEnvironmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#environment RepositoryEnvironment#environment}.</summary>
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
            public string Environment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#repository RepositoryEnvironment#repository}.</summary>
            [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
            public string Repository
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>deployment_branch_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#deployment_branch_policy RepositoryEnvironment#deployment_branch_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentBranchPolicy", typeJson: "{\"fqn\":\"github.RepositoryEnvironmentDeploymentBranchPolicy\"}", isOptional: true)]
            public github.IRepositoryEnvironmentDeploymentBranchPolicy? DeploymentBranchPolicy
            {
                get => GetInstanceProperty<github.IRepositoryEnvironmentDeploymentBranchPolicy?>();
            }

            /// <summary>reviewers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#reviewers RepositoryEnvironment#reviewers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reviewers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"github.RepositoryEnvironmentReviewers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Reviewers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#wait_timer RepositoryEnvironment#wait_timer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitTimer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitTimer
            {
                get => GetInstanceProperty<double?>();
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
