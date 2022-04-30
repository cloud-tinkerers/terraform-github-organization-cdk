using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/github/d/ip_ranges github_ip_ranges}.</summary>
    [JsiiClass(nativeType: typeof(github.DataGithubIpRanges), fullyQualifiedName: "github.DataGithubIpRanges", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"github.DataGithubIpRangesConfig\"}}]")]
    public class DataGithubIpRanges : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/github/d/ip_ranges github_ip_ranges} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataGithubIpRanges(Constructs.Construct scope, string id, github.IDataGithubIpRangesConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubIpRanges(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubIpRanges(DeputyProps props): base(props)
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
        = GetStaticProperty<string>(typeof(github.DataGithubIpRanges))!;

        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Actions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "actionsIpv4", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ActionsIpv4
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "actionsIpv6", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ActionsIpv6
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dependabot", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Dependabot
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dependabotIpv4", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DependabotIpv4
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dependabotIpv6", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DependabotIpv6
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "git", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Git
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "gitIpv4", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GitIpv4
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "gitIpv6", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GitIpv6
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hooks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Hooks
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hooksIpv4", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HooksIpv4
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hooksIpv6", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HooksIpv6
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "importer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Importer
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "importerIpv4", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ImporterIpv4
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "importerIpv6", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ImporterIpv6
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "pages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Pages
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "pagesIpv4", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PagesIpv4
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "pagesIpv6", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PagesIpv6
        {
            get => GetInstanceProperty<string[]>()!;
        }
    }
}
