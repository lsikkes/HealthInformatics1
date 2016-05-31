// <copyright file="TreeViewModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>PoliceCarViewModel class</summary>
// ***********************************************************************
namespace Visualizer.ViewModels
{
    using System.Windows.Media;
    using Visualizer.Models;
    using Visualizer.Utilities;

    /// <summary>
    /// The tree View-model
    /// </summary>
    /// <seealso cref="Visualizer.ViewModels.AbstractViewModel" />
    public class TreeViewModel : AbstractViewModel
    {
        #region Fields

        /// <summary>
        /// The tree model
        /// </summary>
        private TreeModel treeModel;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeViewModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public TreeViewModel(VRPosition pos, int id)
            : base(pos)
        {
            this.treeModel = new TreeModel(pos, id);
            this.Model = this.treeModel;
            this.Height = this.treeModel.Height;
            this.Width = this.treeModel.Width;
            this.SurroundingImage = this.treeModel.SurroundingImage;
            this.SetPosition(pos);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height
        {
            get
            {
                return this.treeModel.Height;
            }

            protected set
            {
                if (this.Height != value)
                {
                    this.treeModel.Height = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width
        {
            get
            {
                return this.treeModel.Width;
            }

            protected set
            {
                if (this.Width != value)
                {
                    this.treeModel.Width = value;
                    this.RaisePropertyChanged("Width");
                }
            }
        }

        /// <summary>
        /// Gets or sets the surrounding image.
        /// </summary>
        /// <value>
        /// The surrounding image.
        /// </value>
        public ImageBrush SurroundingImage
        {
            get
            {
                return this.treeModel.SurroundingImage;
            }

            protected set
            {
                if (this.SurroundingImage != value)
                {
                    this.treeModel.SurroundingImage = value;
                    this.RaisePropertyChanged("SurroundingImage");
                }
            }
        }

        #endregion Properties
    }
}