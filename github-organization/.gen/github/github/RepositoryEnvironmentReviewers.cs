using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiByValue(fqn: "github.RepositoryEnvironmentReviewers")]
    public class RepositoryEnvironmentReviewers : github.IRepositoryEnvironmentReviewers
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#teams RepositoryEnvironment#teams}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "teams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? Teams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#users RepositoryEnvironment#users}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "users", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? Users
        {
            get;
            set;
        }
    }
}
