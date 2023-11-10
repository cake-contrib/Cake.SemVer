using System;
using System.Collections.Generic;
using Cake.Core;

namespace Cake.SemVer.Tests.Fakes
{
    internal sealed class FakeCakeArguments : ICakeArguments
    {
        private readonly Dictionary<string, List<string>> _arguments;

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeCakeArguments"/> class.
        /// </summary>
        public FakeCakeArguments()
        {
            _arguments = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        }

        /// <inheritdoc cref="ICakeArguments.HasArgument(string)"/>
        public bool HasArgument(string name)
        {
            return _arguments.ContainsKey(name);
        }

        /// <inheritdoc cref="ICakeArguments.GetArguments(string)"/>
        public ICollection<string> GetArguments(string name)
        {
            _arguments.TryGetValue(name, out List<string> value);
            ICollection<string> collection = value;
            return collection ?? Array.Empty<string>();
        }

        /// <inheritdoc cref="ICakeArguments.GetArguments"/>
        public IDictionary<string, ICollection<string>> GetArguments()
        {
            return _arguments as IDictionary<string, ICollection<string>>;
        }
    }
}