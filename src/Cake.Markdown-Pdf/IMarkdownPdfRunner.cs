using System;

namespace Cake.Markdown_Pdf
{
    /// <summary>
    /// Markdown-pdf runner command interface
    /// </summary>
    public interface IMarkdownPdfRunner
    {
        /// <summary>
        /// Run markdown-pdf with configurator
        /// </summary>
        IMarkdownPdfRunner Run(Action<MarkdownPdfRunnerSettings> configure = null);
        /// <summary>
        /// Run markdown-pdf with settings
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        IMarkdownPdfRunner Run(MarkdownPdfRunnerSettings settings);
    }
}