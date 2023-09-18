using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Services.TodoServices
{
    public interface ITodoService
    {
        Task<List<Todo>> GetTodos();
        Task<Todo> GetTodoById(int id);
        Todo CreateTodo(Todo todo);
        Todo UpdateTodoById(int id, Todo todo);
        Todo DeleteTodoById(int id);
    }
}