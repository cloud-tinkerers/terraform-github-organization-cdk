using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(ITeamMembersConfig), fullyQualifiedName: "github.TeamMembersConfig")]
    public interface ITeamMembersConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>members block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_members#members TeamMembers#members}
        /// </remarks>
        [JsiiProperty(name: "members", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"github.TeamMembersMembers\"},\"kind\":\"array\"}}]}}")]
        object Members
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_members#team_id TeamMembers#team_id}.</summary>
        [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}")]
        string TeamId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITeamMembersConfig), fullyQualifiedName: "github.TeamMembersConfig")]
        internal sealed class _Proxy : DeputyBase, github.ITeamMembersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>members block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_members#members TeamMembers#members}
            /// </remarks>
            [JsiiProperty(name: "members", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"github.TeamMembersMembers\"},\"kind\":\"array\"}}]}}")]
            public object Members
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_members#team_id TeamMembers#team_id}.</summary>
            [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}")]
            public string TeamId
            {
                get => GetInstanceProperty<string>()!;
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
