// <copyright file="Bench.cs" company="CleVR B.V.">
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
    /// Bench model
    /// </summary>
    /// <seealso cref="BaseModel" />
    public class Bench : BaseModel
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
        /// Initializes a new instance of the <see cref="Bench" /> class.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="id">The unique  identifier.</param>
        public Bench(Transform transform, int id)
            : base(transform, id, "Bench")
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
        }

        /// <summary>
        /// Serializes bench objects in XML format.
        /// </summary>
        /// <returns></returns>
        public override String toXML(bool createOrUpdate)
        {
            StringBuilder output = new StringBuilder();
            XmlWriterSettings ws = new XmlWriterSettings();
            ws.Indent = true;
            XmlWriter writer = XmlWriter.Create(output, ws);

            writer.WriteStartElement("udp");
            createElement(writer, "object", createOrUpdate);
            createElement(writer, "operation", createOrUpdate);
            createElement(writer, "Transform", createOrUpdate);
            createElement(writer, "ID", createOrUpdate);
            createElement(writer, "Seats", createOrUpdate);
            writer.WriteFullEndElement();

            return output.ToString();
        }

        /// <summary>
        /// Creates the element.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="type">The type.</param>
        public void createElement(XmlWriter writer, String type, bool creUp)
        {
            switch (type)
            {
                case "object":
                    writer.WriteStartElement("object");
                    writer.WriteString("5");
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

                case "Transform":
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

                case "ID":
                    writer.WriteStartElement("id");
                    writer.WriteString(this.Id.ToString());
                    writer.WriteFullEndElement();
                    break;

                case "Seats":
                    foreach (Seat i in Seats)
                    {
                        writer.WriteString(i.toXML(creUp));
                    }
                    break;
            }
        }

        #endregion Methods
    }
}