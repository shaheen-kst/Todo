using System;
using System.ComponentModel.DataAnnotations;

namespace  TodoApi.Models
{
    public class TodoItem {
        public int Id {get; set;  }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        
    }
}
