using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api.Services.TodoServices
{
    public class TodoService : ITodoService
    {
        private readonly List<Todo> todos = new List<Todo> {
            new Todo { Id = 1, Task = "Do the dishes", IsCompleted = false },
            new Todo { Id = 2, Task = "Walk the dog", IsCompleted = true },
            new Todo { Id = 3, Task = "Take out the trash", IsCompleted = false }
        };

        public Todo CreateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Todo DeleteTodoById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Todo?> GetTodoById(int id)
        {
            var todo = todos.FirstOrDefault(todo => todo.Id == id);

            if (todo == null)
            {
                return null;
            }

            return todo;
        }

        public async Task<List<Todo>> GetTodos()
        {
            return todos;
        }

        public Todo UpdateTodoById(int id, Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}