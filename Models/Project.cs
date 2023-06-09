﻿using System;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;

namespace TimeTracker.Models
{
    public class Project
    {
        public Guid Id { get; init; }
        private decimal time;
        private string name;
        private string timeRep;


        public decimal Time { get => this.time; set => this.time = value == default ? 0 : value; }
        public string Name { get => this.name; set => this.name = string.IsNullOrWhiteSpace(value) ? "" : value; }
        public string TimeRep
        {
            get => this.timeRep;
            set => this.timeRep = value;
        }

        public Project(decimal time, string name)
        {
            Id = Guid.NewGuid();
            Time = time;
            Name = name;
            TimeRep = time.ToString();
        }

        public override string ToString()
        {
            return Name;
        }

        public void Deconstruct(out decimal time, out string projectName)
        {
            projectName = this.Name;
            time = this.Time;
        }
    }
}

