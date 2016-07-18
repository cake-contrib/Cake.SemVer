using NUnit.Framework;
using System;
using Cake.Xamarin.Tests.Fakes;
using Cake.Core.IO;
using Cake.SemVer;

namespace Cake.SemVer.Tests
{
    [TestFixture]
    public class SemVerTests
    {
        FakeCakeContext context;

        [SetUp]
        public void Setup ()
        {
            context = new FakeCakeContext ();
        }

        [TearDown]
        public void Teardown ()
        {
            context.DumpLogs ();
        }

        [Test]
        public void ParsePrereleaseVersion ()
        {
            const string v = "1.2.3-beta4";

            var semver = context.CakeContext.ParseSemVer (v);


            Assert.AreEqual (1, semver.Major);
            Assert.AreEqual (2, semver.Minor);
            Assert.AreEqual (3, semver.Patch);
            Assert.AreEqual ("beta4", semver.Prerelease);
        }

        [Test]
        public void ParsePrereleaseAndBuildVersion ()
        {
            const string v = "1.2.3-beta4+5";

            var semver = context.CakeContext.ParseSemVer (v);


            Assert.AreEqual (1, semver.Major);
            Assert.AreEqual (2, semver.Minor);
            Assert.AreEqual (3, semver.Patch);
            Assert.AreEqual ("beta4", semver.Prerelease);
            Assert.AreEqual ("5", semver.Build);
        }
    }
}

