using System;
namespace TimeTracker.Models
{
    public class WorkItem
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public Project Project { get; set; }
        public WorkItem(string name, Project project)
        {
            Id = Guid.NewGuid();
            Name = name;
            Project = project;
        }
    }
}

