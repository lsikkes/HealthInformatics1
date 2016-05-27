// <copyright file="ImageMap.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Visualizer.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Image map with all the images in the recourses map with the extension ".png", ".jpg" and ".jpeg".
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
    public class ImageMap
    {
        #region Fields

        /// <summary>
        /// Dictionary where all image recourses are stored
        /// </summary>
        private static Dictionary<string, BitmapImage> images = new Dictionary<string, BitmapImage>();

        /// <summary>
        /// The logger instance
        /// </summary>
        private static Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Loads all the images in.
        /// </summary>
        public static void LoadImages()
        {
            string path = PathGetter.GetResourcePath();

            string[] filePaths = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg")).ToArray();
            foreach (string filePath in filePaths)
            {
                string key = Path.GetFileName(filePath);
                if (images.ContainsKey(key))
                {
                    logger.Warning("Image key already loaded in. Key is " + key);
                }
                else
                {
                    images.Add(key, new BitmapImage(new Uri(filePath)));
                    logger.Info("Image with name: " + key + " added to ImageMap");
                }
            }
        }

        /// <summary>
        /// Gets the image with the given key. Which should be the name of the image.
        /// </summary>
        /// <param name="key"> The key as the name of the file. </param>
        /// <returns> Image recourse </returns>
        /// <exception cref="System.IO.FileNotFoundException">image isn't loaded</exception>
        public static BitmapImage GetImage(string key)
        {
            if (images.Count == 0)
            {
                ImageMap.LoadImages();
            }

            BitmapImage image;
            if (images.TryGetValue(key, out image))
            {
                return image;
            }
            else
            {
                logger.Error("image not found with key: " + key);
                throw new FileNotFoundException("image isn't loaded");
            }
        }

        #endregion Methods
    }
}