using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IActionsOrganizationPermissionsConfig), fullyQualifiedName: "github.ActionsOrganizationPermissionsConfig")]
    public interface IActionsOrganizationPermissionsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#enabled_repositories ActionsOrganizationPermissions#enabled_repositories}.</summary>
        [JsiiProperty(name: "enabledRepositories", typeJson: "{\"primitive\":\"string\"}")]
        string EnabledRepositories
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#allowed_actions ActionsOrganizationPermissions#allowed_actions}.</summary>
        [JsiiProperty(name: "allowedActions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowedActions
        {
            get
            {
                return null;
            }
        }

        /// <summary>allowed_actions_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#allowed_actions_config ActionsOrganizationPermissions#allowed_actions_config}
        /// </remarks>
        [JsiiProperty(name: "allowedActionsConfig", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsAllowedActionsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        github.IActionsOrganizationPermissionsAllowedActionsConfig? AllowedActionsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>enabled_repositories_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#enabled_repositories_config ActionsOrganizationPermissions#enabled_repositories_config}
        /// </remarks>
        [JsiiProperty(name: "enabledRepositoriesConfig", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsEnabledRepositoriesConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        github.IActionsOrganizationPermissionsEnabledRepositoriesConfig? EnabledRepositoriesConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionsOrganizationPermissionsConfig), fullyQualifiedName: "github.ActionsOrganizationPermissionsConfig")]
        internal sealed class _Proxy : DeputyBase, github.IActionsOrganizationPermissionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#enabled_repositories ActionsOrganizationPermissions#enabled_repositories}.</summary>
            [JsiiProperty(name: "enabledRepositories", typeJson: "{\"primitive\":\"string\"}")]
            public string EnabledRepositories
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#allowed_actions ActionsOrganizationPermissions#allowed_actions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedActions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowedActions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>allowed_actions_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#allowed_actions_config ActionsOrganizationPermissions#allowed_actions_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedActionsConfig", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsAllowedActionsConfig\"}", isOptional: true)]
            public github.IActionsOrganizationPermissionsAllowedActionsConfig? AllowedActionsConfig
            {
                get => GetInstanceProperty<github.IActionsOrganizationPermissionsAllowedActionsConfig?>();
            }

            /// <summary>enabled_repositories_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#enabled_repositories_config ActionsOrganizationPermissions#enabled_repositories_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabledRepositoriesConfig", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsEnabledRepositoriesConfig\"}", isOptional: true)]
            public github.IActionsOrganizationPermissionsEnabledRepositoriesConfig? EnabledRepositoriesConfig
            {
                get => GetInstanceProperty<github.IActionsOrganizationPermissionsEnabledRepositoriesConfig?>();
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
