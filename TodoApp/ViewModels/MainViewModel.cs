using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
            Todos = new ObservableCollection<Todo>
                        {
                            new Todo { Title = "Complete Session."},
                            new Todo { Title = "Buy Milk."},
                            new Todo { Title = "Go to sleep."},
                        };
        }
        private string _title = "Today";

        public string Title
        {
            get { return _title; }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        private ObservableCollection<Todo> _todos;

        public ObservableCollection<Todo> Todos
        {
            get { return _todos; }
            set
            {
                if (value != _todos)
                {
                    _todos = value;
                    OnPropertyChanged("Todos");
                }
            }
        }

      

    }
}
