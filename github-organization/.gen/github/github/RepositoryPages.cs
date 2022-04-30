using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.RepositoryPages")]
    public class RepositoryPages : github.IRepositoryPages
    {
        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#source Repository#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"github.RepositoryPagesSource\"}")]
        public github.IRepositoryPagesSource Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#cname Repository#cname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cname
        {
            get;
            set;
        }
    }
}
