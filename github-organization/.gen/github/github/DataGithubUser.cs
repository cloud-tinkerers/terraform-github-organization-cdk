using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/github/d/user github_user}.</summary>
    [JsiiClass(nativeType: typeof(github.DataGithubUser), fullyQualifiedName: "github.DataGithubUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"github.DataGithubUserConfig\"}}]")]
    public class DataGithubUser : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/github/d/user github_user} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataGithubUser(Constructs.Construct scope, string id, github.IDataGithubUserConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubUser(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(github.DataGithubUser))!;

        [JsiiProperty(name: "avatarUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvatarUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bio", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bio
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blog", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Blog
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "company", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Company
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "followers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Followers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "following", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Following
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gpgKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GpgKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "gravatarId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GravatarId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "login", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Login
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicGists", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PublicGists
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "publicRepos", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PublicRepos
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "siteAdmin", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable SiteAdmin
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "sshKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SshKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "suspendedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuspendedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
