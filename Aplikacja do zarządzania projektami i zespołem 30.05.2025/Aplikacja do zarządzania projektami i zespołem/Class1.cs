using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    public enum TaskStatus { ToDo, InProgress, Done }
    public enum PriorityLevel { Low, Medium, High }

    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;
        public List<User> AssignedUsers { get; set; } = new List<User>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; }
    }

    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        public List<User> TeamMembers { get; set; } = new List<User>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? Deadline { get; set; }
    }
}
