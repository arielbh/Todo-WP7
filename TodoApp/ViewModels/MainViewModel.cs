using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using TodoApp.Common;
using TodoApp.Model;
using TodoApp.Services;

namespace TodoApp.ViewModels
{
    public class MainViewModel : NotifyObject
    {
        public MainViewModel()
        {
            var _todos = TodoService.GenereateTodos();


            PrepareCategories(_todos);
        }

        private void PrepareCategories(IEnumerable<Todo> todos)
        {
            CategoryViewModel today = new CategoryViewModel
                                          {
                                              Title = "Today",
                                              Todos =
                                                  new ObservableCollection<Todo>(
                                                  todos.Where(t => t.Due == DateTime.Today))
                                          };
            CategoryViewModel week = new CategoryViewModel
                                         {
                                             Title = "Week",
                                             Todos =
                                                 new ObservableCollection<Todo>(
                                                 todos.Where(t => t.Due >= DateTime.Today && t.Due < DateTime.Today.AddDays(7)))
                                         };

            CategoryViewModel month = new CategoryViewModel
                                          {
                                              Title = "Month",
                                              Todos =
                                                  new ObservableCollection<Todo>(
                                                  todos.Where(
                                                      t => t.Due >= DateTime.Today && t.Due < DateTime.Today.AddDays(30)))
                                          };

            Categories = new CategoryViewModel[] {today, week, month};
        }

        private CategoryViewModel[] _categories;

        public CategoryViewModel[] Categories
        {
            get { return _categories; }
            set
            {
                if (value != _categories)
                {
                    _categories = value;
                    OnPropertyChanged(() => Categories);
                }
            }
        }


      



      

    }
}
