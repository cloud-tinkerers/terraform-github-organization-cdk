using System;
using Constructs;
using HashiCorp.Cdktf;


namespace MyCompany.MyApp
{
    class MyApp : TerraformStack
    {
        public MyApp(Construct scope, string id) : base(scope, id)
        {
            // define resources here
            //new GitHubProvider(this, "github", new GitHubProviderConfig)
        }

        public static void Main(string[] args)
        {
            App app = new App();
            MyApp stack = new MyApp(app, "github-organization");
            new RemoteBackend(stack, new RemoteBackendProps { Hostname = "app.terraform.io", Organization = "cloud-tinkerers", Workspaces = new NamedRemoteWorkspace("github-organization") });
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}