using Microsoft.AspNetCore.Mvc;
using TodoManager.Dto;
using TodoManager.Properties.domain;

namespace TodoManager.Controllers;

[ApiController]
[Route("[controller]")]

public class TodosController : ControllerBase
{
    private static readonly List<Todo> _todos = new();
    /// <summary>
    /// Возвращает все Todo
    /// </summary>
    /// <returns></returns>
    [HttpGet]

    public IActionResult Get()
    {
        var result = _todos.Select(t => new { t.Id, t.Title, PlannedDay = t.PlannedDay.ToString( "yyyy-MM-dd hh:mm:ss") } ).ToList();

        return Ok(result);
    }

    /// <summary>
    /// Возвращает Todo по id
    /// </summary>
    /// <returns></returns>
    [HttpGet( "{id}" )]
    public IActionResult GetById( int id)
    {
        var result = _todos.Where(t => t.Id == id).FirstOrDefault();
        return Ok(result);
    }

    /// <summary>
    /// Создает Todo
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Create([FromBody] CreateTodoDto createDto)
    {
        int id = _todos.Count + 1;
        Todo todo = new(id, createDto.Title);

        _todos.Add(todo);

        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult DeleteById(int id, [FromBody] CreateTodoDto createDto)
    {
        Todo result = _todos.Where(t => t.Id == id).FirstOrDefault();
        result.Title = createDto.Title;

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteById(int id)
    {
       Todo result = _todos.Where(t => t.Id == id).FirstOrDefault();

        _todos.Remove(result);

        return Ok();
    }
}
