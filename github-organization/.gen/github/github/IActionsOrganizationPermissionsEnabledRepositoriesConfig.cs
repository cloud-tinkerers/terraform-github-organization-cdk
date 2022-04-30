using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IActionsOrganizationPermissionsEnabledRepositoriesConfig), fullyQualifiedName: "github.ActionsOrganizationPermissionsEnabledRepositoriesConfig")]
    public interface IActionsOrganizationPermissionsEnabledRepositoriesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#repository_ids ActionsOrganizationPermissions#repository_ids}.</summary>
        [JsiiProperty(name: "repositoryIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] RepositoryIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IActionsOrganizationPermissionsEnabledRepositoriesConfig), fullyQualifiedName: "github.ActionsOrganizationPermissionsEnabledRepositoriesConfig")]
        internal sealed class _Proxy : DeputyBase, github.IActionsOrganizationPermissionsEnabledRepositoriesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#repository_ids ActionsOrganizationPermissions#repository_ids}.</summary>
            [JsiiProperty(name: "repositoryIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] RepositoryIds
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
