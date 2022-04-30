using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IRepositoryPages), fullyQualifiedName: "github.RepositoryPages")]
    public interface IRepositoryPages
    {
        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#source Repository#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"github.RepositoryPagesSource\"}")]
        github.IRepositoryPagesSource Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#cname Repository#cname}.</summary>
        [JsiiProperty(name: "cname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cname
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRepositoryPages), fullyQualifiedName: "github.RepositoryPages")]
        internal sealed class _Proxy : DeputyBase, github.IRepositoryPages
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#source Repository#source}
            /// </remarks>
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"github.RepositoryPagesSource\"}")]
            public github.IRepositoryPagesSource Source
            {
                get => GetInstanceProperty<github.IRepositoryPagesSource>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository#cname Repository#cname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cname
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
