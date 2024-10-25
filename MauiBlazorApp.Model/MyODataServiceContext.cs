using Microsoft.OData.Client;
using System;
using WebAPI.Data;

public class MyODataServiceContext : DataServiceContext
{
    private static Uri _defaultUri = new Uri("http://localhost:5275/odata");
    public MyODataServiceContext() : this(_defaultUri)
    {
    }
    private MyODataServiceContext(Uri serviceRoot) : base(serviceRoot)
    {
    }
    public virtual DataServiceQuery<Video> Products
    {
        get { return CreateQuery<Video>(nameof(Video)); }
    }

    public virtual DataServiceQuery<Actor> Actors
    {
        get { return CreateQuery<Actor>("Actors"); }
    }
    public virtual DataServiceQuery<Machine> Machines
    {
        get { return CreateQuery<Machine>("Machines"); }
    }
}
