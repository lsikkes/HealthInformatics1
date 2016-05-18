// <copyright file="ImageEnum.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer
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
            CharacterEmoji0 = new ImageEnum("character_emoji_0.png"),
            CharacterEmoji1 = new ImageEnum("character_emoji_1.png"),
            ChairIcon = new ImageEnum("icon_chair.png"),
            LightIconOn = new ImageEnum("icon_light_on.png"),
            LightIconOff = new ImageEnum("icon_light_off.png"),
            PoliceIcon = new ImageEnum("icon_police.png"),
            TvIcon = new ImageEnum("icon_tv.png"),
            PlayerImage = new ImageEnum("image_player.png"),
            PlayerScope = new ImageEnum("image_player_scope.png"),
            Logo = new ImageEnum("logo.png"),
            CharacterImage0 = new ImageEnum("image_character_0.png"),
            CharacterImage1 = new ImageEnum("image_character_1.png");

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

        #endregion Constructors
    }
}