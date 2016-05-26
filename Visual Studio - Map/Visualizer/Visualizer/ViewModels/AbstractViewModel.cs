// <copyright file="AbstractViewModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>AbstractViewModel class</summary>
// ***********************************************************************
namespace Visualizer.ViewModels
{
    using MVVM;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using Visualizer.Models;
    using Visualizer.Utilities;

    /// <summary>
    /// Class AbstractViewModel.
    /// </summary>
    /// <seealso cref="Visualizer.MVVM.ObservableObject" />
    public abstract class AbstractViewModel : ObservableObject
    {
        #region Fields

        /// <summary>
        /// The margin
        /// </summary>
        private Thickness margin;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractViewModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        public AbstractViewModel(VRPosition pos)
        {
            this.Logger = Logger.GetInstance();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        /// <value>The margin.</value>
        public Thickness Margin
        {
            get
            {
                return this.margin;
            }

            set
            {
                if (value != this.margin)
                {
                    this.margin = value;
                    this.RaisePropertyChanged("Margin");
                }
            }
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>The logger.</value>
        protected Logger Logger { get; private set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        protected AbstractVRObject Model { private get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Sets the initial position.
        /// </summary>
        /// <param name="pos">The position.</param>
        public void SetPosition(VRPosition pos)
        {
            this.Model.Position.Move(pos.X, pos.Y);
            Thickness margin = this.Margin;
            margin.Left = this.Model.Position.X;
            margin.Top = this.Model.Position.Y;
            this.Margin = margin;
        }

        #endregion Methods
    }
}