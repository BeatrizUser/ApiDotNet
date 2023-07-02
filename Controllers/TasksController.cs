using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private List<Task> tasks = new List<Task>();

        public TasksController()
        {
            // Inicializa algumas tarefas para exemplificar
            tasks.Add(new Task { Id = 1, Title = "Tarefa 1", Description = "Descrição da tarefa 1", Completed = false });
            tasks.Add(new Task { Id = 2, Title = "Tarefa 2", Description = "Descrição da tarefa 2", Completed = true });
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetTaskById(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public IActionResult CreateTask(Task task)
        {
            task.Id = tasks.Max(t => t.Id) + 1;
            tasks.Add(task);
            return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, Task task)
        {
            var existingTask = tasks.FirstOrDefault(t => t.Id == id);
            if (existingTask == null)
            {
                return NotFound();
            }
            existingTask.Title = task.Title;
            existingTask.Description = task.Description;
            existingTask.Completed = task.Completed;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            tasks.Remove(task);
            return NoContent();
        }
    }

    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool Completed { get; set; }
        
    }
}
