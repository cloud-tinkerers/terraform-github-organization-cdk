using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiClass(nativeType: typeof(github.DataGithubRepositoryPullRequestsResultsOutputReference), fullyQualifiedName: "github.DataGithubRepositoryPullRequestsResultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataGithubRepositoryPullRequestsResultsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataGithubRepositoryPullRequestsResultsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubRepositoryPullRequestsResultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubRepositoryPullRequestsResultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "baseRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseRef
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "baseSha", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseSha
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Body
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "draft", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Draft
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "headOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadOwner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadRef
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headRepository", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadRepository
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headSha", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadSha
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maintainerCanModify", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MaintainerCanModify
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Number
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "openedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OpenedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "openedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UpdatedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"github.DataGithubRepositoryPullRequestsResults\"}", isOptional: true)]
        public virtual github.IDataGithubRepositoryPullRequestsResults? InternalValue
        {
            get => GetInstanceProperty<github.IDataGithubRepositoryPullRequestsResults?>();
            set => SetInstanceProperty(value);
        }
    }
}
