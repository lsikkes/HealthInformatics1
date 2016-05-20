// <copyright file="Character.cs" company="CleVR B.V.">
//     CleVR B.V. All rights reserved.
// </copyright>
namespace Assets.Model
{
    using Factories;
    using Network;
    using System;
    using System.Text;
    using System.Xml;
    using UnityEngine;

    /// <summary>
    /// Character model layer
    /// </summary>
    public sealed class Character : BaseModel
    {
        #region Fields

        /// <summary>
        /// The navmesh agent
        /// </summary>
        private NavMeshAgent agent;

        /// <summary>
        /// The current goal
        /// </summary>
        private Vector3 currentGoal = Vector3.zero;

        /// <summary>
        /// The network server
        /// </summary>
        private Sender sender = new Sender();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="profile">The profile.</param>
        public Character(Transform transform, int id, CharacterProfile profile)

            : base(transform, id, profile.name)
        {
            this.Profile = profile;
            this.IsActive = true;
            this.Emotion = CharacterEmotion.Neutral;    
            this.Action = CharacterAction.Nothing;
            sender.sendXml(this, true);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the profile.
        /// </summary>
        /// <value>
        /// The profile.
        /// </value>
        public CharacterProfile Profile { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance can navigate.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance can navigate; otherwise, <c>false</c>.
        /// </value>
        public bool CanNavigate
        {
            get
            {
                return this.agent != null;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has reached goal.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has reached goal; otherwise, <c>false</c>.
        /// </value>
        public bool HasReachedGoal
        {
            get
            {
                return ((this.Transform.position.x - this.currentGoal.x) * (this.Transform.position.x - this.currentGoal.x)) + ((this.Transform.position.z - this.currentGoal.z) * (this.Transform.position.z - this.currentGoal.z)) < 1.0f;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Character"/> is sitting.
        /// </summary>
        /// <value>
        ///   <c>true</c> if sitting; otherwise, <c>false</c>.
        /// </value>
        public bool IsSitting
        {
            get
            {
                return this.GoingToSeat && this.HasReachedGoal;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; private set; }

        /// <summary>
        /// Gets or sets the emotion.
        /// </summary>
        /// <value>
        /// The emotion.
        /// </value>
        public CharacterEmotion Emotion { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>
        /// The action.
        /// </value>
        public CharacterAction Action { get; set; }

        /// <summary>
        /// Gets a value indicating whether the character is going to a seat.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [going to seat]; otherwise, <c>false</c>.
        /// </value>
        public bool GoingToSeat { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Sets the goal.
        /// </summary>
        /// <param name="goal">The goal.</param>
        /// <param name="isSeat">if set to <c>true</c> the goal is a seat.</param>
        public void SetGoal(Vector3 goal, bool isSeat = false)
        {
            this.currentGoal = goal;

            if (this.CanNavigate)
            {
                this.agent.destination = this.currentGoal;
            }

            this.GoingToSeat = isSeat;
        }

        /// <summary>
        /// Sets the navmesh agent.
        /// </summary>
        /// <param name="agent">The agent.</param>
        public void SetNavMeshAgent(NavMeshAgent agent)
        {
            this.agent = agent;

            if (agent != null)
            {
                agent.speed = this.Profile.WalkingSpeed;

                this.SetGoal(this.Transform.position);
            }

        }

        /// <summary>
        /// Stands up from the seat.
        /// </summary>
        public void StandUp()
        {
            this.GoingToSeat = false;
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            this.IsActive = false;
            CharacterFactory.RemoveCharacter(this);
        }

        /// <summary>
        /// Sets the action.
        /// </summary>
        /// <param name="characterAction">The character action.</param>
        public void SetAction(CharacterAction characterAction)
        {
            this.Action = characterAction;
        }

        /// <summary>
        /// Sets the emotion.
        /// </summary>
        /// <param name="emotion">The emotion.</param>
        public void SetEmotion(CharacterEmotion emotion)
        {
            this.Emotion = emotion;
        }

        /// <summary>
        /// Serializes character objects in XML format.
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
            createElement(writer, "create", createOrUpdate);
            createElement(writer, "transform", createOrUpdate);
            createElement(writer, "id", createOrUpdate);
            createElement(writer, "emotion", createOrUpdate);
            createElement(writer, "action", createOrUpdate);
            writer.WriteFullEndElement();

            return output.ToString();
        }

        /// <summary>
        /// Creates the element.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="type">The type.</param>
        private void createElement(XmlWriter writer, String type, bool creUp)
        {
            switch (type)
            {
                case "object":
                    writer.WriteStartElement("object");
                    writer.WriteString("2");
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

                case "create":
                    writer.WriteStartElement("operation");
                    writer.WriteString("create");
                    writer.WriteFullEndElement();
                    break;
                case "transform":
                    writer.WriteStartElement("x");
                    writer.WriteString(Transform.localPosition.x.ToString());
                    writer.WriteFullEndElement();
                    writer.WriteStartElement("y");
                    writer.WriteString(Transform.localPosition.y.ToString());
                    writer.WriteFullEndElement();
                    break;
                case "id":
                    writer.WriteStartElement("id");
                    writer.WriteString(this.Id.ToString());
                    writer.WriteFullEndElement();
                    break;
                case "emotion":
                    writer.WriteStartElement("emotion");
                    writer.WriteString(this.Emotion.ToString());
                    writer.WriteFullEndElement();
                    break;
                case "action":
                    writer.WriteStartElement("action");
                    writer.WriteString(this.Action.ToString());
                    writer.WriteFullEndElement();
                    break;
            }
        }

        #endregion Methods
    }
}