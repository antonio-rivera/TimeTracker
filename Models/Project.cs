using System;
namespace TimeTracker.Models
{
    public class Project
    {
        public decimal Time { get; set; }
        public string Name { get; set; }
        public Project(decimal time, string name)
        {
            Time = time;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

