using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Visualizer
{
    /// <summary>
    /// The logger class is a singleton that manages logging.
    /// It creates two log files.
    /// A current file, this is for easy debugging in short amount of time.
    /// one backup file, this is for retrieving old data.
    /// The files are html files which we can use with css.
    /// </summary>
    class Logger
    {
        private static readonly String black = "black", red = "red", orange = "orange", green = "green";
        private static readonly String debugS = "DEBUG", infoS = "INFO", errorS = "ERROR", warningS = "WARNING";
        private static readonly int logFiles = 101;

        private static readonly String path = Directory.GetParent(@"..\..\..\..\").ToString() + @"\logger\";
        private static readonly Logger instance = new Logger();
        private StreamWriter writerStore, writerCurrent;
        private Boolean logAll = true, logBackup = true, toConsole = false;

        /// <summary>
        /// Constructor of the Logger class.
        /// It creates two log files where the log messages are stored.
        /// </summary>
        public Logger()
        {
            createFiles();
        }

        /// <summary>
        /// Gets the instance of the Singleton
        /// </summary>
        /// <returns> Singleton instance </returns>
        public static Logger getInstance()
        {
            return instance;
        }

        /// <summary>
        /// Logs all the information messages
        /// Should be used for information purpose only
        /// </summary>
        /// <param name="message"> the message to log </param>
        public void info(String message)
        {
            writeLine(black, infoS, message);
        }

        /// <summary>
        /// Logs all the debug messages
        /// Should be used for debug purpose only
        /// </summary>
        /// <param name="message"> the message to log</param>
        public void debug(String message)
        {
            writeLine(green, debugS, message);
        }

        /// <summary>
        /// Logs all the error messages
        /// Should be used for error purpose only
        /// </summary>
        /// <param name="message"> the message to log</param>
        public void error(String message)
        {
            writeLine(red, errorS, message);
        }

        /// <summary>
        /// Logs all the warning messages
        /// Should be used for warning purpose only
        /// </summary>
        /// <param name="message"> the message to log</param>
        public void warning(String message)
        {
            writeLine(orange, warningS, message);
        }

        /// <summary>
        /// Sets the toConsole bool to his other state
        /// </summary>
        public void consoleTrigger()
        {
            toConsole = !toConsole;
        }

        /// <summary>
        /// Sets the logAll bool to his other state
        /// </summary>
        public void logTrigger()
        {
            logAll = !logAll;
        }

        /// <summary>
        /// Sets the logBackup bool to his other state
        /// </summary>
        public void backupTrigger()
        {
            logBackup = !logBackup;
        }

        /// <summary>
        /// Writes the line to both writes and console
        /// If those are active
        /// </summary>
        /// <param name="color">The color of the line</param>
        /// <param name="level">The level of the line</param>
        /// <param name="message">the message of the line</param>
        private void writeLine(String color, String level, String message)
        {
            if (logAll)
            {
                String line = getTime() + "<span style='color:" + color + ";'><b> " + level + "</b></span> " + message + "<br/>";
                writeLine(writerCurrent, line);
                if (logBackup)
                {
                    writeLine(writerStore, line);
                }
                if (toConsole)
                {
                    Console.WriteLine(getTime() + " " + level + " " + message);
                }
            }
        }

        /// <summary>
        /// Writes the line with the given writer
        /// </summary>
        /// <param name="writer"> writer to be used</param>
        /// <param name="message"> message to be written</param>
        private void writeLine(StreamWriter writer, String message)
        {
            writer.WriteLine(message);
            writer.Flush();
        }

        /// <summary>
        /// Creates the writers and files.
        /// One current file and one file with the date.
        /// When there are more than logFiles (101) files the oldest files are deleted.
        /// </summary>
        private void createFiles()
        {
            if (logAll)
            {
                Directory.CreateDirectory(path);
                String time = DateTime.Now.ToString("MM-dd-yy HH_mm_ss");
                writerCurrent = new StreamWriter(path + @"\current.html");
                writeStart(writerCurrent);
                if (logBackup)
                {
                    writerStore = new StreamWriter(path + @"\" + time + ".html");
                    writeStart(writerStore);
                }
                foreach (var file in new DirectoryInfo(path).GetFiles().OrderByDescending(x => x.LastWriteTime).Skip(logFiles))
                {
                    file.Delete();
                }
                    
            }
        }

        /// <summary>
        /// Writes the header of the log file with the defined writer.
        /// </summary>
        /// <param name="writer"> writer to be used </param>
        private void writeStart(StreamWriter writer)
        {
            writer.WriteLine("Log file of the run on " + getTime() + "</br>");
            writer.WriteLine("<span style='color:red;'><b>red</b></span> text stands for ERROR</br>");
            writer.WriteLine("<span style='color:orange;'><b>orange</b></span> text stands for WARNING</br>");
            writer.WriteLine("<span style='color:green;'><b>green</b></span> text stands for DEBUG</br>");
            writer.WriteLine("<span style='color:black;'><b>black</b></span> text stands for INFO</br>");
            writer.Flush();
        }

        /// <summary>
        /// Get the current time in the preffered format
        /// </summary>
        /// <returns> String with the current time</returns>
        private String getTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
