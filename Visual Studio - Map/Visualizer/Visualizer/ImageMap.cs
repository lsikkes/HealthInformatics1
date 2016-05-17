namespace Visualizer
{
    using GeenNaam;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Controls;
    using System.Windows.Media.Imaging;
    using Visualizer;

    public class ImageMap
    {
        #region Fields

        private static readonly string path = MainWindow.AbsolutePath;
        private static Dictionary<string, BitmapImage> images = new Dictionary<string, BitmapImage>();

        private static Logger logger = Logger.GetInstance();

        #endregion Fields

        #region Methods

        public static void loadImages()
        {
            if (String.IsNullOrEmpty(path))
            {
                logger.Error("path for loading images is empty");
            }

            string[] filePaths = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg")).ToArray();
            foreach (string filePath in filePaths)
            {
                images.Add(Path.GetFileName(filePath), new BitmapImage(new Uri(filePath)));
                logger.Info("Image with name: " + Path.GetFileName(filePath) + " added to ImageMap");
            }
        }

        public static BitmapImage getImage(string key)
        {
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