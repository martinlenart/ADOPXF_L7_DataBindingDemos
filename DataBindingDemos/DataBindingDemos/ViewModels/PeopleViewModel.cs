﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

using DataBindingDemos.Models;

namespace DataBindingDemos.ViewModels
{
    public class PeopleViewModel
    {
        public ObservableCollection<Person> Employees { get; set; }

        public ICommand DeleteEmployeeCommand { get; private set; }

        public PeopleViewModel()
        {
            DeleteEmployeeCommand = new Command((employee) =>
            {
                Employees.Remove(employee as Person);
            });
        }
    }
}
