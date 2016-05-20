// <copyright file="Seat.cs" company="CleVR B.V.">
//     CleVR B.V. All rights reserved.
// </copyright>
namespace Assets.Model
{
    using Network;
    using System;
    using System.Text;
    using System.Xml;
    using UnityEngine;

    /// <summary>
    /// Nice comfy seat with absolutely no whoopee cushion on it
    /// </summary>
    /// <seealso cref="BaseModel" />
    public class Seat : BaseModel
    {
        #region Fields

        /// <summary>
        /// The assigned to
        /// </summary>
        private Character assignedTo = null;

        /// <summary>
        /// The network server.
        /// </summary>
        private Sender sender = new Sender();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Seat"/> class.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="id">The unique identifier.</param>
        public Seat(Transform transform, int id)
            : base(transform, id, "Seat")
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the character assigned to the seat.
        /// </summary>
        /// <value>
        /// The assigned to.
        /// </value>
        public Character AssignedTo
        {
            get
            {
                return this.assignedTo;
            }

            private set
            {
                this.assignedTo = value;
                sender.sendXml(this, false);
            }
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Seat"/> is reserved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if reserved; otherwise, <c>false</c>.
        /// </value>
        public bool Reserved
        {
            get
            {
                return this.AssignedTo != null;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Assigns the seat and sends this information over network.
        /// </summary>
        /// <param name="character">The character.</param>
        public void AssignSeat(Character character)
        {
            this.AssignedTo = character;
            sender.sendXml(this, false);
        }

        /// <summary>
        /// Stands up and sends this information over network.
        /// </summary>
        public void StandUp()
        {
            if (this.AssignedTo != null)
            {
                this.AssignedTo.StandUp();
            }

            this.AssignedTo = null;
            sender.sendXml(this, false);
        }

        /// <summary>
        /// Serializes seat objects in XML format.
        /// </summary>
        /// <returns>
        ///   The XML formatted string.
        /// </returns>
        public override String toXML(bool createOrUpdate)
        {
            StringBuilder output = new StringBuilder();
            XmlWriterSettings ws = new XmlWriterSettings();
            ws.Indent = true;
            XmlWriter writer = XmlWriter.Create(output, ws);

            writer.WriteStartElement("udp");
            createElement(writer, "object", createOrUpdate);
            createElement(writer, "operation", createOrUpdate);
            createElement(writer, "transform", createOrUpdate);
            createElement(writer, "id", createOrUpdate);
            createElement(writer, "reserved", createOrUpdate);
            if (this.Reserved)
            {
                createElement(writer, "seatAssignedTo", createOrUpdate);
            }
            writer.WriteFullEndElement();

            return output.ToString();
        }

        /// <summary>
        /// Creates the element.
        /// </summary>
        /// <param name="writer">The XML writer.</param>
        /// <param name="type">The type of element.</param>
        public void createElement(XmlWriter writer, String type, bool creUp)
        {
            switch (type)
            {
                case "object":
                    writer.WriteStartElement("object");
                    writer.WriteString("6");
                    writer.WriteFullEndElement();
                    break;

                case "operation":
                    writer.WriteStartElement("operation");
                    if (creUp)
                    {
                        writer.WriteString("create");
                    }
                    else
                    {
                        writer.WriteString("update");
                    }
                    writer.WriteFullEndElement();
                    break;

                case "transform":
                    writer.WriteStartElement("x");
                    writer.WriteString(Transform.localPosition.x.ToString());
                    writer.WriteFullEndElement();

                    writer.WriteStartElement("y");
                    writer.WriteString(Transform.localPosition.y.ToString());
                    writer.WriteFullEndElement();

                    writer.WriteStartElement("rotation");
                    writer.WriteString(Transform.localRotation.ToString());
                    writer.WriteFullEndElement();
                    break;

                case "id":
                    writer.WriteStartElement("id");
                    writer.WriteString(this.Id.ToString());
                    writer.WriteFullEndElement();
                    break;

                case "reserved":
                    writer.WriteStartElement("reserved");
                    writer.WriteString(this.Reserved.ToString());
                    writer.WriteFullEndElement();
                    break;

                case "seatAssignedTo":
                    writer.WriteStartElement("seatAssignedToCharacter");
                    writer.WriteString(this.assignedTo.Id.ToString());
                    writer.WriteFullEndElement();
                    break;
            }
        }

        #endregion Methods
    }
}