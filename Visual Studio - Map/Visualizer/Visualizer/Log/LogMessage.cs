// <copyright file="LogMessage.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Log
{
    using MVVM;
    using System;

    /// <summary>
    /// A class which contains a single line of log information.
    /// </summary>
    /// <seealso cref="MVVM.ObservableObject" />
    public class LogMessage : ObservableObject
    {
        #region Fields

        /// <summary>
        /// The type
        /// </summary>
        protected string type;

        /// <summary>
        /// The color
        /// </summary>
        protected string color;

        /// <summary>
        /// The time
        /// </summary>
        protected string time;

        /// <summary>
        /// The text
        /// </summary>
        protected string text;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessage"/> class.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="type">The type.</param>
        /// <param name="text">The text.</param>
        public LogMessage(string text)
        {
            this.Time = DateTime.Now.ToString("HH:mm:ss");
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessage"/> class.
        /// </summary>
        public LogMessage()
        {
            this.Type = string.Empty;
            this.Time = string.Empty;
            this.Text = string.Empty;
            this.Color = string.Empty;
        }

        #endregion Constructors

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
            get { return this.color; }
            set { this.color = value; }
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

        #endregion Properties
    }
}