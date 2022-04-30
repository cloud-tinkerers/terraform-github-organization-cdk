using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IBranchProtectionV3Restrictions), fullyQualifiedName: "github.BranchProtectionV3Restrictions")]
    public interface IBranchProtectionV3Restrictions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#apps BranchProtectionV3#apps}.</summary>
        [JsiiProperty(name: "apps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Apps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#teams BranchProtectionV3#teams}.</summary>
        [JsiiProperty(name: "teams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Teams
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#users BranchProtectionV3#users}.</summary>
        [JsiiProperty(name: "users", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Users
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchProtectionV3Restrictions), fullyQualifiedName: "github.BranchProtectionV3Restrictions")]
        internal sealed class _Proxy : DeputyBase, github.IBranchProtectionV3Restrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#apps BranchProtectionV3#apps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "apps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Apps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#teams BranchProtectionV3#teams}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "teams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Teams
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3#users BranchProtectionV3#users}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "users", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Users
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
