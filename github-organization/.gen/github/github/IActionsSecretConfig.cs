using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IActionsSecretConfig), fullyQualifiedName: "github.ActionsSecretConfig")]
    public interface IActionsSecretConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_secret#repository ActionsSecret#repository}.</summary>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        string Repository
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_secret#secret_name ActionsSecret#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_secret#encrypted_value ActionsSecret#encrypted_value}.</summary>
        [JsiiProperty(name: "encryptedValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptedValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_secret#plaintext_value ActionsSecret#plaintext_value}.</summary>
        [JsiiProperty(name: "plaintextValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlaintextValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionsSecretConfig), fullyQualifiedName: "github.ActionsSecretConfig")]
        internal sealed class _Proxy : DeputyBase, github.IActionsSecretConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_secret#repository ActionsSecret#repository}.</summary>
            [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
            public string Repository
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_secret#secret_name ActionsSecret#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_secret#encrypted_value ActionsSecret#encrypted_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptedValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptedValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_secret#plaintext_value ActionsSecret#plaintext_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "plaintextValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlaintextValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
