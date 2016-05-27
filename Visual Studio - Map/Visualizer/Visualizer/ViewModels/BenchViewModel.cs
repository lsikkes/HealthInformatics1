namespace Visualizer.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Shapes;
    using Visualizer.Models;
    using Visualizer.Models.Furniture;
    using Visualizer.Utilities;

    public class BenchViewModel : AbstractViewModel
    {
        #region Fields

        //private List<Ellipse> iconList;
        private int rectangleWidth = 0;

        private BenchModel benchModel;

        private ImageBrush iconBrush;

        #endregion Fields

        #region Constructors

        public BenchViewModel(VRPosition pos, int id, int amountSeats)
            : base(pos)
        {
            this.benchModel = new BenchModel(pos, id, amountSeats);
            this.SetRectangleWidth(amountSeats);
            this.Model = this.benchModel;
            this.SetPosition(pos);
        }

        #endregion Constructors

        #region Methods

        //public List<Ellipse> IconList
        //{
        //    get
        //    {
        //        return this.iconList;
        //    }

        //    set
        //    {
        //        if (value != this.iconList)
        //        {
        //            for (int i = 0; i < this.amountSeats; i++)
        //            {
        //                Ellipse e = new Ellipse();

        //                e.Width = 80;
        //                e.Height = 80;
        //                Thickness margin = e.Margin;
        //                margin.Left = 10;
        //                e.Margin = margin;
        //                e.Fill = new SolidColorBrush(Colors.Blue);
        //                iconList.Add(e);
        //            }
        //            this.RaisePropertyChanged("IconList");
        //        }
        //    }
        //}

        public void SetRectangleWidth(int amountSeats)
        {
            int widthForOneSeat = 100;
            this.BenchRectangleWidth = widthForOneSeat * amountSeats;
        }

        public void SetIcon()
        {
            ImageSource source = ImageMap.GetImage("ChairIcon");
            ImageBrush brush = this.IconBrush;
            brush.ImageSource = source;
            this.iconBrush = brush;
        }

        #endregion Methods

        #region Properties

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

        public int BenchRectangleWidth
        {
            get
            {
                return this.rectangleWidth;
            }

            set
            {
                if (value != this.rectangleWidth)
                {
                    this.rectangleWidth = value;
                    this.RaisePropertyChanged("BenchRectangleWidth");
                }
            }
        }

        #endregion Properties
    }
}