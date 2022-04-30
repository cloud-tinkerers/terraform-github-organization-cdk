using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.ActionsOrganizationPermissionsConfig")]
    public class ActionsOrganizationPermissionsConfig : github.IActionsOrganizationPermissionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#enabled_repositories ActionsOrganizationPermissions#enabled_repositories}.</summary>
        [JsiiProperty(name: "enabledRepositories", typeJson: "{\"primitive\":\"string\"}")]
        public string EnabledRepositories
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#allowed_actions ActionsOrganizationPermissions#allowed_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedActions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllowedActions
        {
            get;
            set;
        }

        /// <summary>allowed_actions_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#allowed_actions_config ActionsOrganizationPermissions#allowed_actions_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedActionsConfig", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsAllowedActionsConfig\"}", isOptional: true)]
        public github.IActionsOrganizationPermissionsAllowedActionsConfig? AllowedActionsConfig
        {
            get;
            set;
        }

        /// <summary>enabled_repositories_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#enabled_repositories_config ActionsOrganizationPermissions#enabled_repositories_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledRepositoriesConfig", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsEnabledRepositoriesConfig\"}", isOptional: true)]
        public github.IActionsOrganizationPermissionsEnabledRepositoriesConfig? EnabledRepositoriesConfig
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
