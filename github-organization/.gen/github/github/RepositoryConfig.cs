using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.RepositoryConfig")]
    public class RepositoryConfig : github.IRepositoryConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#name Repository#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#allow_auto_merge Repository#allow_auto_merge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowAutoMerge", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowAutoMerge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#allow_merge_commit Repository#allow_merge_commit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowMergeCommit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowMergeCommit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#allow_rebase_merge Repository#allow_rebase_merge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowRebaseMerge", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowRebaseMerge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#allow_squash_merge Repository#allow_squash_merge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowSquashMerge", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowSquashMerge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#archived Repository#archived}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "archived", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Archived
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#archive_on_destroy Repository#archive_on_destroy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "archiveOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ArchiveOnDestroy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#auto_init Repository#auto_init}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoInit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoInit
        {
            get;
            set;
        }

        /// <summary>Can only be set after initial repository creation, and only if the target branch exists.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#default_branch Repository#default_branch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultBranch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#delete_branch_on_merge Repository#delete_branch_on_merge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteBranchOnMerge", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteBranchOnMerge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#description Repository#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#gitignore_template Repository#gitignore_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gitignoreTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GitignoreTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#has_downloads Repository#has_downloads}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hasDownloads", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HasDownloads
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#has_issues Repository#has_issues}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hasIssues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HasIssues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#has_projects Repository#has_projects}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hasProjects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HasProjects
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#has_wiki Repository#has_wiki}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hasWiki", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HasWiki
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#homepage_url Repository#homepage_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "homepageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HomepageUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#ignore_vulnerability_alerts_during_read Repository#ignore_vulnerability_alerts_during_read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreVulnerabilityAlertsDuringRead", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IgnoreVulnerabilityAlertsDuringRead
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#is_template Repository#is_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isTemplate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IsTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#license_template Repository#license_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseTemplate
        {
            get;
            set;
        }

        /// <summary>pages block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#pages Repository#pages}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pages", typeJson: "{\"fqn\":\"github.RepositoryPages\"}", isOptional: true)]
        public github.IRepositoryPages? Pages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#private Repository#private}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "private", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Private
        {
            get;
            set;
        }

        /// <summary>template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#template Repository#template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"github.RepositoryTemplate\"}", isOptional: true)]
        public github.IRepositoryTemplate? Template
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#topics Repository#topics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Topics
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#visibility Repository#visibility}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Visibility
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#vulnerability_alerts Repository#vulnerability_alerts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vulnerabilityAlerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? VulnerabilityAlerts
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
