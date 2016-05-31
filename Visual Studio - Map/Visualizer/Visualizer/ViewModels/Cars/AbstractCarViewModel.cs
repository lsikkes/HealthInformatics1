// <copyright file="AbstractCarViewModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>AbstractCarViewModel class</summary>
// ***********************************************************************

namespace Visualizer.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using Visualizer.Models;
    using Visualizer.Models.Cars;
    using Visualizer.Utilities;

    /// <summary>
    /// EmergencyCarViewModel Class
    /// </summary>
    /// <seealso cref="Visualizer.ViewModels.AbstractViewModel" />
    public abstract class AbstractCarViewModel : AbstractViewModel
    {
        #region Fields

        /// <summary>
        /// The Image brushes for the image.
        /// </summary>
        private ImageBrush carImage;

        /// <summary>
        /// The Image brushes for the image.
        /// </summary>
        private ImageBrush carIconImage;

        /// <summary>
        /// The width and height of the image.
        /// </summary>
        private int width;

        /// <summary>
        /// The width and height of the image.
        /// </summary>
        private int height;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCarViewModel" /> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public AbstractCarViewModel(VRPosition pos, int id)
           : base(pos)
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the height of the image.
        /// </summary>
        /// <value>The icon brush.</value>
        public int Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (this.height != value)
                {
                    this.height = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }

        /// <summary>
        /// Gets or sets the width of the image.
        /// </summary>
        /// <value>The icon brush.</value>
        public int Width
        {
            get
            {
                return this.width;
            }

            protected set
            {
                if (this.width != value)
                {
                    this.width = value;
                    this.RaisePropertyChanged("Width");
                }
            }
        }

        /// <summary>
        /// Gets or sets the car image brush.
        /// </summary>
        /// <value>The icon brush.</value>
        public ImageBrush CarImage
        {
            get
            {
                return this.carImage;
            }

            protected set
            {
                if (this.carImage != value)
                {
                    this.carImage = value;
                    this.RaisePropertyChanged("CarImage");
                }
            }
        }

        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        /// <value>The margin.</value>
        public ImageBrush CarIconImage
        {
            get
            {
                return this.carIconImage;
            }

            protected set
            {
                if (this.carIconImage != value)
                {
                    this.carIconImage = value;
                    this.RaisePropertyChanged("CarIconImage");
                }
            }
        }

        /// <summary>
        /// Gets or sets the character model
        /// </summary>
        protected AbstractCarModel CarModel { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        protected void GetCarImage()
        {
            ImageSource source = this.CarModel.Image;
            ImageBrush brush = this.CarImage;
            brush.ImageSource = source;
            this.CarImage = brush;
        }

        /// <summary>
        /// Gets or sets the car icon image.
        /// </summary>
        protected void GetCarIconImage()
        {
            ImageSource source = this.CarModel.IconImage;
            ImageBrush brush = this.CarIconImage;
            brush.ImageSource = source;
            this.CarIconImage = brush;
        }

        /// <summary>
        /// Changes the siren.
        /// </summary>
        /// <param name="status">Changes siren to be on or off.</param>
        public virtual bool changeSiren(bool status)
        {
            this.CarModel.SirenOn = status;
            return this.CarModel.SirenOn;
        }

        #endregion Methods
    }
}
