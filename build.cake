var Configuration = Argument("Configuration", "Debug");
var Target = Argument("Target", "Pack");
var NupkgDirectory = Context.Environment.WorkingDirectory.Combine("nupkg");

Task("Pack")
    .Does(() =>
    {
        DotNetPack("./ExternalPackage1/ExternalPackage1/ExternalPackage1.csproj", new DotNetPackSettings
        {
            Configuration = Configuration,
            OutputDirectory = NupkgDirectory
        });
    });
RunTarget(Target);