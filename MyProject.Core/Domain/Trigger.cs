namespace MyProject.Core.Domain
{
    /// <summary>
    /// Represents a trigger entity.
    /// </summary>
    public class Trigger
    {
        /// <summary>
        /// Id of the trigger.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the trigger.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Connector that this trigger is for.
        /// </summary>
        public virtual Connector ConnectorEntry { get; set; }

        /// <summary>
        /// ConnectorId that this trigger is associated with.
        /// </summary>
        public int ConnectorEntry_Id { get; set; }
    }
}
