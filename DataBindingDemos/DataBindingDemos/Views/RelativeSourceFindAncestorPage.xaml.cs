﻿using System.Collections.ObjectModel;
using Xamarin.Forms;

using DataBindingDemos.Models;
using DataBindingDemos.ViewModels;

namespace DataBindingDemos.Views
{
    public partial class RelativeSourceFindAncestorPage : ContentPage
    {
        public PeopleViewModel DefaultViewModel { get; } = new PeopleViewModel
        {
            Employees = new ObservableCollection<Person>
            {
                new Person
                {
                    Forename = "John",
                    Surname = "Doe"
                },
                new Person
                {
                    Forename = "Jane",
                    Surname = "Doe"
                },
                new Person
                {
                    Forename = "Xamarin",
                    Surname = "Monkey"
                }
            }
        };

        public RelativeSourceFindAncestorPage()
        {
            InitializeComponent();
        }
    }
}
