
namespace GitHubOrganization.Resources;

public class GithubRepository
{
    public GithubRepository(string technology, string targetName)
    {
        this._technology = technology;
        this._repoName = targetName;

    }
    private readonly string[] defaultTechnologies =
    {
        "terraform", "csharp", "go", "python", "packer",
    };

    private string _technology;

    public string Technology
    {
        get => _technology;
        set
        {
            if (!defaultTechnologies.Contains(value))
                throw new ArgumentException($"Technology must be one of the following: {string.Join(',', defaultTechnologies)}.");

            _technology = value;
        }
    }

    private string _repoName;

    public string TargetName
    {
        get => _repoName;
        set
        {
            if (!Regex.IsMatch(value, "^[a-z0-9\\$]+$"))
                throw new ArgumentException("Repository naming convention is lowercase alphanumeric and dashes.");
        }
    }

    private string _visibility;

    public string Visibility
    {
        get => _visibility;
        set
        {
            if (!new[] {"private", "public"}.Contains(value))
                throw new ArgumentException("Visibility must be public or private.");
        }
    }

    //public string Name { get; set; } = $"{_technology}-{_repoName}";
}

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
            AllowRebaseMerge = false,
            AllowSquashMerge = true,

            AutoInit = true,
            GitignoreTemplate = "VisualStudio"
        });

        Helper.Outputs(scope, "full_name", repo.FullName, "A string of the form \"orgname/reponame\".");
        Helper.Outputs(scope, "html_url", repo.HtmlUrl, "URL to the repository on the web.");
        Helper.Outputs(scope, "ssh_clone_url", repo.SshCloneUrl, "URL that can be provided to git clone to clone the repository via SSH.");
        Helper.Outputs(scope, "http_clone_url", repo.HttpCloneUrl, "URL that can be provided to git clone to clone the repository via HTTPS.");

        return repo;
    }
}