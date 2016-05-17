using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visualizer
{
    internal class ImageEnum
    {
        #region Fields

        public static ImageEnum AmbulanceCar = new ImageEnum("image_police_car.PNG");
        public static ImageEnum AmbulanceCarIcon = new ImageEnum("icon_police.PNG");
        public static ImageEnum PoliceCar = new ImageEnum("image_police_car.PNG");
        public static ImageEnum PoliceCarIcon = new ImageEnum("icon_police.PNG");
        public static ImageEnum FireFighterCar = new ImageEnum("image_police_car.PNG");
        public static ImageEnum FireFighterCarIcon = new ImageEnum("icon_police.PNG");
        public static ImageEnum NormalCar = new ImageEnum("image_police_car.PNG");
        public static ImageEnum NormalCarIcon = new ImageEnum("icon_police.PNG");
        private readonly string link;

        #endregion Fields

        #region Constructors

        public ImageEnum(string link)
        {
            this.link = GeenNaam.MainWindow.AbsolutePath + link;
        }

        public override string ToString()
        {
            return this.link;
        }

        #endregion Constructors
    }
}