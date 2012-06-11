using System;
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
using TodoApp.Model;

namespace TodoApp.ViewModels
{
    public class MainViewModel : NotifyObject
    {
        public MainViewModel()
        {
            var _todos = new ObservableCollection<Todo>
                        {
                            new Todo { Title = "Complete Session.", Due = new DateTime(2012, 6, 12)},
                            new Todo { Title = "Buy Milk.", Due = new DateTime(2012, 6, 15)},
                            new Todo { Title = "Go to sleep.", Due = new DateTime(2012, 6, 22)},
                        };
            CategoryViewModel today = new CategoryViewModel
                                          {
                                              Title = "Today",
                                              Todos =
                                                  new ObservableCollection<Todo>(
                                                  _todos.Where(t => t.Due == DateTime.Today))
                                          };
            CategoryViewModel week = new CategoryViewModel
            {
                Title = "Week",
                Todos =
                    new ObservableCollection<Todo>(
                    _todos.Where(t => t.Due >= DateTime.Today &&  t.Due < DateTime.Today.AddDays(7)))
            };

            CategoryViewModel month = new CategoryViewModel
            {
                Title = "Month",
                Todos =
                    new ObservableCollection<Todo>(
                    _todos.Where(t => t.Due >= DateTime.Today && t.Due < DateTime.Today.AddDays(30)))
            };

            Categories = new CategoryViewModel[] { today, week, month};
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
                    OnPropertyChanged("Categories");
                }
            }
        }


      



      

    }
}
