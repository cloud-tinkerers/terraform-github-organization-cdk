using Newtonsoft.Json;

namespace GitHubOrganization.Domain;

public class GitHubRepository
{
    public GitHubRepository(string technology, string targetName)
    {
        this._technology = technology;
        this._repoName = targetName;

        this.Id = $"{this._technology}-{this._repoName}";

    }
    private readonly string[] defaultTechnologies =
    {
        "terraform", "csharp", "go", "python", "packer",
    };

    [JsonProperty("id")]
    public string Id { get; set; }

    private string _technology;

    [JsonProperty("technology")]
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

    [JsonProperty("targetname")]
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

    [JsonProperty("visibility")]
    public string Visibility
    {
        get => _visibility;
        set
        {
            if (!new string[] { "private", "public" }.Contains(value))
                throw new ArgumentException("Visibility must be public or private.");
            _visibility = value;
        }
    }
}