namespace MyProject.Core.Domain
{
    /// <summary>
    /// Represents a connector entity.
    /// </summary>
    public class Connector
    {
        private IList<Trigger> _triggers;

        /// <summary>
        /// Id of the connector.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the connector.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the connector.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the triggers
        /// </summary>
        public virtual IList<Trigger> Triggers
        {
            get => _triggers ?? (_triggers = new List<Trigger>());
            protected set => _triggers = value;
        }
    }
}
