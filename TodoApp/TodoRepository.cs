﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoRepository
    {
        public List<Todo> GetAll()
        {
            using (var db = new TodoContext())
            {
                return db.Todos.ToList();
            }
        }

        public Todo GetById(int todoId)
        {
            using (var db = new TodoContext()) 
            {
                return db.Todos.Single(todo => todo.Id == todoId);
            }
        }

        public void DeleteTodo(int todoId)
        {
            using (var db = new TodoContext())
            {
                var toDelete = db.Todos.Single(todo => todo.Id == todoId);
                db.Todos.Remove(toDelete);
                db.SaveChanges();
            }
        }
    }
}
