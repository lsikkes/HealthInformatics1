// <copyright file="Logger.cs" company="HI1 aka Geen naam">
//     Copyright (c) HI1 aka Geen naam. All rights reserved.
// </copyright>
namespace Visualizer
{
    using System;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// The logger class is a singleton that manages logging.
    /// It creates two log files.
    /// A current file, this is for easy debugging in short amount of time.
    /// one backup file, this is for retrieving old data.
    /// The files are HTML files which we can use with CSS.
    /// </summary>
    public class Logger
    {
        #region Fields

        /// <summary>
        /// Colors used for marking the log levels
        /// </summary>
        private static readonly string Black = "black", Red = "red", Orange = "orange", Green = "green";

        /// <summary>
        /// Log levels
        /// </summary>
        private static readonly string DebugS = "DEBUG", InfoS = "INFO", ErrorS = "ERROR", WarningS = "WARNING";

        /// <summary>
        /// Amount of log files stored
        /// </summary>
        private static readonly int LogFiles = 101;

        /// <summary>
        /// The relative path to store the log files
        /// </summary>
        private static readonly string Path = Directory.GetParent(@"..\..\..\..\").ToString() + @"\logger\";

        /// <summary>
        /// Singleton instance
        /// </summary>
        private static Logger Instance = new Logger();

        /// <summary>
        /// Writers to use
        /// </summary>
        private StreamWriter writerStore, writerCurrent;

        /// <summary>
        /// booleans to keep track where to log to
        /// </summary>
        private bool logAll = true, logBackup = true, toConsole = false;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        private Logger()
        {
            this.CreateFiles();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the instance of the Singleton
        /// </summary>
        /// <returns>
        /// Singleton instance
        /// </returns>
        public static Logger GetInstance()
        {
            return Instance;
        }

        /// <summary>
        /// Logs all the information messages
        /// Should be used for information purpose only
        /// </summary>
        /// <param name="message"> the message to log </param>
        public void Info(string message)
        {
            this.WriteLine(Black, InfoS, message);
        }

        /// <summary>
        /// Logs all the debug messages
        /// Should be used for debug purpose only
        /// </summary>
        /// <param name="message"> the message to log</param>
        public void Debug(string message)
        {
            this.WriteLine(Green, DebugS, message);
        }

        /// <summary>
        /// Logs all the error messages
        /// Should be used for error purpose only
        /// </summary>
        /// <param name="message"> the message to log</param>
        public void Error(string message)
        {
            this.WriteLine(Red, ErrorS, message);
        }

        /// <summary>
        /// Logs all the warning messages
        /// Should be used for warning purpose only
        /// </summary>
        /// <param name="message"> the message to log</param>
        public void Warning(string message)
        {
            this.WriteLine(Orange, WarningS, message);
        }

        public void setLogAll(bool state)
        {
            this.logAll = state;
        }

        public void setLogBackup(bool state)
        {
            this.logBackup = state;
        }

        public void setToConsole(bool state)
        {
            this.toConsole = state;
        }

        public bool getLogAll()
        {
            return this.logAll;
        }

        public bool getLogBackup()
        {
            return this.logBackup;
        }

        public bool getToConsole()
        {
            return this.toConsole;
        }

        /// <summary>
        /// Writes the line to both writes and console
        /// If those are active
        /// </summary>
        /// <param name="color">The color of the line</param>
        /// <param name="level">The level of the line</param>
        /// <param name="message">the message of the line</param>
        private void WriteLine(string color, string level, string message)
        {
            if (this.logAll)
            {
                string line = this.GetTime() + "<span style='color:" + color + ";'><b> " + level + "</b></span> " + message + "<br/>";
                this.WriteLine(this.writerCurrent, line);
                if (this.logBackup)
                {
                    this.WriteLine(this.writerStore, line);
                }

                if (this.toConsole)
                {
                    Console.WriteLine(this.GetTime() + " " + level + " " + message);
                }
            }
        }

        /// <summary>
        /// Writes the line with the given writer
        /// </summary>
        /// <param name="writer"> writer to be used</param>
        /// <param name="message"> message to be written</param>
        private void WriteLine(StreamWriter writer, string message)
        {
            writer.WriteLine(message);
            writer.Flush();
        }

        /// <summary>
        /// Creates the writers and files.
        /// One current file and one file with the date.
        /// When there are more than logFiles (101) files the oldest files are deleted.
        /// </summary>
        private void CreateFiles()
        {
            Console.WriteLine("path is " + Path);

            //Logger.GetInstance().Info("path is " + Path);
            if (this.logAll)
            {
                Directory.CreateDirectory(Path);
                string time = DateTime.Now.ToString("MM-dd-yy HH_mm_ss");
                this.writerCurrent = new StreamWriter(Path + @"\current.html");
                this.WriteStart(this.writerCurrent);
                if (this.logBackup)
                {
                    this.writerStore = new StreamWriter(Path + @"\" + time + ".html");
                    this.WriteStart(this.writerStore);
                }

                foreach (var file in new DirectoryInfo(Path).GetFiles().OrderByDescending(x => x.LastWriteTime).Skip(LogFiles))
                {
                    file.Delete();
                }
            }
        }

        /// <summary>
        /// Writes the header of the log file with the defined writer.
        /// </summary>
        /// <param name="writer"> writer to be used </param>
        private void WriteStart(StreamWriter writer)
        {
            writer.WriteLine("Log file of the run on " + this.GetTime() + "</br>");
            writer.WriteLine("<span style='color:red;'><b>red</b></span> text stands for ERROR</br>");
            writer.WriteLine("<span style='color:orange;'><b>orange</b></span> text stands for WARNING</br>");
            writer.WriteLine("<span style='color:green;'><b>green</b></span> text stands for DEBUG</br>");
            writer.WriteLine("<span style='color:black;'><b>black</b></span> text stands for INFO</br>");
            writer.Flush();
        }

        /// <summary>
        /// Get the current time in the preferred format
        /// </summary>
        /// <returns> String with the current time</returns>
        private string GetTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        #endregion Methods
    }
}