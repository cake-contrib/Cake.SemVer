using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.SemVer
{
    /// <summary>
    /// <para>Semantic Versioning aliases.</para>
    /// <para>
    ///  In order to use aliases from this addin, you will need to also reference semver as an addin.
    ///  Here is what including Cake.SemVer in your script should look like:
    /// <code>
    /// #addin package:?Cake.SemVer
    /// #addin package:?semver&amp;version=2.0.4
    /// </code>
    /// </para>
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

