// <copyright file="BenchViewModel.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>PatientViewModel class</summary>
// ***********************************************************************
namespace Visualizer.ViewModels
{
    using System.Windows.Media;
    using Visualizer.Models.Furniture;
    using Visualizer.Utilities;

    /// <summary>
    /// The view-model for the bench.
    /// </summary>
    /// <seealso cref="Visualizer.ViewModels.AbstractViewModel" />
    public class BenchViewModel : AbstractViewModel
    {
        #region Fields

        /// <summary>
        /// The rectangle width is initialized at 0, will be set in constructor
        /// </summary>
        private int rectangleWidth = 0;

        /// <summary>
        /// The bench model
        /// </summary>
        private BenchModel benchModel;

        /// <summary>
        /// The icon brush of a seat
        /// </summary>
        private ImageBrush iconBrush;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchViewModel"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="amountSeats">The amount seats.</param>
        public BenchViewModel(VRPosition pos, int id, int amountSeats)
            : base(pos)
        {
            this.benchModel = new BenchModel(pos, id, amountSeats);
            this.SetRectangleWidth(amountSeats);
            this.Model = this.benchModel;
            this.SetPosition(pos);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the icon brush.
        /// </summary>
        /// <value>
        /// The icon brush.
        /// </value>
        public ImageBrush IconBrush
        {
            get
            {
                return this.iconBrush;
            }

            set
            {
                if (this.iconBrush != value)
                {
                    this.iconBrush = value;
                    this.RaisePropertyChanged("IconBrush");
                }
            }
        }

        /// <summary>
        /// Gets or sets the width of the bench rectangle.
        /// </summary>
        /// <value>
        /// The width of the bench rectangle.
        /// </value>
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

        /// <summary>
        /// Gets the amount seats.
        /// </summary>
        /// <value>
        /// The amount seats.
        /// </value>
        public int AmountSeats
        {
            get
            {
                return this.benchModel.NumberOfSeats;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Sets the width of the rectangle.
        /// </summary>
        /// <param name="amountSeats">The amount of seats.</param>
        public void SetRectangleWidth(int amountSeats)
        {
            int widthForOneSeat = 100;
            this.BenchRectangleWidth = widthForOneSeat * amountSeats;
        }

        /// <summary>
        /// Sets the icon of a seat.
        /// </summary>
        public void SetIcon()
        {
            ImageSource source = ImageMap.GetImage("ChairIcon");
            ImageBrush brush = this.IconBrush;
            brush.ImageSource = source;
            this.iconBrush = brush;
        }

        #endregion Methods
    }
}