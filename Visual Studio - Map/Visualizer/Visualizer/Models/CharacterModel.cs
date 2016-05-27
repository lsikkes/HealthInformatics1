// <copyright file="CharacterModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer.Models
{
    using Visualizer.Utilities;
    using Visualizer.Utilities.Character;

    /// <summary>
    /// Class CharacterModel.
    /// </summary>
    /// <seealso cref="Visualizer.Models.AbstractVRObject" />
    public class CharacterModel : AbstractVRObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="emotion">The emotion.</param>
        /// <param name="action">The action.</param>
        public CharacterModel(VRPosition pos, int id, int emotion, int action)
            : base(pos, id)
        {
            this.SetEmotion(emotion);
            this.SetAction(action);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the emotion.
        /// </summary>
        /// <value>The emotion.</value>
        public CharacterEmotion Emotion { get; private set; }

        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        public CharacterAction Action { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Emotion updated to a new emotion.
        /// If the new emotion isn't valid the previous emotion is hold.
        /// </summary>
        /// <param name="newEmotion"> The new emotion </param>
        public void SetEmotion(int newEmotion)
        {
            CharacterEmotion newEmotionEnum = (CharacterEmotion)newEmotion;
            if (this.IsValidEnum(newEmotionEnum))
            {
                this.Emotion = newEmotionEnum;
                this.Logger.Info(this, "emotion set to " + newEmotionEnum);
            }
            else
            {
                this.Logger.Warning(this, "unknown emotion tried to set " + newEmotion);
                if (this.Emotion == 0)
                {
                    this.Emotion = CharacterEmotion.Neutral;
                    this.Logger.Warning(this, "emotion set to " + CharacterEmotion.Neutral);
                }
            }
        }

        /// <summary>
        /// Action updated to a new action.
        /// </summary>
        /// <param name="newAction">The new action.</param>
        public void SetAction(int newAction)
        {
            CharacterAction newActionEnum = (CharacterAction)newAction;
            if (this.IsValidEnum(newActionEnum))
            {
                this.Action = newActionEnum;
                this.Logger.Info(this, "action set to " + newActionEnum);
            }
            else
            {
                this.Logger.Warning(this, "unknown action tried to set " + newAction);
                if (this.Action == 0)
                {
                    this.Action = CharacterAction.Nothing;
                    this.Logger.Warning(this, "action set to " + CharacterAction.Nothing);
                }
            }
        }

        /// <summary>
        /// Determines whether the specified enumeration is valid.
        /// </summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns> true if the enumeration is in range else false </returns>
        private bool IsValidEnum(System.Enum enumeration)
        {
            int temp;
            return !int.TryParse(enumeration.ToString(), out temp);
        }

        #endregion Methods
    }
}