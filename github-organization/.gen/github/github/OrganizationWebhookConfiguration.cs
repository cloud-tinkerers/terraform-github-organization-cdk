using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "github.OrganizationWebhookConfiguration")]
    public class OrganizationWebhookConfiguration : github.IOrganizationWebhookConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#url OrganizationWebhook#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#content_type OrganizationWebhook#content_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#insecure_ssl OrganizationWebhook#insecure_ssl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InsecureSsl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/github/r/organization_webhook#secret OrganizationWebhook#secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Secret
        {
            get;
            set;
        }
    }
}
