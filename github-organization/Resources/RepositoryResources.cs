
namespace GitHubOrganization.Resources;

public class RepositoryResources
{
    public RepositoryResources(Construct scope, string id)
    {
        CreateRepository(scope, id);
    }

    public Repository CreateRepository(Construct scope, string id)
    {
         var repo = new Repository(scope, id, new RepositoryConfig
         {
             
                Name = "test-repo",
                Description = "CDK Test Repository",
                Visibility = "private",

                HasIssues = true,
                HasDownloads = true,
                HasProjects = true,

                DeleteBranchOnMerge = true,

                AllowMergeCommit = true,
                AllowAutoMerge = true,
                AutoInit = true,
                GitignoreTemplate = "Terraform"
         });

        Outputs(scope, "full_name", repo.FullName, "A string of the form \"orgname/reponame\".");
        Outputs(scope, "html_url", repo.HtmlUrl, "URL to the repository on the web.");
        Outputs(scope, "ssh_clone_url", repo.SshCloneUrl, "URL that can be provided to git clone to clone the repository via SSH.");
        Outputs(scope, "http_clone_url", repo.HttpCloneUrl, "URL that can be provided to git clone to clone the repository via HTTPS.");

        return repo;
    }

    public static TerraformOutput Outputs(Construct scope, string id, string value, string description)
    {
        return new TerraformOutput(scope, id, new TerraformOutputConfig
        {
            Value = value,
            Description = description
        });
    }
}