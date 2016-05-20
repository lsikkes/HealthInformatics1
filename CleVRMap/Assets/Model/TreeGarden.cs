// <copyright file="TreeGarden.cs" company="CleVR B.V.">
//     CleVR B.V. All rights reserved.
// </copyright>
namespace Assets.Model
{
    using Factories;
    using Network;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;
    using UnityEngine;

    /// <summary>
    /// Three Garden representing a nice big tree and some seats around it
    /// </summary>
    /// <seealso cref="BaseModel" />
    public class TreeGarden : BaseModel
    {
        #region Fields

        /// <summary>
        /// The seats
        /// </summary>
        private List<Seat> seats = new List<Seat>();

        /// <summary>
        /// The network server
        /// </summary>
        private Sender sender = new Sender();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeGarden" /> class.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="id">The unique identifier.</param>
        public TreeGarden(Transform transform, int id)
            : base(transform, id, "TreeGarden")
        {
            sender.sendXml(this, true);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the seats.
        /// </summary>
        /// <value>
        /// The seats.
        /// </value>
        public IEnumerable<Seat> Seats
        {
            get
            {
                return this.seats;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds the seat.
        /// </summary>
        /// <param name="transform">The transform.</param>
        public void AddSeat(Transform transform)
        {
            this.seats.Add(SeatFactory.CreateSeat(transform));
            sender.sendXml(this, false);
        }

        /// <summary>
        /// Serializes base model objects in XML format.
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
            createElement(writer, "seats", createOrUpdate);
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
                    writer.WriteString("8");
                    writer.WriteFullEndElement();
                    break;

                case "operation":
                    writer.WriteStartElement("operation");
                    if(creUp)
                    {
                        writer.WriteString("create");
                    } else
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

                case "seats":
                    foreach(Seat i in Seats)
                    {
                        writer.WriteString(i.toXML(creUp));
                    }
                    break;
            }
        }

        #endregion Methods
    }
}