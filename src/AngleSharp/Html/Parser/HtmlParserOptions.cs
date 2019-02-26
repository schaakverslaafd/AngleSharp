namespace AngleSharp.Html.Parser
{
    using AngleSharp.Dom;
    using AngleSharp.Text;
    using System;

    /// <summary>
    /// Contains a number of options for the HTML parser.
    /// </summary>
    public struct HtmlParserOptions
    {
        /// <summary>
        /// Gets or sets if the document is embedded.
        /// </summary>
        public Boolean IsEmbedded
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if frames should not be supported.
        /// Once set this will ignore frame elements and
        /// respect noframes elements.
        /// </summary>
        public Boolean IsNotSupportingFrames
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if scripting is allowed.
        /// </summary>
        public Boolean IsScripting
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if errors should be treated as exceptions.
        /// </summary>
        public Boolean IsStrictMode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if XML processing instructions should
        /// be parsed into DOM nodes.
        /// </summary>
        public Boolean IsSupportingProcessingInstructions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the callback once a new element was created.
        /// </summary>
        public Action<IElement, TextPosition> OnCreated
        {
            get;
            set;
        }
    }
}
