using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Markdown_Pdf
{
    /// <summary>
    /// Markdown-pdf settings
    /// </summary>
    public class MarkdownPdfRunnerSettings : ToolSettings
    {
        internal void Evaluate(ProcessArgumentBuilder args)
        {
            if (Help)
                args.Append(MarkdownPdfOptions.Help);
            if (Version)
                args.Append($"{MarkdownPdfOptions.Version}");
            if (!string.IsNullOrWhiteSpace(PhantomPath))
                args.Append($"{MarkdownPdfOptions.PhantomPath} {PhantomPath}");
            if (!string.IsNullOrWhiteSpace(RunningsPath))
                args.Append($"{MarkdownPdfOptions.RunningsPath} {RunningsPath}");
            if (!string.IsNullOrWhiteSpace(CssPath))
                args.Append($"{MarkdownPdfOptions.CssPath} {CssPath}");
            if (!string.IsNullOrWhiteSpace(HighlightCssPath))
                args.Append($"{MarkdownPdfOptions.HighlightCssPath} {HighlightCssPath}");
            if (!string.IsNullOrWhiteSpace(RemarkableOptions))
                args.Append($"{MarkdownPdfOptions.RemarkableOptions} {RemarkableOptions}");
            if (PaperFormat != MarkdownPdfPaperFormat.None)
                args.Append($"{MarkdownPdfOptions.PaperFormat} {PaperFormat}");
            if (Orientation != MarkdownPdfOrientation.None)
                args.Append($"{MarkdownPdfOptions.Orientation} {Orientation}");
            if (!string.IsNullOrWhiteSpace(PaperBorder))
                args.Append($"{MarkdownPdfOptions.PaperBorder} {PaperBorder}");
            if (RenderDelay > 0)
                args.Append($"{MarkdownPdfOptions.RenderDelay} {RenderDelay}");
            if (LoadTimeout > 0)
                args.Append($"{MarkdownPdfOptions.LoadTimeout} {LoadTimeout}");
            if (!string.IsNullOrWhiteSpace(OutFilePath))
                args.Append($"{MarkdownPdfOptions.OutFilePath} {OutFilePath}");
            if (!string.IsNullOrWhiteSpace(FilePath))
                args.Append(FilePath);
        }

        /// <summary>
        /// output usage information
        /// </summary>
        public bool Help { get; set; }
        /// <summary>
        /// output the version number
        /// </summary>
        public bool Version { get; set; }
        /// <summary>
        /// Path of the markdown file to convert
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// Path to phantom binary
        /// </summary>
        public string PhantomPath { get; set; }
        /// <summary>
        /// Path to runnings (header, footer)
        /// </summary>
        public string RunningsPath { get; set; }
        /// <summary>
        /// Path to custom CSS file
        /// </summary>
        public string CssPath { get; set; }
        /// <summary>
        /// Path to custom highlight-CSS file
        /// </summary>
        public string HighlightCssPath { get; set; }
        /// <summary>
        /// Options to pass to Remarkable
        /// </summary>
        public string RemarkableOptions { get; set; }
        /// <summary>
        /// 'A3', 'A4', 'A5', 'Legal', 'Letter' or 'Tabloid'
        /// </summary>
        public MarkdownPdfPaperFormat PaperFormat { get; set; }
        /// <summary>
        /// 'portrait' or 'landscape'
        /// </summary>
        public MarkdownPdfOrientation Orientation { get; set; }
        /// <summary>
        /// Supported dimension units are: 'mm', 'cm', 'in', 'px'
        /// </summary>
        public string PaperBorder { get; set; }
        /// <summary>
        /// Delay before rendering the PDF
        /// </summary>
        public int RenderDelay { get; set; }
        /// <summary>
        /// Timeout before the page is rendered in case `page.onLoadFinished` isn't fired
        /// </summary>
        public int LoadTimeout { get; set; }
        /// <summary>
        /// Path of where to save the PDF
        /// </summary>
        public string OutFilePath { get; set; }
    }
}