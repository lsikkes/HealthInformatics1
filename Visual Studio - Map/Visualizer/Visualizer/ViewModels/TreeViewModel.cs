namespace Visualizer.ViewModels
{
    using System.Windows.Media;
    using Visualizer.Models;
    using Visualizer.Utilities;

    public class TreeViewModel : AbstractViewModel
    {
        #region Fields

        private TreeModel treeModel;
        private int width;
        private int height;
        private ImageBrush image;

        #endregion Fields

        #region Constructors

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

        public ImageBrush SurroundingImage
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