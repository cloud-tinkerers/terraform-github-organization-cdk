using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions github_actions_organization_permissions}.</summary>
    [JsiiClass(nativeType: typeof(github.ActionsOrganizationPermissions), fullyQualifiedName: "github.ActionsOrganizationPermissions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"github.ActionsOrganizationPermissionsConfig\"}}]")]
    public class ActionsOrganizationPermissions : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions github_actions_organization_permissions} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ActionsOrganizationPermissions(Constructs.Construct scope, string id, github.IActionsOrganizationPermissionsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActionsOrganizationPermissions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActionsOrganizationPermissions(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllowedActionsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"github.ActionsOrganizationPermissionsAllowedActionsConfig\"}}]")]
        public virtual void PutAllowedActionsConfig(github.IActionsOrganizationPermissionsAllowedActionsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(github.IActionsOrganizationPermissionsAllowedActionsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnabledRepositoriesConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"github.ActionsOrganizationPermissionsEnabledRepositoriesConfig\"}}]")]
        public virtual void PutEnabledRepositoriesConfig(github.IActionsOrganizationPermissionsEnabledRepositoriesConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(github.IActionsOrganizationPermissionsEnabledRepositoriesConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowedActions")]
        public virtual void ResetAllowedActions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedActionsConfig")]
        public virtual void ResetAllowedActionsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabledRepositoriesConfig")]
        public virtual void ResetEnabledRepositoriesConfig()
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
        = GetStaticProperty<string>(typeof(github.ActionsOrganizationPermissions))!;

        [JsiiProperty(name: "allowedActionsConfig", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsAllowedActionsConfigOutputReference\"}")]
        public virtual github.ActionsOrganizationPermissionsAllowedActionsConfigOutputReference AllowedActionsConfig
        {
            get => GetInstanceProperty<github.ActionsOrganizationPermissionsAllowedActionsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "enabledRepositoriesConfig", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsEnabledRepositoriesConfigOutputReference\"}")]
        public virtual github.ActionsOrganizationPermissionsEnabledRepositoriesConfigOutputReference EnabledRepositoriesConfig
        {
            get => GetInstanceProperty<github.ActionsOrganizationPermissionsEnabledRepositoriesConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedActionsConfigInput", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsAllowedActionsConfig\"}", isOptional: true)]
        public virtual github.IActionsOrganizationPermissionsAllowedActionsConfig? AllowedActionsConfigInput
        {
            get => GetInstanceProperty<github.IActionsOrganizationPermissionsAllowedActionsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedActionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllowedActionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledRepositoriesConfigInput", typeJson: "{\"fqn\":\"github.ActionsOrganizationPermissionsEnabledRepositoriesConfig\"}", isOptional: true)]
        public virtual github.IActionsOrganizationPermissionsEnabledRepositoriesConfig? EnabledRepositoriesConfigInput
        {
            get => GetInstanceProperty<github.IActionsOrganizationPermissionsEnabledRepositoriesConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledRepositoriesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnabledRepositoriesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowedActions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedActions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabledRepositories", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnabledRepositories
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
