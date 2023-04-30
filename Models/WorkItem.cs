using System;
namespace TimeTracker.Models
{
    public class WorkItem
    {
        public string Name { get; set; }
        public Project AssignedTo { get; set; }
        public WorkItem(string name, Project assignedTo)
        {
            Name = name;
            AssignedTo = assignedTo;
        }
    }
}

