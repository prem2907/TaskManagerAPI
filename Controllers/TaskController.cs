using Microsoft.AspNetCore.Mvc;
using TaskManagerApi.Models;
using TaskManagerApi.Services;
using MyTask = TaskManagerApi.Models.Task;

namespace TaskManagerApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TaskController : ControllerBase
  {
    private readonly TaskService _taskService;

    public TaskController(TaskService taskService)
    {
      _taskService = taskService;
    }

    [HttpPost]
    public IActionResult CreateTask([FromBody] MyTask newTask)
    {
      if (string.IsNullOrWhiteSpace(newTask.Title))
        return BadRequest(new { error = "Title is required" });

      _taskService.AddTask(newTask);

      return CreatedAtAction(nameof(GetTask), new { id = newTask.Id }, newTask);
    }

    [HttpGet("{id}")]
    public IActionResult GetTask(int id)
    {
      var tasks = _taskService.GetAllTasks();
      var task = tasks.FirstOrDefault(t => t.Id == id);

      if (task == null)
        return NotFound(new { message = "Task not found" });

      return Ok(task);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, [FromBody] MyTask updatedTask)
    {
      var tasks = _taskService.GetAllTasks();
      var task = tasks.FirstOrDefault(t => t.Id == id);

      if (task == null)
        return NotFound(new { message = "Task not found" });

      task.Title = updatedTask.Title;
      task.IsCompleted = updatedTask.IsCompleted;

      return Ok(task);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
      var tasks = _taskService.GetAllTasks();
      var task = tasks.FirstOrDefault(t => t.Id == id);

      if (task == null)
        return NotFound(new { message = "Task not found" });

      tasks.Remove(task);
      return NoContent();
    }
  }
}
