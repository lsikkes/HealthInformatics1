// <copyright file="Character.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Character
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class Character.
    /// </summary>
    /// <seealso cref="Visualizer.MovableObject" />
    /// <seealso cref="Visualizer.VRObject" />
    public class Character : MovableObject
    {
        #region Fields

        /// <summary>
        /// The logger
        /// </summary>
        private Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor of Character
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        /// <param name="rotation">rotation of object</param>
        /// <param name="id">id of object</param>
        /// <param name="name">name of object</param>
        public Character(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
            this.CharEmotion = CharacterEmotion.Neutral;
        }

        #region Properties

        /// <summary>
        /// Gets the character action.
        /// </summary>
        /// <value>The character action.</value>
        public CharacterAction CharAction { get; private set; }

        /// <summary>
        /// Gets the character emotion.
        /// </summary>
        /// <value>The character emotion.</value>
        public CharacterEmotion CharEmotion { get; private set; }

        #endregion Properties

        /// <summary>
        /// Gets the image resource.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>string resource of image</returns>
        public string GetImageResource(int id)
        {
            return ImageEnum.GetCharacter(id);
        }

        /// <summary>
        /// Gets the image emotion resource.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>string resource of emotion</returns>
        public string GetImageEmojiResource(int id)
        {
            return ImageEnum.GetCharacterEmoji(id);
        }

        /// <summary>
        /// Emotion updated to a new emotion.
        /// If the new emotion isn't valid the previous emotion is hold.
        /// </summary>
        /// <param name="newEmotion"> The new emotion </param>
        public void EmotionUpdatedTo(int newEmotion)
        {
            if (this.IsValid((CharacterEmotion)newEmotion))
            {
                this.CharEmotion = (CharacterEmotion)newEmotion;
                this.logger.Info("Object " + this.name + " id " + this.id + " emotion updated to " + this.CharEmotion.ToString());
            }
            else
            {
                this.logger.Warning("Object " + this.name + " id " + this.id + " emotion could not update to " + (CharacterEmotion)newEmotion);
            }
        }

        /// <summary>
        /// Action updated to a new action.
        /// </summary>
        /// <param name="newAction">The new action.</param>
        public void ActionUpdatedTo(int newAction)
        {
            if (this.IsValid((CharacterEmotion)newAction))
            {
                this.CharEmotion = (CharacterEmotion)newAction;
                this.logger.Info("Object " + this.name + " id " + this.id + " action updated to " + this.CharEmotion.ToString());
            }
            else
            {
                this.logger.Warning("Object " + this.name + " id " + this.id + " action could not update to " + (CharacterEmotion)newAction);
            }
        }

        /// <summary>
        /// Determines whether the specified emotion is valid.
        /// </summary>
        /// <param name="emotion">The emotion.</param>
        /// <returns> true if the emotion is in range else false </returns>
        private bool IsValid(System.Enum emotion)
        {
            int temp;
            return !int.TryParse(emotion.ToString(), out temp);
        }

        #endregion Constructors
    }
}