namespace Visualizer.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Media;
    using Visualizer.Models;
    using Visualizer.Utilities;

    /// <summary>
    /// Building View-model
    /// </summary>
    /// <seealso cref="Visualizer.ViewModels.AbstractViewModel" />
    public class BuildingViewModel : AbstractViewModel
    {
        #region Fields

        /// <summary>
        /// The building model
        /// </summary>
        private BuildingModel buildingModel;

        /// <summary>
        /// The image
        /// </summary>
        private ImageBrush image;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingViewModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public BuildingViewModel(VRPosition pos, int id)
            : base(pos)
        {
            this.buildingModel = new BuildingModel(pos, id);
            this.Model = this.buildingModel;
            this.Height = this.buildingModel.Height;
            this.Width = this.buildingModel.Width;
            this.image = this.buildingModel.SurroundingImage;

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
                return this.buildingModel.Height;
            }

            protected set
            {
                if (this.Height != value)
                {
                    this.buildingModel.Height = value;
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
                return this.buildingModel.Width;
            }

            protected set
            {
                if (this.Width != value)
                {
                    this.buildingModel.Width = value;
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
                return this.buildingModel.SurroundingImage;
            }

            protected set
            {
                if (this.SurroundingImage != value)
                {
                    this.buildingModel.SurroundingImage = value;
                    this.RaisePropertyChanged("SurroundingImage");
                }
            }
        }

        #endregion Properties
    }
}