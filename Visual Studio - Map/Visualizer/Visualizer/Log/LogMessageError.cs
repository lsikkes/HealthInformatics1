﻿// <copyright file="LogMessageError.cs" company="HI1">
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
    public class LogMessageError : LogMessage
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessageError"/> class.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="text">The text.</param>
        public LogMessageError(string text) : base(text)
        {
            this.Type = LoggerEnum.ErrorString.ToString();
            this.Color = LoggerEnum.ErrorColor.ToString();
        }

        #endregion
    }
}
