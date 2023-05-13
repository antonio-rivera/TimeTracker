using System;
namespace TimeTracker.Models
{
    public class WorkItem
    {
        public Guid Id { get; init; }
        private string name;
        public string Name { get => this.name; set => this.name = string.IsNullOrWhiteSpace(value) ? "" : value; }
        public Project Project { get; set; }
        public WorkItem(string name, Project project)
        {

            Id = Guid.NewGuid();
            Name = name;
            Project = project;
        }
    }
}

