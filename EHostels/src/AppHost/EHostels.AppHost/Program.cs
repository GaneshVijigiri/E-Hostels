
using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var eHostelsApi = builder.AddProject<EHostels_API>("EHostels-API");
var bff = builder.AddProject<EHostels_BFF>("EHostels-BFF").WithReference(eHostelsApi);
builder.AddNpmApp("frontend", "../../frontend/ehostels.ui", "dev").WithExternalHttpEndpoints();

builder.Build().Run();
