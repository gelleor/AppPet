var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("");
builder.Build().Run();