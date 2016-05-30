using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Visualizer.Utilities;

namespace Visualizer.Models
{
    public class TreeModel : AbstractSurroundingModel
    {
        #region Constructors

        public TreeModel(VRPosition pos, int id)
            : base(pos, id)
        {
            ImageSource source = ImageMap.GetImage(ImageEnum.TreeIcon.ToString());
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = source;
            this.SurroundingImage = brush;
            this.Height = 100;
            this.Width = 100;
        }

        #endregion Constructors
    }
}