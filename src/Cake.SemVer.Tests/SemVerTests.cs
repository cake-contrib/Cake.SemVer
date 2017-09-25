using Xunit;
using System;
using Cake.Xamarin.Tests.Fakes;
using Cake.Core.IO;
using Cake.SemVer;

namespace Cake.SemVer.Tests
{
    public class SemVerTests : IDisposable
    {
        FakeCakeContext context;

        public SemVerTests ()
        {
            context = new FakeCakeContext ();
        }

        public void Dispose ()
        {
            context.DumpLogs ();
        }

        [Fact]
        public void ParsePrereleaseVersion ()
        {
            const string v = "1.2.3-beta4";

            var semver = context.CakeContext.ParseSemVer (v);

            Assert.Equal (1, semver.Major);
            Assert.Equal (2, semver.Minor);
            Assert.Equal (3, semver.Patch);
            Assert.Equal ("beta4", semver.Prerelease);
        }

        [Fact]
        public void ParsePrereleaseAndBuildVersion ()
        {
            const string v = "1.2.3-beta4+5";

            var semver = context.CakeContext.ParseSemVer (v);

            Assert.Equal (1, semver.Major);
            Assert.Equal (2, semver.Minor);
            Assert.Equal (3, semver.Patch);
            Assert.Equal ("beta4", semver.Prerelease);
            Assert.Equal ("5", semver.Build);
        }
    }
}

