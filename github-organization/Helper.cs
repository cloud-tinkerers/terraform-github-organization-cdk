namespace GitHubOrganization;

public static class Helper
{
    public static TerraformOutput Outputs(Construct scope, string outputId, string value, string description)
    {
        return new TerraformOutput(scope, outputId, new TerraformOutputConfig
        {
            Value = value,
            Description = description
        });
    }
}