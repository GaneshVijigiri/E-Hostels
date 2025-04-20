using Projects;
var builder = DistributedApplication.CreateBuilder(args);

var eHostelsApi = builder.AddProject<EHostels_Api>("EHostels-Api");
var bff = builder.AddProject<EHostels_Bff>("EHostels-Bff")
    .WithReference(eHostelsApi);
builder.AddNpmApp("fronend", "../../frontend/ehostels.ui", "dev")
    .WithExternalHttpEndpoints();
builder.Build().Run();
