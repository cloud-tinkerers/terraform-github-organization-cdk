
namespace GitHubOrganization.Resources;

public class RepositoryResources
{
    public RepositoryResources(Construct scope, string id)
    {
         new Repository(scope, id, new RepositoryConfig
         {
             
                Name = "test-repo",
                Description = "CDK Test Repository",
                Visibility = "private",

                HasIssues = true,
                HasDownloads = true,
                HasProjects = true,

                AllowMergeCommit = true,
                AllowAutoMerge = true,
                AutoInit = true,
                GitignoreTemplate = "Terraform"
         });
    }
}