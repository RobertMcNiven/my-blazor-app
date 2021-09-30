using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Pages
{
    public class TodoItem
    {
        public string Title { get; set; }
        // Method that gets and sets titles of toditesm
        public bool IsDone { get; set; }
        // Method that gets and sets bool values if the todoitem is checked
    }
}
