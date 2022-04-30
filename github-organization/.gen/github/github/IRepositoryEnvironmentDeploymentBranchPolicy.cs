using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IRepositoryEnvironmentDeploymentBranchPolicy), fullyQualifiedName: "github.RepositoryEnvironmentDeploymentBranchPolicy")]
    public interface IRepositoryEnvironmentDeploymentBranchPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#custom_branch_policies RepositoryEnvironment#custom_branch_policies}.</summary>
        [JsiiProperty(name: "customBranchPolicies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object CustomBranchPolicies
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#protected_branches RepositoryEnvironment#protected_branches}.</summary>
        [JsiiProperty(name: "protectedBranches", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ProtectedBranches
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRepositoryEnvironmentDeploymentBranchPolicy), fullyQualifiedName: "github.RepositoryEnvironmentDeploymentBranchPolicy")]
        internal sealed class _Proxy : DeputyBase, github.IRepositoryEnvironmentDeploymentBranchPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#custom_branch_policies RepositoryEnvironment#custom_branch_policies}.</summary>
            [JsiiProperty(name: "customBranchPolicies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object CustomBranchPolicies
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/repository_environment#protected_branches RepositoryEnvironment#protected_branches}.</summary>
            [JsiiProperty(name: "protectedBranches", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ProtectedBranches
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
