// <copyright file="TV.cs" company="CleVR B.V.">
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
    /// There is nothing interesting on TV ever
    /// </summary>
    /// <seealso cref="BaseModel" />
    public class TV : BaseModel
    {
        #region Fields

        /// <summary>
        /// The show text until moment in time
        /// </summary>
        private float showTextUntil;

        /// <summary>
        /// The network server
        /// </summary>
        private Sender sender = new Sender();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TV" /> class.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="id">The unique identifier.</param>
        public TV(Transform transform, int id)
            : base(transform, id, "TV")
        {
            this.State = TVState.Off;
            sender.sendXml(this, true);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public TVState State { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [show text].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show text]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowingText { get; private set; }

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; private set; }

        /// <summary>
        /// Gets the movie.
        /// </summary>
        /// <value>
        /// The movie.
        /// </value>
        public string Movie { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Turns the TV off.
        /// </summary>
        public void TurnOff()
        {
            this.State = TVState.Off;
            sender.sendXml(this, false);
        }

        /// <summary>
        /// Turns the TV on.
        /// </summary>
        public void TurnOn()
        {
            this.State = TVState.On;
            sender.sendXml(this, false);
        }

        /// <summary>
        /// Plays the movie.
        /// </summary>
        /// <param name="movie">The movie.</param>
        public void PlayMovie(string movie)
        {
            this.Movie = movie;
            this.ShowingText = false;
            sender.sendXml(this, false);
        }

        /// <summary>
        /// Shows the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="duration">The duration.</param>
        public void ShowText(string text, float duration)
        {
            this.showTextUntil = Time.time + duration;
            this.Text = text;
            this.ShowingText = true;
            sender.sendXml(this, false);
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            if (this.ShowingText && Time.time > this.showTextUntil)
            {
                this.ShowingText = false;
            }
          //  sender.sendXml(this, false);
        }

        /// <summary>
        /// Serializes TV objects in XML format.
        /// </summary>
        /// <returns>The XML formatted string.</returns>
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
            createElement(writer, "TVState", createOrUpdate);
            writer.WriteFullEndElement();

            return output.ToString();
        }

        /// <summary>
        /// Creates the element.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="type">The type of element.</param>
        public void createElement(XmlWriter writer, String type, bool creUp)
        {
            switch (type)
            {
                case "object":
                    writer.WriteStartElement("object");
                    writer.WriteString("4");
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
                    writer.WriteStartElement("ID");
                    writer.WriteString(this.Id.ToString());
                    writer.WriteFullEndElement();
                    break;

                case "TVState":
                    writer.WriteStartElement("TVState");
                    writer.WriteString(this.State.ToString());
                    writer.WriteFullEndElement();

                    if(this.ShowingText)
                    {
                        writer.WriteStartElement("ShowingTextUntil");
                        writer.WriteString(this.showTextUntil.ToString());
                        writer.WriteFullEndElement();
                       
                        writer.WriteStartElement("displayedText");
                        writer.WriteString(this.Text.ToString());
                        writer.WriteFullEndElement();
                    }
                    break;
            }
        }

        #endregion Methods
    }
}