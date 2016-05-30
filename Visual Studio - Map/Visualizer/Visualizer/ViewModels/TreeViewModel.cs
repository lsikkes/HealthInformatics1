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
        /// Gets or sets the width of the image.
        /// </summary>
        /// <value>The icon brush.</value>
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