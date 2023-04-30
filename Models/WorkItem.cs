using System;
namespace TimeTracker.Models
{
    public class WorkItem
    {
        public string Name { get; set; }
        public Project Project { get; set; }
        public WorkItem(string name, Project project)
        {
            Name = name;
            Project = project;
        }
    }
}

