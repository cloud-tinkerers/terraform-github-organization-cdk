using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.ActionsOrganizationPermissionsEnabledRepositoriesConfig")]
    public class ActionsOrganizationPermissionsEnabledRepositoriesConfig : github.IActionsOrganizationPermissionsEnabledRepositoriesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#repository_ids ActionsOrganizationPermissions#repository_ids}.</summary>
        [JsiiProperty(name: "repositoryIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] RepositoryIds
        {
            get;
            set;
        }
    }
}
