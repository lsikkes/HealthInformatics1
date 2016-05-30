// <copyright file="LogMessage.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Log
{
    using MVVM;

    /// <summary>
    /// A class which contains a single line of log information.
    /// </summary>
    /// <seealso cref="MVVM.ObservableObject" />
    internal class LogMessage : ObservableObject
    {
        #region Fields

        /// <summary>
        /// The type
        /// </summary>
        private string type;

        /// <summary>
        /// The time
        /// </summary>
        private string time;

        /// <summary>
        /// The text
        /// </summary>
        private string text;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessage"/> class.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="type">The type.</param>
        /// <param name="text">The text.</param>
        public LogMessage(string time, string type, string text)
        {
            this.type = type;
            this.time = time;
            this.text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessage"/> class.
        /// </summary>
        public LogMessage()
        {
            this.type = string.Empty;
            this.time = string.Empty;
            this.text = string.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        public string Time
        {
            get
            {
                return this.time;
            }

            set
            {
                if (this.time != value)
                {
                    this.time = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public string Color
        {
            get
            {
                if (this.type.Equals(Logger.DebugS))
                {
                    return "Green";
                }
                else if (this.type.Equals(Logger.ErrorS))
                {
                    return "Red";
                }
                else if (this.type.Equals(Logger.WarningS))
                {
                    return "Orange";
                }
                else
                {
                    return "Black";
                }
            }

            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (this.type != value)
                {
                    this.type = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                if (this.text != value)
                {
                    this.text = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        #endregion
    }
}