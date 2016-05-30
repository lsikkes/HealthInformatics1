namespace Visualizer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Media;
    using Visualizer.Utilities;

    /// <summary>
    /// The model for a building.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractSurroundingModel" />
    public class BuildingModel : AbstractSurroundingModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public BuildingModel(VRPosition pos, int id)
            : base(pos, id)
        {
            ImageSource source = ImageMap.GetImage(ImageEnum.WallImage.ToString());
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = source;
            this.SurroundingImage = brush;
            this.Height = 100;
            this.Width = 100;
        }

        #endregion Constructors
    }
}