// <copyright file="LoggerEnum.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>Contains the strings for the logger</summary>
// ***********************************************************************
namespace Visualizer.Log
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Enumerator class with the image names
    /// </summary>
    public class LoggerEnum
    {
        #region Fields

        /// <summary>
        /// List with all the available strings used in the logger.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "field should be public")]
        public static readonly LoggerEnum
            ErrorString = new LoggerEnum("ERROR"),
            ErrorColor = new LoggerEnum("Red"),
            WarningString = new LoggerEnum("WARNING"),
            WarningColor = new LoggerEnum("Orange"),
            DebugString = new LoggerEnum("DEBUG"),
            DebugColor = new LoggerEnum("Green"),
            InfoString = new LoggerEnum("INFO"),
            InfoColor = new LoggerEnum("Black"),
            AllString = new LoggerEnum("All");

        /// <summary>
        /// The content of the string
        /// </summary>
        private readonly string content;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerEnum"/> class.
        /// </summary>
        /// <param name="content">The content.</param>
        public LoggerEnum(string content)
        {
            this.content = content;
        }

        #endregion

        #region Method
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.content;
        }
        
        #endregion
    }
}