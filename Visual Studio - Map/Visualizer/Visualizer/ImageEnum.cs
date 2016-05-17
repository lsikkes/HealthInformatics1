using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visualizer
{
    public class ImageEnum
    {
        #region Fields

        public static ImageEnum AmbulanceCar = new ImageEnum("image_police_car.png");
        public static ImageEnum AmbulanceCarIcon = new ImageEnum("icon_police.png");
        public static ImageEnum PoliceCar = new ImageEnum("image_police_car.png");
        public static ImageEnum PoliceCarIcon = new ImageEnum("icon_police.png");
        public static ImageEnum FireFighterCar = new ImageEnum("image_police_car.png");
        public static ImageEnum FireFighterCarIcon = new ImageEnum("icon_police.png");
        public static ImageEnum NormalCar = new ImageEnum("image_police_car.png");
        public static ImageEnum NormalCarIcon = new ImageEnum("icon_police.png");
        private readonly string name;

        #endregion Fields

        #region Constructors

        public ImageEnum(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }

        #endregion Constructors
    }
}