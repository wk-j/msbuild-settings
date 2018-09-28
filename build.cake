var project = "src/MyApp/MyApp.csproj";

var settings = new DotNetCoreMSBuildSettings() ;
settings.SetVersion("10.0.0");

Task("Pack").Does(() => {
    DotNetCorePack(project, new DotNetCorePackSettings {
        MSBuildSettings = settings
    });
});

Task("Build").Does(() => {
    DotNetCoreBuild(project, new DotNetCoreBuildSettings {
        MSBuildSettings = settings
    });
});

Task("Publish").Does(() => {
    DotNetCorePublish(project, new DotNetCorePublishSettings {
        MSBuildSettings = settings,
        OutputDirectory = "publish",
    });
});

var target = Argument("target", "Pack");
RunTarget(target);