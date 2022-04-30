using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/github/d/repository_pull_request github_repository_pull_request}.</summary>
    [JsiiClass(nativeType: typeof(github.DataGithubRepositoryPullRequest), fullyQualifiedName: "github.DataGithubRepositoryPullRequest", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"github.DataGithubRepositoryPullRequestConfig\"}}]")]
    public class DataGithubRepositoryPullRequest : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/github/d/repository_pull_request github_repository_pull_request} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataGithubRepositoryPullRequest(Constructs.Construct scope, string id, github.IDataGithubRepositoryPullRequestConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubRepositoryPullRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubRepositoryPullRequest(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOwner")]
        public virtual void ResetOwner()
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
        = GetStaticProperty<string>(typeof(github.DataGithubRepositoryPullRequest))!;

        [JsiiProperty(name: "baseRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseRef
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "baseSha", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseSha
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Body
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "draft", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Draft
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "headOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadOwner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadRef
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headRepository", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadRepository
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headSha", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadSha
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maintainerCanModify", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MaintainerCanModify
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "openedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OpenedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "openedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UpdatedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseRepositoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseRepositoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "baseRepository", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseRepository
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Number
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
