// <copyright file="CharacterViewModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>CharacterViewModel class</summary>
// ***********************************************************************
﻿namespace Visualizer.ViewModels
 {
     using System.Windows.Media;
     using Visualizer.Models;
     using Visualizer.Utilities;

     /// <summary>
     /// Class CharacterViewModel.
     /// </summary>
     /// <seealso cref="Visualizer.ViewModels.AbstractViewModel" />
     public class CharacterViewModel : AbstractViewModel
     {
         #region Fields

         /// <summary>
         /// The character model
         /// </summary>
         private CharacterModel characterModel;

         /// <summary>
         /// The Image brushes for the images.
         /// </summary>
         private ImageBrush iconBrush, emotionBrush, actionBrush;

         #endregion Fields

         #region Constructors

         /// <summary>
         /// Initializes a new instance of the <see cref="CharacterViewModel"/> class.
         /// </summary>
         /// <param name="pos">The position.</param>
         /// <param name="id">The identifier.</param>
         /// <param name="emotion">The emotion.</param>
         /// <param name="action">The action.</param>
         public CharacterViewModel(VRPosition pos, int id, int emotion, int action)
             : base(pos)
         {
             this.characterModel = new CharacterModel(pos, id, emotion, action);
             this.IconBrush = new ImageBrush();
             this.EmotionBrush = new ImageBrush();
             this.ActionBrush = new ImageBrush();
             this.SetIcon();
             this.SetEmotion(emotion);
             this.SetAction(action);
             this.Model = this.characterModel;
             this.SetPosition(pos);
         }

         #endregion Constructors

         #region Properties

         /// <summary>
         /// Gets the icon brush.
         /// </summary>
         /// <value>The icon brush.</value>
         public ImageBrush IconBrush
         {
             get
             {
                 return this.iconBrush;
             }

             private set
             {
                 if (this.IconBrush != value)
                 {
                     this.iconBrush = value;
                     this.RaisePropertyChanged("IconBrush");
                 }
             }
         }

         /// <summary>
         /// Gets the emotion brush.
         /// </summary>
         /// <value>The emotion brush.</value>
         public ImageBrush EmotionBrush
         {
             get
             {
                 return this.emotionBrush;
             }

             private set
             {
                 if (this.EmotionBrush != value)
                 {
                     this.emotionBrush = value;
                     this.RaisePropertyChanged("EmotionBrush");
                 }
             }
         }

         /// <summary>
         /// Gets the action brush.
         /// </summary>
         /// <value>The action brush.</value>
         public ImageBrush ActionBrush
         {
             get
             {
                 return this.actionBrush;
             }

             private set
             {
                 if (this.ActionBrush != value)
                 {
                     this.actionBrush = value;
                     this.RaisePropertyChanged("ActionBrush");
                 }
             }
         }

         #endregion Properties

         #region Methods

         /// <summary>
         /// Sets the icon.
         /// </summary>
         public void SetIcon()
         {
             ImageSource source = ImageMap.GetImage(ImageEnum.GetCharacter(this.characterModel.Id % 2));
             ImageBrush brush = this.IconBrush;
             brush.ImageSource = source;
             this.IconBrush = brush;
         }

         /// <summary>
         /// Sets the action.
         /// </summary>
         /// <param name="action">The action.</param>
         public void SetAction(int action)
         {
             this.characterModel.SetAction(action);
             ImageSource source = ImageMap.GetImage(ImageEnum.GetCharacterAction((int)this.characterModel.Action));
             ImageBrush brush = this.ActionBrush;
             brush.ImageSource = source;
             this.ActionBrush = brush;
         }

         /// <summary>
         /// Sets the emotion.
         /// </summary>
         /// <param name="emotion">The emotion.</param>
         public void SetEmotion(int emotion)
         {
             this.characterModel.SetEmotion(emotion);
             ImageSource source = ImageMap.GetImage(ImageEnum.GetCharacterEmotion((int)this.characterModel.Emotion));
             ImageBrush brush = this.EmotionBrush;
             brush.ImageSource = source;
             this.EmotionBrush = brush;
         }

         #endregion Methods
     }
 }