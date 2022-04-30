using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/github/r/repository_environment github_repository_environment}.</summary>
    [JsiiClass(nativeType: typeof(github.RepositoryEnvironment), fullyQualifiedName: "github.RepositoryEnvironment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"github.RepositoryEnvironmentConfig\"}}]")]
    public class RepositoryEnvironment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/github/r/repository_environment github_repository_environment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RepositoryEnvironment(Constructs.Construct scope, string id, github.IRepositoryEnvironmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RepositoryEnvironment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RepositoryEnvironment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDeploymentBranchPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"github.RepositoryEnvironmentDeploymentBranchPolicy\"}}]")]
        public virtual void PutDeploymentBranchPolicy(github.IRepositoryEnvironmentDeploymentBranchPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(github.IRepositoryEnvironmentDeploymentBranchPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeploymentBranchPolicy")]
        public virtual void ResetDeploymentBranchPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReviewers")]
        public virtual void ResetReviewers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitTimer")]
        public virtual void ResetWaitTimer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(github.RepositoryEnvironment))!;

        [JsiiProperty(name: "deploymentBranchPolicy", typeJson: "{\"fqn\":\"github.RepositoryEnvironmentDeploymentBranchPolicyOutputReference\"}")]
        public virtual github.RepositoryEnvironmentDeploymentBranchPolicyOutputReference DeploymentBranchPolicy
        {
            get => GetInstanceProperty<github.RepositoryEnvironmentDeploymentBranchPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentBranchPolicyInput", typeJson: "{\"fqn\":\"github.RepositoryEnvironmentDeploymentBranchPolicy\"}", isOptional: true)]
        public virtual github.IRepositoryEnvironmentDeploymentBranchPolicy? DeploymentBranchPolicyInput
        {
            get => GetInstanceProperty<github.IRepositoryEnvironmentDeploymentBranchPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reviewersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"github.RepositoryEnvironmentReviewers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ReviewersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitTimerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitTimerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Environment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Repository
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reviewers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"github.RepositoryEnvironmentReviewers\"},\"kind\":\"array\"}}]}}")]
        public virtual object Reviewers
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitTimer", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitTimer
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
