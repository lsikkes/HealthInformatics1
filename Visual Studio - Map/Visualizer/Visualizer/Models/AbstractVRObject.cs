// <copyright file="AbstractVRObject.cs" company="HI1">
//     Copyright ©  2016
// </copyright>
// <summary>VRObjectModel class</summary>
// ***********************************************************************
namespace Visualizer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Visualizer.Utilities;
    using Visualizer.Log;

    /// <summary>
    /// Class VRObjectModel that is the base of the VR objects.
    /// </summary>
    public abstract class AbstractVRObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractVRObject"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="id">The identifier.</param>
        public AbstractVRObject(VRPosition pos, int id)
        {
            this.Position = pos;
            this.Id = id;
            this.Logger = Logger.GetInstance();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <value>The position.</value>
        public VRPosition Position { get; private set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; private set; }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>The logger.</value>
        public Logger Logger { get; private set; }

        #endregion Properties
    }
}