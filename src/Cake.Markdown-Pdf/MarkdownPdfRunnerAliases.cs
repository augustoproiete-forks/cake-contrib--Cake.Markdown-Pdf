using System;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.Markdown_Pdf
{
    /// <summary>
    /// Provides a wrapper around markdown-pdf functionality within a Cake build script
    /// </summary>
    public static class MarkdownPdfRunnerAliases
    {
        /// <summary>
        /// Run markdown-pdf with the configurator
        /// </summary>
        /// <param name="context">The context</param>
        /// <param name="configure">Configurator</param>
        /// <returns></returns>
        /// <example>
        /// <para>Run 'markdown-pdf'</para>
        /// <para>Cake task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("MarkdownPdf")
        ///     .Does(() =>
        /// {
        ///     MarkdownPdf(s => s.WithFilePath("README.md"));
        /// });
        /// ]]>
        /// </code>
        /// </example>
        [CakeMethodAlias]
        public static IMarkdownPdfRunner MarkdownPdf(this ICakeContext context,
            Action<MarkdownPdfRunnerSettings> configure)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            var runner = new MarkdownPdfRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            return runner.Run(configure);
        }
    }
}