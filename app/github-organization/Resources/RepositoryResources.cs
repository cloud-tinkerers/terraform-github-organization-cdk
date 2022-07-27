
using GitHubOrganization.Domain;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using System.Threading.Tasks;

namespace GitHubOrganization.Resources;

public class RepositoryResources
{
    CosmosClient client;
    Database database;
    Container container;

    private static readonly string Endpoint = "https://cdkbackenddev.documents.azure.com:443/";
    private static readonly string PrimaryKey = "SHwSidCx9bOew2RmcSMS4yxgHA9CR3tmizcCmuq1KRQTJrgyAcZ8W6HGUoezQBCdRH95phcY9yEUslymhFvB2g==";

    public RepositoryResources(Construct scope)
    {
        var results = ReadDatabase().GetAwaiter().GetResult();

        foreach (var result in results)
        {
            CreateRepository(scope, result);
        }
    }

    public Repository CreateRepository(Construct scope, GitHubRepository repository)
    {
        var repo = new Repository(scope, repository.Id, new RepositoryConfig
        {

            Name = repository.TargetName,
            Description = "CDK Test Repository",
            Visibility = repository.Visibility,

            HasIssues = true,
            HasDownloads = true,
            HasProjects = true,

            DeleteBranchOnMerge = true,

            AllowMergeCommit = true,
            AllowAutoMerge = true,
            AllowRebaseMerge = false,
            AllowSquashMerge = true,

            AutoInit = true,
            GitignoreTemplate = "VisualStudio"
        });

        Helper.Outputs(scope, $"{repository.Id}_full_name", repo.FullName, "A string of the form \"orgname/reponame\".");
        Helper.Outputs(scope, $"{repository.Id}_html_url", repo.HtmlUrl, "URL to the repository on the web.");
        Helper.Outputs(scope, $"{repository.Id}_ssh_clone_url", repo.SshCloneUrl, "URL that can be provided to git clone to clone the repository via SSH.");
        Helper.Outputs(scope, $"{repository.Id}_http_clone_url", repo.HttpCloneUrl, "URL that can be provided to git clone to clone the repository via HTTPS.");

        return repo;
    }

    public async Task<FeedResponse<GitHubRepository>> ReadDatabase()
    {
        client = new CosmosClient(Endpoint, PrimaryKey, new CosmosClientOptions
        {
            ConnectionMode = ConnectionMode.Gateway
        });
        database = await client.CreateDatabaseIfNotExistsAsync("cdkbackend");
        container = await database.CreateContainerIfNotExistsAsync("repositories", "/targetname");

        var query = container.GetItemLinqQueryable<GitHubRepository>();
        var iterator = query.ToFeedIterator();
        return await iterator.ReadNextAsync();
    }
}