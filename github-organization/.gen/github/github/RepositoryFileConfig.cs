using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.RepositoryFileConfig")]
    public class RepositoryFileConfig : github.IRepositoryFileConfig
    {
        /// <summary>The file's content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_file#content RepositoryFile#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>The file path to manage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_file#file RepositoryFile#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        public string File
        {
            get;
            set;
        }

        /// <summary>The repository name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_file#repository RepositoryFile#repository}
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public string Repository
        {
            get;
            set;
        }

        /// <summary>The branch name, defaults to "main".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_file#branch RepositoryFile#branch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Branch
        {
            get;
            set;
        }

        /// <summary>The commit author name, defaults to the authenticated user's name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_file#commit_author RepositoryFile#commit_author}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "commitAuthor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommitAuthor
        {
            get;
            set;
        }

        /// <summary>The commit author email address, defaults to the authenticated user's email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_file#commit_email RepositoryFile#commit_email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "commitEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommitEmail
        {
            get;
            set;
        }

        /// <summary>The commit message when creating or updating the file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_file#commit_message RepositoryFile#commit_message}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "commitMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommitMessage
        {
            get;
            set;
        }

        /// <summary>Enable overwriting existing files, defaults to "false".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_file#overwrite_on_create RepositoryFile#overwrite_on_create}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overwriteOnCreate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? OverwriteOnCreate
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
