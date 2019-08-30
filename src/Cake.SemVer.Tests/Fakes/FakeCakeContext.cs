using System;
using Cake.Core.IO;
using Cake.Core;
using System.Collections.Generic;
using Cake.Core.Tooling;
using Cake.Testing;

namespace Cake.SemVer.Tests.Fakes
{
    public class FakeCakeContext
    {
        ICakeContext context;
        FakeLog log;
        DirectoryPath testsDir;

        public FakeCakeContext ()
        {
            testsDir = new DirectoryPath(System.IO.Path.GetFullPath(AppContext.BaseDirectory));
            
            var fileSystem = new FileSystem ();
			var environment = new FakeEnvironment (PlatformFamily.Windows);
            var globber = new Globber (fileSystem, environment);
            log = new FakeLog ();
            var args = new FakeCakeArguments ();
            var config = new Core.Configuration.CakeConfigurationProvider (fileSystem, environment).CreateConfiguration (testsDir, new Dictionary<string, string> ());
            var toolResolutionStrategy = new ToolResolutionStrategy (fileSystem, environment, globber, config);
            var toolRepo = new ToolRepository (environment);
            var toolLocator = new ToolLocator (environment, toolRepo, toolResolutionStrategy);
            var processRunner = new ProcessRunner (fileSystem, environment, log, toolLocator, config);
            var registry = new WindowsRegistry ();
             var dataService = new FakeDataService();
            context = new CakeContext (fileSystem, environment, globber, log, args, processRunner, registry, toolLocator, dataService, config);
            context.Environment.WorkingDirectory = testsDir;
        }

        public DirectoryPath WorkingDirectory {
            get { return testsDir; }
        }
            
        public ICakeContext CakeContext {
            get { return context; }
        }

        public string GetLogs ()
        {
            return string.Join(Environment.NewLine, log.Messages);
        }

        public void DumpLogs ()
        {
            foreach (var m in log.Messages)
                Console.WriteLine (m);
        }
    }
}

