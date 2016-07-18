using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.SemVer
{
    /// <summary>
    /// File helper aliases.
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
        public static Semver.SemVersion ParseSemVer (this ICakeContext context, string version, bool strict)
        {
            return Semver.SemVersion.Parse (version, strict);
        }
    }
}

