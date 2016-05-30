using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Visualizer.Models;
using Visualizer.Utilities;

namespace Visualizer.ViewModels
{
    public class BuildingViewModel : AbstractViewModel
    {
        #region Fields

        private BuildingModel buildingModel;
        private int width;
        private int height;
        private ImageBrush image;

        #endregion Fields

        #region Constructors

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

        public ImageBrush SurroundingImageImage
        {
            get
            {
                return this.image;
            }

            protected set
            {
                if (this.image != value)
                {
                    this.image = value;
                    this.RaisePropertyChanged("SurroundingImage");
                }
            }
        }

        #endregion Properties
    }
}