using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            DisplayTodos();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. View Details of a Todo");

            var selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                Console.WriteLine("Which Todo?");
                var selectedTodo = Console.ReadLine();
                var todoId = int.Parse(selectedTodo);
                DisplayTodoDetails(todoId);
            }
        }

        private static void DisplayTodoDetails(int todoId)
        {
            //Get the todo and print it out
            var todoRepo = new TodoRepository();
            var todo = todoRepo.GetById(todoId);

            Console.WriteLine(todo);
            Console.WriteLine(todo.Details);
        }

        private static void DisplayTodos()
        {
            var todoRepo = new TodoRepository();
            foreach (var item in todoRepo.GetAll())
            { Console.WriteLine(item);
            }
        }
    }
}

            //using (var db = new TodoContext())
            //{
            //Commented this out because it gives us cleaner code. 
            //Created a GetAll method in TodoRepository class
            //var todoRepo = new TodoRepository();
            //    foreach (var item in todoRepo.GetAll())
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.ReadLine();