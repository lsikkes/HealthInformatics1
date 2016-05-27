// <copyright file="VRPosition.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>Position class</summary>
// ***********************************************************************
namespace Visualizer.Utilities
{
    /// <summary>
    /// Class Position.
    /// </summary>
    public class VRPosition
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VRPosition"/> class.
        /// </summary>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="rotation">The rotation.</param>
        public VRPosition(int x, int y, int rotation)
        {
            this.X = x;
            this.Y = y;
            this.Rotation = rotation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VRPosition"/> class.
        /// </summary>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        public VRPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Rotation = 0;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the x position.
        /// </summary>
        /// <value>The x position.</value>
        public int X { get; private set; }

        /// <summary>
        /// Gets the y position.
        /// </summary>
        /// <value>The y position.</value>
        public int Y { get; private set; }

        /// <summary>
        /// Gets the rotation.
        /// </summary>
        /// <value>The rotation.</value>
        public int Rotation { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Moves the position to the given x and y.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 17;
            hash = (hash * 31) + this.X;
            hash = (hash * 31) + this.Y;
            hash = (hash * 31) + this.Rotation;
            return hash;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            VRPosition that = other as VRPosition;
            if ((object)that == null)
            {
                return false;
            }

            return this.X == that.X && this.Y == that.Y && this.Rotation == that.Rotation;
        }

        #endregion Methods
    }
}