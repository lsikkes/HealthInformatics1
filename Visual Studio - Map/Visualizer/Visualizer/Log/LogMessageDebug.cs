// <copyright file="LogMessageInfo.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>Contains the strings for the logger</summary>
// ***********************************************************************
namespace Visualizer.Log
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for error messages
    /// </summary>
    /// <seealso cref="Visualizer.Log.LogMessage" />
    public class LogMessageDebug : LogMessage
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessageDebug"/> class.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="text">The text.</param>
        public LogMessageDebug(string text) : base(text)
        {
            this.Type = LoggerEnum.DebugString.ToString();
            this.Color = LoggerEnum.DebugColor.ToString();
        }

        #endregion
    }
}
