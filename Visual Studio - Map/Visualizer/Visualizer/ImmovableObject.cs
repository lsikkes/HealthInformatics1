// <copyright file="ImmovableObject.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Visualizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class ImmovableObject.
    /// </summary>
    /// <seealso cref="Visualizer.VRObject" />
    public class ImmovableObject : VRObject
    {
        #region Constructors

        /// <summary>
        /// Constructor of ImmovableObject
        /// </summary>
        /// <param name="x"> x position</param>
        /// <param name="y"> y position</param>
        /// <param name="rotation"> rotation of object</param>
        /// <param name="id"> id of object</param>
        /// <param name="name">name of object</param>
        public ImmovableObject(int x, int y, int rotation, int id, string name)
            : base(x, y, rotation, id, name)
        {
        }

        #endregion Constructors
    }
}