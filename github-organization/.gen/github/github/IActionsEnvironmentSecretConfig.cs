using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IActionsEnvironmentSecretConfig), fullyQualifiedName: "github.ActionsEnvironmentSecretConfig")]
    public interface IActionsEnvironmentSecretConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#environment ActionsEnvironmentSecret#environment}.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        string Environment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#repository ActionsEnvironmentSecret#repository}.</summary>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        string Repository
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#secret_name ActionsEnvironmentSecret#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#encrypted_value ActionsEnvironmentSecret#encrypted_value}.</summary>
        [JsiiProperty(name: "encryptedValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptedValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#plaintext_value ActionsEnvironmentSecret#plaintext_value}.</summary>
        [JsiiProperty(name: "plaintextValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlaintextValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionsEnvironmentSecretConfig), fullyQualifiedName: "github.ActionsEnvironmentSecretConfig")]
        internal sealed class _Proxy : DeputyBase, github.IActionsEnvironmentSecretConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#environment ActionsEnvironmentSecret#environment}.</summary>
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
            public string Environment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#repository ActionsEnvironmentSecret#repository}.</summary>
            [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
            public string Repository
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#secret_name ActionsEnvironmentSecret#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#encrypted_value ActionsEnvironmentSecret#encrypted_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptedValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptedValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/actions_environment_secret#plaintext_value ActionsEnvironmentSecret#plaintext_value}.</summary>
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
