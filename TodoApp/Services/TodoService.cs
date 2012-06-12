using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using TodoApp.Model;

namespace TodoApp.Services
{
    public static class TodoService
    {
        public static IEnumerable<Todo> GenereateTodos()
        {
            return new List<Todo>
                        {
                            new Todo { Title = "Join CodeValue", Due = new DateTime(2012, 6, 13)},
                            new Todo { Title = "Save the Date: Israel Mobile Summit.", Due = new DateTime(2012, 6, 12)},
                            new Todo { Title = "Watch the Euro2012 final.", Due = new DateTime(2012, 7, 1)},
                        };
        }

    }
}
