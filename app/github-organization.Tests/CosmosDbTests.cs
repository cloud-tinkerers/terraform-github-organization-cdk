using NUnit.Framework;
using GitHubOrganization.Domain;
using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;
using System;
using Microsoft.Azure.Cosmos.Linq;
using System.Collections.Generic;

namespace GitHubOrganization.Tests;

public interface IRepositoryService<GitHubRepository>
{
    Task<IEnumerable<GitHubRepository>> GetRepositories();
}

public class RepositoryService<GitHubRepository> : IRepositoryService<GitHubRepository>, IDisposable
{
    Container _container;

    public RepositoryService(Container container)
    {
        _container = container;
    }

    public async Task<IEnumerable<GitHubRepository>> GetRepositories()
    {
        var query = _container.GetItemQueryIterator<GitHubRepository>(new QueryDefinition)
        
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

}
public class Tests
{
    CosmosClient client;
    Database database;
    Container container;

    private static readonly string Endpoint = "https://cdkbackenddev.documents.azure.com:443/";
    private static readonly string PrimaryKey = "SHwSidCx9bOew2RmcSMS4yxgHA9CR3tmizcCmuq1KRQTJrgyAcZ8W6HGUoezQBCdRH95phcY9yEUslymhFvB2g==";


    [SetUp]
    public async Task Setup()
    {
        client = new CosmosClient(Endpoint, PrimaryKey, new CosmosClientOptions
        {
            ConnectionMode = ConnectionMode.Gateway
        });
        database = await client.CreateDatabaseIfNotExistsAsync("cdkbackend");
        container = await database.CreateContainerIfNotExistsAsync("repositories", "/targetname");

        IRepositoryService<GitHubRepository> repoService = new RepositoryService<GitHubRepository>(container);
        var results = await repoService.GetRepositories();
        
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}