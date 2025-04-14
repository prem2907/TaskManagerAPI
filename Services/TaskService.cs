using TaskManagerApi.Models;
using MyTask = TaskManagerApi.Models.Task;

namespace TaskManagerApi.Services
{
    public class TaskService
    {
        private readonly List<MyTask> _tasks;

        public TaskService()
        {
            _tasks = new List<MyTask>
            {
                new MyTask
                {
                    Id = 1,
                    Title = "Demo Task",
                    Description = "Sample task",
                    DueDate = DateTime.Now.AddDays(5),
                    IsCompleted = false
                }
            };
        }

        public List<MyTask> GetAllTasks() => _tasks;

        public MyTask? GetTaskById(int id) => _tasks.FirstOrDefault(t => t.Id == id);

        public void AddTask(MyTask task)
        {
            task.Id = _tasks.Count > 0 ? _tasks.Max(t => t.Id) + 1 : 1;
            _tasks.Add(task);
        }

        public void DeleteTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                _tasks.Remove(task);
        }

        public void UpdateTask(MyTask updated)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == updated.Id);
            if (task != null)
            {
                task.Title = updated.Title;
                task.Description = updated.Description;
                task.DueDate = updated.DueDate;
                task.IsCompleted = updated.IsCompleted;
            }
        }
    }
}
