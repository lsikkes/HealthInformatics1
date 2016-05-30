// <copyright file="SurroundingModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>SurroundingModel class</summary>
// ***********************************************************************
namespace Visualizer.Models
{
    using System.Windows.Media;
    using Utilities;

    /// <summary>
    /// Class SurroundingModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractVRObject" />
    public abstract class AbstractSurroundingModel : AbstractVRObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSurroundingModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public AbstractSurroundingModel(VRPosition pos, int id)
            : base(pos, id)
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the width
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public ImageBrush SurroundingImage { get; set; }

        #endregion Properties
    }
}