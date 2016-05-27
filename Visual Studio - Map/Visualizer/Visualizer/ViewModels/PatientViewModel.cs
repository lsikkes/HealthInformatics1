// <copyright file="PatientViewModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>PatientViewModel class</summary>
// ***********************************************************************
namespace Visualizer.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using Visualizer.Models;
    using MVVM;
    using Visualizer.Utilities;

    [Obsolete]

    /// <summary>
    /// Class PatientViewModel.
    /// </summary>
    /// <seealso cref="Visualizer.MVVM.ObservableObject" />
    public class PatientViewModel : ObservableObject
    {
        #region Fields

        /// <summary>
        /// The margin
        /// </summary>
        private Thickness margin;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientViewModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public PatientViewModel(VRPosition pos, int id)
        {
            this.Model = new PatientModel(pos, id);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        public PatientModel Model { get; set; }

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

        #endregion Properties

        #region Methods

        /// <summary>
        /// Moves the object to the given x and y.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void MoveObject(int x, int y)
        {
            this.Model.Position.Move(x, y);
            Thickness margin = this.Margin;
            margin.Left = this.Model.Position.X;
            margin.Top = this.Model.Position.Y;
            this.Margin = margin;
        }

        #endregion Methods
    }
}