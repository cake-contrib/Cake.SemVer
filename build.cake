var sln = "./Cake.SemVer.sln";
var nuspec = "./Cake.SemVer.nuspec";

var target = Argument ("target", "lib");

Task ("lib").Does (() => 
{
	NuGetRestore (sln);

	DotNetBuild (sln, c => c.Configuration = "Release");
});

Task ("nuget").IsDependentOn ("lib").Does (() => 
{
	CreateDirectory ("./nupkg/");

	NuGetPack (nuspec, new NuGetPackSettings { 
		Verbosity = NuGetVerbosity.Detailed,
		OutputDirectory = "./nupkg/",
		// NuGet messes up path on mac, so let's add ./ in front again
		BasePath = "././",
	});	
});

Task ("clean").Does (() => 
{
	CleanDirectories ("./**/bin");
	CleanDirectories ("./**/obj");
});

RunTarget (target);