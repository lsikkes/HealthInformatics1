// <copyright file="Building.cs" company="CleVR B.V.">
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
    /// Building model
    /// </summary>
    /// <seealso cref="Assets.Model.BaseModel" />
    public class Building : BaseModel
    {

        #region Fields 

        /// <summary>
        /// The network server
        /// </summary>
        private Sender sender = new Sender();

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class.
        /// </summary>
        /// <param name="transform">The transform.</param>
        public Building(Transform transform)
            : base(transform, -1, "Building")
        {
            sender.sendXml(this, true);
        }

        #endregion Constructors

        /// <summary>
        /// Serializes Building objects in XML format.
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
            createElement(writer, "transform", createOrUpdate);
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
                    writer.WriteString("7");
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
            }
        }
    }
}