using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Pages
{
    public class TodoItem
    /* Creating a class called TodoItem*/
    {
        public string Title { get; set; }
        /* Creating a getter and setter for title field*/
        public bool IsDone { get; set; }
        /* Creating getter and setter for IsDone field*/
    }
}
