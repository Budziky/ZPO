using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    // Status i priorytet
    public enum TaskStatus { DoZrobienia, wTrakcie, Zrobione }
    public enum PriorityLevel { Niski, Średni, Wysoki }

    // Klasa użytkownika
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    // Klasa zadania
    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public PriorityLevel Priority { get; set; }
        public List<Guid> AssignedUserIds { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; }
    }

    // Klasa projektu
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TaskItem> Tasks { get; set; } = new();
        public List<Guid> TeamMemberIds { get; set; } = new(); // Odwołania do User.Id
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? Deadline { get; set; }
    }

    // Klasa danych do zapisu i odczytu
    public class AppData
    {
        public List<User> Users { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
    }
}
