using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    [JsiiClass(nativeType: typeof(github.DataGithubCollaboratorsCollaboratorOutputReference), fullyQualifiedName: "github.DataGithubCollaboratorsCollaboratorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataGithubCollaboratorsCollaboratorOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataGithubCollaboratorsCollaboratorOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubCollaboratorsCollaboratorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataGithubCollaboratorsCollaboratorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "eventsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "followersUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FollowersUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "followingUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FollowingUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gistsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GistsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "htmlUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HtmlUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "login", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Login
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Permission
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "receivedEventsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReceivedEventsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reposUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReposUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "siteAdmin", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable SiteAdmin
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "starredUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StarredUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"github.DataGithubCollaboratorsCollaborator\"}", isOptional: true)]
        public virtual github.IDataGithubCollaboratorsCollaborator? InternalValue
        {
            get => GetInstanceProperty<github.IDataGithubCollaboratorsCollaborator?>();
            set => SetInstanceProperty(value);
        }
    }
}
