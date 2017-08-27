using Cake.Core.IO;

namespace Cake.Markdown_Pdf
{
    /// <summary>
    /// Extensions to apply settings to <see cref="MarkdownPdfRunnerSettings"/>
    /// </summary>
    public static class MarkdownPdfRunnerSettingsExtensions
    {
        /// <summary>
        /// Set the working directory context from where the markdown-pdf command will run
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="workingDirectory"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings UseWorkingDirectory(this MarkdownPdfRunnerSettings settings, DirectoryPath workingDirectory)
        {
            settings.WorkingDirectory = workingDirectory;
            return settings;
        }
        /// <summary>
        /// output usage information
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithHelp(this MarkdownPdfRunnerSettings settings)
        {
            settings.Help = true;
            return settings;
        }
        /// <summary>
        /// output the version number
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithVersion(this MarkdownPdfRunnerSettings settings)
        {
            settings.Version = true;
            return settings;
        }
        /// <summary>
        /// Path to phantom binary
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="phantomPath"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithPhantomPath(this MarkdownPdfRunnerSettings settings, string phantomPath)
        {
            settings.PhantomPath = phantomPath;
            return settings;
        }
        /// <summary>
        /// Path to runnings (header, footer)
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="runningsPath"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithRunningsPath(this MarkdownPdfRunnerSettings settings, string runningsPath)
        {
            settings.RunningsPath = runningsPath;
            return settings;
        }
        /// <summary>
        /// Path to custom CSS file
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="cssPath"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithCssPath(this MarkdownPdfRunnerSettings settings, string cssPath)
        {
            settings.CssPath = cssPath;
            return settings;
        }
        /// <summary>
        /// Path to custom highlight-CSS file
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="highlightCssPath"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithHighlightCssPath(this MarkdownPdfRunnerSettings settings, string highlightCssPath)
        {
            settings.HighlightCssPath = highlightCssPath;
            return settings;
        }
        /// <summary>
        /// Options to pass to Remarkable
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="remarkableOptions"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithRemarkableOptions(this MarkdownPdfRunnerSettings settings, string remarkableOptions)
        {
            settings.RemarkableOptions = remarkableOptions;
            return settings;
        }
        /// <summary>
        /// 'A3', 'A4', 'A5', 'Legal', 'Letter' or 'Tabloid'
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="paperFormat"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithPaperFormat(this MarkdownPdfRunnerSettings settings, MarkdownPdfPaperFormat paperFormat)
        {
            settings.PaperFormat = paperFormat;
            return settings;
        }
        /// <summary>
        /// 'portrait' or 'landscape'
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="orientation"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithOrientation(this MarkdownPdfRunnerSettings settings, MarkdownPdfOrientation orientation)
        {
            settings.Orientation = orientation;
            return settings;
        }

        /// <summary>
        /// Supported dimension units are: 'mm', 'cm', 'in', 'px'
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="border"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithPaperBorder(this MarkdownPdfRunnerSettings settings, string border)
        {
            settings.PaperBorder = border;
            return settings;
        }

        /// <summary>
        /// Delay before rendering the PDF
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="renderDelay"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithRenderDelay(this MarkdownPdfRunnerSettings settings, int renderDelay)
        {
            settings.RenderDelay = renderDelay;
            return settings;
        }
        /// <summary>
        /// Timeout before the page is rendered in case `page.onLoadFinished` isn't fired
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="loadTimeout"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithLoadTimeout(this MarkdownPdfRunnerSettings settings, int loadTimeout)
        {
            settings.LoadTimeout = loadTimeout;
            return settings;
        }
        /// <summary>
        /// Path of the markdown file to convert
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithFilePath(this MarkdownPdfRunnerSettings settings, string filePath)
        {
            settings.FilePath = filePath;
            return settings;
        }
        /// <summary>
        /// Path of where to save the PDF
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="outFilePath"></param>
        /// <returns></returns>
        public static MarkdownPdfRunnerSettings WithOutFilePath(this MarkdownPdfRunnerSettings settings, string outFilePath)
        {
            settings.OutFilePath = outFilePath;
            return settings;
        }
    }
}