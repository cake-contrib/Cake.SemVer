using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.SemVer
{
    /// <summary>
    /// Semantic Versioning aliases.
    /// </summary>
    [CakeAliasCategory("Semantic Versioning")]
    public static class SemVerAliases
    {
        /// <summary>
        /// Parse a semantic version from a string
        /// </summary>
        /// <returns>The semantic version string to parse.</returns>
        /// <param name="context">The context.</param>
        /// <param name="version">The semantic version.</param>
        [CakeMethodAlias]
        public static Semver.SemVersion ParseSemVer (this ICakeContext context, string version)
        {
            return Semver.SemVersion.Parse (version);
        }

        /// <summary>
        /// Parse a semantic version from a string
        /// </summary>
        /// <returns>The semantic version string to parse.</returns>
        /// <param name="context">The context.</param>
        /// <param name="version">The semantic version.</param>
        /// <param name="strict">Enforce strict SemVer</param>
        [CakeMethodAlias]
        public static Semver.SemVersion ParseSemVer (this ICakeContext context, string version, bool strict)
        {
            return Semver.SemVersion.Parse (version, strict);
        }

        /// <summary>
        /// Create a Semantic Version instance
        /// </summary>
        /// <returns>The semantic version.</returns>
        /// <param name="context">The context.</param>
        /// <param name="major">The major.</param>
        /// <param name="minor">The minor.</param>
        /// <param name="patch">The patch.</param>
        [CakeMethodAlias]
        public static Semver.SemVersion CreateSemVer (this ICakeContext context, int major, int minor, int patch)
        {
            return new Semver.SemVersion (major, minor, patch);
        }

        /// <summary>
        /// Create a Semantic Version instance
        /// </summary>
        /// <returns>The semantic version.</returns>
        /// <param name="context">The context.</param>
        /// <param name="major">The major.</param>
        /// <param name="minor">The minor.</param>
        /// <param name="patch">The patch.</param>
        /// <param name="prerelease">The prerelease.</param>
        [CakeMethodAlias]
        public static Semver.SemVersion CreateSemVer (this ICakeContext context, int major, int minor, int patch, string prerelease)
        {
            return new Semver.SemVersion (major, minor, patch, prerelease);
        }

        /// <summary>
        /// Create a Semantic Version instance
        /// </summary>
        /// <returns>The semantic version.</returns>
        /// <param name="context">The context.</param>
        /// <param name="major">The major.</param>
        /// <param name="minor">The minor.</param>
        /// <param name="patch">The patch.</param>
        /// <param name="prerelease">The prerelease.</param>
        /// <param name="build">The build.</param>
        [CakeMethodAlias]
        public static Semver.SemVersion CreateSemVer (this ICakeContext context, int major, int minor, int patch, string prerelease, string build)
        {
            return new Semver.SemVersion (major, minor, patch, prerelease, build);
        }
    }
}

