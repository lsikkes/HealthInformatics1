// <copyright file="LoggerViewModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Log
{
    using System;
    using System.Collections.ObjectModel;

    /// <summary>
    /// The ViewModel connected to the logger panel
    /// </summary>
    public class LoggerViewModel
    {
        #region Fields

        /// <summary>
        /// The instance of the LoggerViewModel to make it a singleton
        /// </summary>
        private static LoggerViewModel instance;

        /// <summary>
        /// All the logs in the program
        /// </summary>
        private Collection<LogMessage> logs;

        /// <summary>
        /// All the logs to show at the moment
        /// </summary>
        private ObservableCollection<LogMessage> show;

        /// <summary>
        /// The type of logs to show
        /// </summary>
        private string type;

        /// <summary>
        /// The maximum amount of logs in the memory
        /// </summary>
        private int max = 100;

        #endregion Fields

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerViewModel"/> class.
        /// </summary>
        public LoggerViewModel()
        {
            this.logs = new Collection<LogMessage>();
            this.show = new ObservableCollection<LogMessage>();

            this.type = LoggerEnum.AllString.ToString();
            instance = this;
        }

        #endregion Construction

        #region Properties

        /// <summary>
        /// Gets or sets the logs.
        /// </summary>
        /// <value>
        /// The logs.
        /// </value>
        public ObservableCollection<LogMessage> Show
        {
            get { return this.show; }
            set { this.show = value; }
        }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns this instance.
        /// </summary>
        /// <returns>this instance.</returns>
        public static LoggerViewModel Instance()
        {
            if (instance == null)
            {
                instance = new LoggerViewModel();
            }

            return instance;
        }

        /// <summary>
        /// Sets the active type.
        /// </summary>
        /// <param name="type">The type.</param>
        public void SetActive(string type)
        {
            if (this.type != type)
            {
                this.type = type;
                this.ResetShow();
                Logger.GetInstance().Debug("set logger type to: '" + this.type + "' | " + this.logs.Count + " : " + this.show.Count);
            }
        }

        /// <summary>
        /// Adds the a new log to the list.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="type">The type.</param>
        /// <param name="text">The text.</param>
        public void Add(LogMessage log)
        {
            this.logs.Add(log);
            if (this.type.Equals(LoggerEnum.AllString.ToString()) || log.Type.Equals(this.type))
            {
                this.show.Add(log);
            }
        }

        /// <summary>
        /// Resets the logs in the memory.
        /// </summary>
        public void Reset()
        {
            while (this.logs.Count > 0)
            {
                this.logs.RemoveAt(0);
            }

            this.ResetShow();
        }

        /// <summary>
        /// Resets the list of logs to show.
        /// </summary>
        private void ResetShow()
        {
            string s = "reseting temp for type: " + this.type + "from " + this.show.Count;

            ObservableCollection<LogMessage> temp = new ObservableCollection<LogMessage>();
            foreach (LogMessage log in this.show)
            {
                if (!log.Type.Equals(this.type) && this.show.Contains(log))
                {
                    temp.Add(log);
                }
            }

            foreach (LogMessage log in temp)
            {
                this.show.Remove(log);
            }

            foreach (LogMessage log in this.logs)
            {
                if ((log.Type.Equals(this.type) || this.type.Equals(LoggerEnum.AllString.ToString())) && !this.show.Contains(log))
                {
                    this.show.Add(log);
                }
            }

            Console.WriteLine(s + " " + this.type + " --> " + this.show.Count);
        }
        #endregion Methods
    }
}