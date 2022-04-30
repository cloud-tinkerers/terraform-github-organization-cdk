using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IActionsOrganizationPermissionsAllowedActionsConfig), fullyQualifiedName: "github.ActionsOrganizationPermissionsAllowedActionsConfig")]
    public interface IActionsOrganizationPermissionsAllowedActionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#github_owned_allowed ActionsOrganizationPermissions#github_owned_allowed}.</summary>
        [JsiiProperty(name: "githubOwnedAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object GithubOwnedAllowed
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#patterns_allowed ActionsOrganizationPermissions#patterns_allowed}.</summary>
        [JsiiProperty(name: "patternsAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PatternsAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#verified_allowed ActionsOrganizationPermissions#verified_allowed}.</summary>
        [JsiiProperty(name: "verifiedAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerifiedAllowed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionsOrganizationPermissionsAllowedActionsConfig), fullyQualifiedName: "github.ActionsOrganizationPermissionsAllowedActionsConfig")]
        internal sealed class _Proxy : DeputyBase, github.IActionsOrganizationPermissionsAllowedActionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#github_owned_allowed ActionsOrganizationPermissions#github_owned_allowed}.</summary>
            [JsiiProperty(name: "githubOwnedAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object GithubOwnedAllowed
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#patterns_allowed ActionsOrganizationPermissions#patterns_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patternsAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PatternsAllowed
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#verified_allowed ActionsOrganizationPermissions#verified_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifiedAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VerifiedAllowed
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
