namespace ToDoListApp.Models
{
    public static class ToDoTaskRepository
    {
        public static List<ToDoTask> tasks = new List<ToDoTask>()
        {
            new ToDoTask { Id = 1, Title = "Buy groceries", IsCompleted = false },
            new ToDoTask { Id = 2, Title = "Walk the dog", IsCompleted = true, CompletedDate=(DateTime.Now).AddDays(-10) },
            new ToDoTask { Id = 3, Title = "Finish project", IsCompleted = false }
        };

        public static void AddTask(ToDoTask task)
        {
            if (tasks.Count > 0)
            {
                var maxId = tasks.Max(t => t.Id);
                task.Id = maxId + 1;
                tasks.Add(task);
            }
            else
            {
                task.Id = 1;
                tasks.Add(task);
            }
        }

        public static List<ToDoTask> GetTasks() 
        {
            //var sortedTasks = tasks;
            var sortedTasks = tasks.
                OrderBy(t => t.IsCompleted)
                .ThenByDescending(t => t.Id)
                .ToList();
            return sortedTasks;
        }

        public static ToDoTask? GetTasksById(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                return new ToDoTask
                {
                    Id = task.Id,
                    Title = task.Title,
                    IsCompleted = task.IsCompleted,
                    CompletedDate = task.CompletedDate
                };
            }

            return null;
        }

        public static void UpdateTask(int Id, ToDoTask task)
        {
            if (Id != task.Id) return;

            var taskToUpdate = tasks.FirstOrDefault(t => t.Id == Id);
            if (taskToUpdate != null)
            {
                taskToUpdate.Title = task.Title;
            }
        }

        public static void DeleteTask(int Id)
        {
            var task = tasks.FirstOrDefault(s => s.Id == Id);
            if (task != null)
            {
                tasks.Remove(task);
            }
        }
    }
}
