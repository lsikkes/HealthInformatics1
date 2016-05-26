// <copyright file="ImageEnum.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Utilities
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Enumerator class with the image names
    /// </summary>
    public class ImageEnum
    {
        #region Fields

        /// <summary>
        /// List with all the available images used in the program.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "field should be public")]
        public static ImageEnum AmbulanceCar = new ImageEnum("image_police_car.png"),
            AmbulanceCarIcon = new ImageEnum("icon_police.png"),
            PoliceCar = new ImageEnum("image_police_car.png"),
            PoliceCarIcon = new ImageEnum("icon_police.png"),
            FireFighterCar = new ImageEnum("image_police_car.png"),
            FireFighterCarIcon = new ImageEnum("icon_police.png"),
            NormalCar = new ImageEnum("image_police_car.png"),
            NormalCarIcon = new ImageEnum("icon_police.png"),
            CharacterEmotion = new ImageEnum("character_emoji_"),
            ChairIcon = new ImageEnum("icon_chair.png"),
            LightIconOn = new ImageEnum("icon_light_on.png"),
            LightIconOff = new ImageEnum("icon_light_off.png"),
            PoliceIcon = new ImageEnum("icon_police.png"),
            TvIcon = new ImageEnum("icon_tv.png"),
            PatientImage = new ImageEnum("image_player.png"),
            PatientScope = new ImageEnum("image_player_scope.png"),
            Logo = new ImageEnum("logo.png"),
            CharacterImage = new ImageEnum("image_character_");

        /// <summary>
        /// The name of the class
        /// </summary>
        private readonly string name;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEnum"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ImageEnum(string name)
        {
            this.name = name;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the character.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>string of character image</returns>
        public static string GetCharacter(int id)
        {
            return ImageEnum.CharacterImage.ToString() + id + ".png";
        }

        /// <summary>
        /// Gets the character emotion.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>string of character emotion image.</returns>
        public static string GetCharacterEmotion(int id)
        {
            return ImageEnum.CharacterEmotion.ToString() + id + ".png";
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.name;
        }

        #endregion Methods
    }
}