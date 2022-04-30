using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiInterface(nativeType: typeof(IOrganizationWebhookConfiguration), fullyQualifiedName: "github.OrganizationWebhookConfiguration")]
    public interface IOrganizationWebhookConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#url OrganizationWebhook#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#content_type OrganizationWebhook#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#insecure_ssl OrganizationWebhook#insecure_ssl}.</summary>
        [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InsecureSsl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#secret OrganizationWebhook#secret}.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Secret
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrganizationWebhookConfiguration), fullyQualifiedName: "github.OrganizationWebhookConfiguration")]
        internal sealed class _Proxy : DeputyBase, github.IOrganizationWebhookConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#url OrganizationWebhook#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#content_type OrganizationWebhook#content_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#insecure_ssl OrganizationWebhook#insecure_ssl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InsecureSsl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#secret OrganizationWebhook#secret}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Secret
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
