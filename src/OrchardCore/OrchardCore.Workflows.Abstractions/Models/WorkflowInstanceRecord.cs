using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace OrchardCore.Workflows.Models
{
    /// <summary>
    /// Represents a workflow instance.
    /// </summary>
    public class WorkflowInstanceRecord
    {
        public int Id { get; set; }

        /// <summary>
        /// The ID of the workflow definition.
        /// </summary>
        public int DefinitionId { get; set; }

        /// <summary>
        /// A unique identifier for this workflow instance.
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// The correlation ID can be used to resume workflow instances that sre associated with specific objects, such as content items.
        /// </summary>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Serialized state of the workflow.
        /// </summary>
        public JObject State { get; set; } = new JObject();

        public WorkflowStatus Status { get; set; }
        public string FaultMessage { get; set; }

        /// <summary>
        /// List of activities the current workflow instance is waiting on 
        /// for continuing its process.
        /// </summary>
        public IList<AwaitingActivityRecord> AwaitingActivities { get; } = new List<AwaitingActivityRecord>();

        public DateTime CreatedUtc { get; set; }
    }
}