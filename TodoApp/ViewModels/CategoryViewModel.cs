using System;
using System.Collections.ObjectModel;
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
    public class CategoryViewModel : NotifyObject
    {
        private string _title;

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
