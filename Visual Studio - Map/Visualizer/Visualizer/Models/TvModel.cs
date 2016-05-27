// <copyright file="TvModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>TvModel class</summary>
// ***********************************************************************
namespace Visualizer.Models
{
    using Visualizer.Utilities;

    /// <summary>
    /// Class TVModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractVRObject" />
    public class TvModel : AbstractVRObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TvModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public TvModel(VRPosition pos, int id)
            : base(pos, id)
        {
            this.IsOn = false;
        }

        /// <summary>
        /// Gets or sets the text on screen.
        /// </summary>
        /// <value>The text on screen.</value>
        public string TextOnScreen { get; set; }

        /// <summary>
        /// Gets or sets the movie title.
        /// </summary>
        /// <value>The movie title.</value>
        public string MovieTitle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show text].
        /// </summary>
        /// <value><c>true</c> if [show text]; otherwise, <c>false</c>.</value>
        public bool ShowText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is on.
        /// </summary>
        /// <value><c>true</c> if this instance is on; otherwise, <c>false</c>.</value>
        public bool IsOn { get; set; }

        #endregion Constructors
    }
}