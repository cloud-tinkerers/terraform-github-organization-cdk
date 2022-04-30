using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IBranchProtectionV3RequiredStatusChecks), fullyQualifiedName: "github.BranchProtectionV3RequiredStatusChecks")]
    public interface IBranchProtectionV3RequiredStatusChecks
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#contexts BranchProtectionV3#contexts}.</summary>
        [JsiiProperty(name: "contexts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Contexts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#include_admins BranchProtectionV3#include_admins}.</summary>
        [JsiiProperty(name: "includeAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeAdmins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#strict BranchProtectionV3#strict}.</summary>
        [JsiiProperty(name: "strict", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Strict
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchProtectionV3RequiredStatusChecks), fullyQualifiedName: "github.BranchProtectionV3RequiredStatusChecks")]
        internal sealed class _Proxy : DeputyBase, github.IBranchProtectionV3RequiredStatusChecks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#contexts BranchProtectionV3#contexts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contexts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Contexts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#include_admins BranchProtectionV3#include_admins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeAdmins
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#strict BranchProtectionV3#strict}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "strict", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Strict
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
