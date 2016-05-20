// <copyright file="Car.cs" company="CleVR B.V.">
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
    /// Car model broom broom!!
    /// </summary>
    public sealed class Car : BaseModel
    {
        #region Fields

        /// <summary>
        /// The turn siren off on moment in time
        /// </summary>
        private float turnSirenOffOn;

        /// <summary>
        /// The network server
        /// </summary>
        private Sender sender = new Sender();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Car" /> class.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="carType">Type of the car.</param>
        public Car(Transform transform, int id, CarType carType)
            : base(transform, id, carType.ToString())
        {
            this.Type = carType;
            sender.sendXml(this, true);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the car type.
        /// </summary>
        public CarType Type { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance has siren.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has siren; otherwise, <c>false</c>.
        /// </value>
        public bool HasSiren
        {
            get
            {
                return this.Type != CarType.Car;
            }
        }

        /// <summary>
        /// Gets a value indicating whether [siren active].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [siren active]; otherwise, <c>false</c>.
        /// </value>
        public bool SirenActive { get; private set; }

        /// <summary>
        /// Activates the siren.
        /// </summary>
        /// <param name="duration">The duration.</param>
        public void ActivateSiren(float duration)
        {
            this.turnSirenOffOn = Time.time + duration;
            this.SirenActive = true;
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            if (this.SirenActive && this.turnSirenOffOn < Time.time)
            {
                this.SirenActive = false;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Serializes car objects in XML format.
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
            createElement(writer, "CarType", createOrUpdate);
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
                    writer.WriteString("3");
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

                case "CarType":
                    writer.WriteStartElement("carType");
                    writer.WriteString(this.Type.ToString());
                    writer.WriteFullEndElement();
                    if (this.Type != CarType.Car)
                    {
                        writer.WriteStartElement("sirenActive");
                        writer.WriteString(this.SirenActive.ToString());
                        writer.WriteFullEndElement();
                    }
                    break;
            }
        }

        #endregion
    }
}