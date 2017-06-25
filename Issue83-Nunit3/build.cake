var target = Argument("target", "Test");
var configuration = Argument("configuration", "Release");

var buildDir = Directory("Test NUnit timeout message/bin") + Directory(configuration);
var buildToolsDir = Directory("tools");


Task("Clean")
    .Does(() =>
{
    CleanDirectory(buildDir);
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore("Test NUnit timeout message.sln");
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    MSBuild("Test NUnit timeout message.sln", settings => settings.SetConfiguration(configuration));
});


Task("Test")
    .IsDependentOn("Build")
	.Does(() =>
	{
		NuGetInstall("NUnit3TestAdapter", new NuGetInstallSettings { OutputDirectory = buildToolsDir, ExcludeVersion = true });
		
		VSTest("**/bin/" + configuration + "/*test*.dll", new VSTestSettings { TestAdapterPath = buildToolsDir });
	});


RunTarget(target);