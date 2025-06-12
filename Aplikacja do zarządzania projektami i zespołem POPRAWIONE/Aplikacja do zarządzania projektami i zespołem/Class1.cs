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

    // Klasa bazowa do zadań
    public abstract class BaseTask
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; }

        public abstract void UpdateStatus(TaskStatus newStatus);
    }

    // Interface do klasy zadania
    public interface ITaskOperations
    {
        void AssignUser(Guid userId); // Przypisanie użytkownika do zadania
        void RemoveUser(Guid userId); // Usunięcie użytkownika z zadania
    }
    // Klasa zadania
    public class TaskItem : BaseTask, ITaskOperations
    {
        public TaskStatus Status { get; set; }
        public PriorityLevel Priority { get; set; }
        public List<Guid> AssignedUserIds { get; set; } = new();

        public override void UpdateStatus(TaskStatus newStatus)
        {
            if (newStatus == TaskStatus.Zrobione && DueDate.HasValue && DueDate.Value < DateTime.Now)
            {
                throw new InvalidTaskOperationException("Nie można oznaczyć zadania jako 'Zrobione', jeśli termin został przekroczony.");
            }
            Status = newStatus;
        }

        public void AssignUser(Guid userId)
        {
            if (!AssignedUserIds.Contains(userId))
                AssignedUserIds.Add(userId);
        }

        public void RemoveUser(Guid userId)
        {
            if (!AssignedUserIds.Remove(userId))
                throw new InvalidTaskOperationException("Użytkownik nie jest przypisany do tego zadania.");
        }
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
