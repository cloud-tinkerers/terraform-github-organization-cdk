using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiClass(nativeType: typeof(github.RepositoryPagesOutputReference), fullyQualifiedName: "github.RepositoryPagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RepositoryPagesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RepositoryPagesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RepositoryPagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RepositoryPagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"github.RepositoryPagesSource\"}}]")]
        public virtual void PutSource(github.IRepositoryPagesSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(github.IRepositoryPagesSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCname")]
        public virtual void ResetCname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "custom404", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Custom404
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "htmlUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HtmlUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"github.RepositoryPagesSourceOutputReference\"}")]
        public virtual github.RepositoryPagesSourceOutputReference Source
        {
            get => GetInstanceProperty<github.RepositoryPagesSourceOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"github.RepositoryPagesSource\"}", isOptional: true)]
        public virtual github.IRepositoryPagesSource? SourceInput
        {
            get => GetInstanceProperty<github.IRepositoryPagesSource?>();
        }

        [JsiiProperty(name: "cname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"github.RepositoryPages\"}", isOptional: true)]
        public virtual github.IRepositoryPages? InternalValue
        {
            get => GetInstanceProperty<github.IRepositoryPages?>();
            set => SetInstanceProperty(value);
        }
    }
}
