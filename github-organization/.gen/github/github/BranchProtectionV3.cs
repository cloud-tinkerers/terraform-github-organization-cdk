using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace github
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3 github_branch_protection_v3}.</summary>
    [JsiiClass(nativeType: typeof(github.BranchProtectionV3), fullyQualifiedName: "github.BranchProtectionV3", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"github.BranchProtectionV3Config\"}}]")]
    public class BranchProtectionV3 : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/github/r/branch_protection_v3 github_branch_protection_v3} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BranchProtectionV3(Constructs.Construct scope, string id, github.IBranchProtectionV3Config config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BranchProtectionV3(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BranchProtectionV3(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRequiredPullRequestReviews", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"github.BranchProtectionV3RequiredPullRequestReviews\"}}]")]
        public virtual void PutRequiredPullRequestReviews(github.IBranchProtectionV3RequiredPullRequestReviews @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(github.IBranchProtectionV3RequiredPullRequestReviews)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequiredStatusChecks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"github.BranchProtectionV3RequiredStatusChecks\"}}]")]
        public virtual void PutRequiredStatusChecks(github.IBranchProtectionV3RequiredStatusChecks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(github.IBranchProtectionV3RequiredStatusChecks)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestrictions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"github.BranchProtectionV3Restrictions\"}}]")]
        public virtual void PutRestrictions(github.IBranchProtectionV3Restrictions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(github.IBranchProtectionV3Restrictions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnforceAdmins")]
        public virtual void ResetEnforceAdmins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireConversationResolution")]
        public virtual void ResetRequireConversationResolution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequiredPullRequestReviews")]
        public virtual void ResetRequiredPullRequestReviews()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequiredStatusChecks")]
        public virtual void ResetRequiredStatusChecks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireSignedCommits")]
        public virtual void ResetRequireSignedCommits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestrictions")]
        public virtual void ResetRestrictions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(github.BranchProtectionV3))!;

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requiredPullRequestReviews", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredPullRequestReviewsOutputReference\"}")]
        public virtual github.BranchProtectionV3RequiredPullRequestReviewsOutputReference RequiredPullRequestReviews
        {
            get => GetInstanceProperty<github.BranchProtectionV3RequiredPullRequestReviewsOutputReference>()!;
        }

        [JsiiProperty(name: "requiredStatusChecks", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredStatusChecksOutputReference\"}")]
        public virtual github.BranchProtectionV3RequiredStatusChecksOutputReference RequiredStatusChecks
        {
            get => GetInstanceProperty<github.BranchProtectionV3RequiredStatusChecksOutputReference>()!;
        }

        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"github.BranchProtectionV3RestrictionsOutputReference\"}")]
        public virtual github.BranchProtectionV3RestrictionsOutputReference Restrictions
        {
            get => GetInstanceProperty<github.BranchProtectionV3RestrictionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BranchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enforceAdminsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnforceAdminsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireConversationResolutionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireConversationResolutionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiredPullRequestReviewsInput", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredPullRequestReviews\"}", isOptional: true)]
        public virtual github.IBranchProtectionV3RequiredPullRequestReviews? RequiredPullRequestReviewsInput
        {
            get => GetInstanceProperty<github.IBranchProtectionV3RequiredPullRequestReviews?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiredStatusChecksInput", typeJson: "{\"fqn\":\"github.BranchProtectionV3RequiredStatusChecks\"}", isOptional: true)]
        public virtual github.IBranchProtectionV3RequiredStatusChecks? RequiredStatusChecksInput
        {
            get => GetInstanceProperty<github.IBranchProtectionV3RequiredStatusChecks?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireSignedCommitsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireSignedCommitsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restrictionsInput", typeJson: "{\"fqn\":\"github.BranchProtectionV3Restrictions\"}", isOptional: true)]
        public virtual github.IBranchProtectionV3Restrictions? RestrictionsInput
        {
            get => GetInstanceProperty<github.IBranchProtectionV3Restrictions?>();
        }

        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Branch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enforceAdmins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnforceAdmins
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Repository
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireConversationResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RequireConversationResolution
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireSignedCommits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RequireSignedCommits
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
