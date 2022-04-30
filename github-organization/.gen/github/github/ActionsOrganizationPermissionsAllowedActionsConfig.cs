using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.ActionsOrganizationPermissionsAllowedActionsConfig")]
    public class ActionsOrganizationPermissionsAllowedActionsConfig : github.IActionsOrganizationPermissionsAllowedActionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#github_owned_allowed ActionsOrganizationPermissions#github_owned_allowed}.</summary>
        [JsiiProperty(name: "githubOwnedAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object GithubOwnedAllowed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#patterns_allowed ActionsOrganizationPermissions#patterns_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patternsAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PatternsAllowed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_organization_permissions#verified_allowed ActionsOrganizationPermissions#verified_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifiedAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? VerifiedAllowed
        {
            get;
            set;
        }
    }
}
