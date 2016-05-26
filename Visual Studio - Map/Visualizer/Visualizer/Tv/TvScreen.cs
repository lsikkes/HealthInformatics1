// <copyright file="TVScreen.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Tv
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Visualizer.Utilities;

    /// <summary>
    /// Class TVScreen.
    /// </summary>
    /// <seealso cref="Visualizer.ImmovableObject" />
    public class TVScreen : ImmovableObject
    {
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TVScreen"/> class.
        /// </summary>
        /// <param name="x"> x position</param>
        /// <param name="y"> y position</param>
        /// <param name="rotation"> rotation of object</param>
        /// <param name="id"> id of object</param>
        /// <param name="name">name of object</param>
        public TVScreen(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the text on the screen.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is on.
        /// </summary>
        /// <value><c>true</c> if this instance is on; otherwise, <c>false</c>.</value>
        public bool IsOn { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [show text].
        /// </summary>
        /// <value><c>true</c> if [show text]; otherwise, <c>false</c>.</value>
        public bool ShowText { get; private set; }

        /// <summary>
        /// Gets the movie title on screen.
        /// </summary>
        /// <value>The movie title.</value>
        public string Movie { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Sets the text on TV.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText(string text)
        {
            this.Text = text;

            //this.logger.Info(this, "Text is set to " + text);
        }

        /// <summary>
        /// Sets the TV on or off depending on the given boolean.
        /// </summary>
        /// <param name="state">if set to <c>true</c> TV is on, else false.</param>
        public void SetTvOn(bool state)
        {
            this.IsOn = state;

            //this.logger.Info(this, "IsOn is set to " + state);
        }

        /// <summary>
        /// Sets the movie.
        /// </summary>
        /// <param name="movie">The movie.</param>
        public void SetMovie(string movie)
        {
            this.Movie = movie;

            //this.logger.Info(this, "Movie is set to " + movie);
        }

        /// <summary>
        /// Sets if the text is shown. <c>true</c> if text is shown, <c>false</c> if movie is shown.
        /// </summary>
        /// <param name="state">if set to <c>true</c> for text, <c>false</c> for movie.</param>
        public void SetShowText(bool state)
        {
            this.ShowText = state;

            //this.logger.Info(this, "ShowText is set to " + state);
        }

        /// <summary>
        /// Gets the image resource.
        /// </summary>
        /// <returns>string of TVScreen</returns>
        public string GetImageResource()
        {
            return ImageEnum.TvIcon.ToString();
        }

        #endregion Methods
    }
}