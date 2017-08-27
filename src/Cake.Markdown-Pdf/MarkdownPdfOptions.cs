namespace Cake.Markdown_Pdf
{
    /// <summary>
    /// Markdown-pdf command line switches
    /// </summary>
    public static class MarkdownPdfOptions
    {
        /// <summary>
        /// output usage information
        /// </summary>
        public static readonly string Help = "--help";
        /// <summary>
        /// output the version number
        /// </summary>
        public static readonly string Version = "--version";
        /// <summary>
        /// Path to phantom binary
        /// </summary>
        public static readonly string PhantomPath = "--phantom-path";
        /// <summary>
        /// Path to runnings (header, footer)
        /// </summary>
        public static readonly string RunningsPath = "--runnings-path";
        /// <summary>
        /// Path to custom CSS file
        /// </summary>
        public static readonly string CssPath = "--css-path";
        /// <summary>
        /// Path to custom highlight-CSS file
        /// </summary>
        public static readonly string HighlightCssPath = "--highlight-css-path";
        /// <summary>
        /// Options to pass to Remarkable
        /// </summary>
        public static readonly string RemarkableOptions = "--remarkable-options";
        /// <summary>
        /// 'A3', 'A4', 'A5', 'Legal', 'Letter' or 'Tabloid'
        /// </summary>
        public static readonly string PaperFormat = "--paper-format";
        /// <summary>
        /// 'portrait' or 'landscape'
        /// </summary>
        public static readonly string Orientation = "--paper-orientation";
        /// <summary>
        /// Supported dimension units are: 'mm', 'cm', 'in', 'px'
        /// </summary>
        public static readonly string PaperBorder = "--paper-border";
        /// <summary>
        /// Delay before rendering the PDF
        /// </summary>
        public static readonly string RenderDelay = "--render-delay";
        /// <summary>
        /// Timeout before the page is rendered in case `page.onLoadFinished` isn't fired
        /// </summary>
        public static readonly string LoadTimeout = "--load-timeout";
        /// <summary>
        /// Path of where to save the PDF
        /// </summary>
        public static readonly string OutFilePath = "--out";
    }
}