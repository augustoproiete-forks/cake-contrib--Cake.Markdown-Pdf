using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Markdown_Pdf
{
    /// <summary>
    /// A wrapper around the markdown-pdf node module
    /// </summary>
    public class MarkdownPdfRunner : Tool<MarkdownPdfRunnerSettings>, IMarkdownPdfRunner
    {
        /// <summary>
        /// Constructor for <see cref="MarkdownPdfRunner"/>
        /// </summary>
        /// <param name="fileSystem"></param>
        /// <param name="environment"></param>
        /// <param name="processRunner"></param>
        /// <param name="tools"></param>
        public MarkdownPdfRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools) { }

        /// <summary>
        /// Gets the name of the tool
        /// </summary>
        /// <returns></returns>
        protected override string GetToolName() => "Markdown-pdf Runner";

        /// <summary>
        /// Gets the name of the tool executables
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<string> GetToolExecutableNames() => new[] { "markdown-pdf.cmd", "markdown-pdf" };

        private static ProcessArgumentBuilder GetSettingsArguments(MarkdownPdfRunnerSettings settings)
        {
            var args = new ProcessArgumentBuilder();
            settings?.Evaluate(args);
            return args;
        }

        /// <summary>
        /// Run markdown-pdf with configurator
        /// </summary>
        public IMarkdownPdfRunner Run(Action<MarkdownPdfRunnerSettings> configure = null)
        {
            var settings = new MarkdownPdfRunnerSettings();
            configure?.Invoke(settings);
            return Run(settings);
        }

        /// <summary>
        /// Run markdown-pdf with settings
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public IMarkdownPdfRunner Run(MarkdownPdfRunnerSettings settings)
        {
            var args = GetSettingsArguments(settings);
            Run(settings, args);
            return this;
        }
    }
}
