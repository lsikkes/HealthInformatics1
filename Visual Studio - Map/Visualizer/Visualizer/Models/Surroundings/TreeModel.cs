// <copyright file="TreeModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>PoliceCarViewModel class</summary>
// ***********************************************************************

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
    /// The Tree Model.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractSurroundingModel" />
    public class TreeModel : AbstractSurroundingModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public TreeModel(VRPosition pos, int id)
            : base(pos, id)
        {
            ImageSource source = ImageMap.GetImage(ImageEnum.TreeIcon.ToString());
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = source;
            this.SurroundingImage = brush;
            this.Height = 100;
            this.Width = 100;
        }

        #endregion Constructors
    }
}