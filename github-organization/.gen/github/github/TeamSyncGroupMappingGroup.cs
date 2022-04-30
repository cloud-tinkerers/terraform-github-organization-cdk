using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.TeamSyncGroupMappingGroup")]
    public class TeamSyncGroupMappingGroup : github.ITeamSyncGroupMappingGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_description TeamSyncGroupMapping#group_description}.</summary>
        [JsiiProperty(name: "groupDescription", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_id TeamSyncGroupMapping#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/team_sync_group_mapping#group_name TeamSyncGroupMapping#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupName
        {
            get;
            set;
        }
    }
}
