using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    [Table("Todos")]
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        public override string ToString()
        {
            return Id + ". " + Name;
        }
    }
}