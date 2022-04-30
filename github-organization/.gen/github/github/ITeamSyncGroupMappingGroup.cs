using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(ITeamSyncGroupMappingGroup), fullyQualifiedName: "github.TeamSyncGroupMappingGroup")]
    public interface ITeamSyncGroupMappingGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_description TeamSyncGroupMapping#group_description}.</summary>
        [JsiiProperty(name: "groupDescription", typeJson: "{\"primitive\":\"string\"}")]
        string GroupDescription
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_id TeamSyncGroupMapping#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        string GroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_name TeamSyncGroupMapping#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        string GroupName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITeamSyncGroupMappingGroup), fullyQualifiedName: "github.TeamSyncGroupMappingGroup")]
        internal sealed class _Proxy : DeputyBase, github.ITeamSyncGroupMappingGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_description TeamSyncGroupMapping#group_description}.</summary>
            [JsiiProperty(name: "groupDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_id TeamSyncGroupMapping#group_id}.</summary>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_name TeamSyncGroupMapping#group_name}.</summary>
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
