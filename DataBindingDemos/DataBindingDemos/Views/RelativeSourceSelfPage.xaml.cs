using Xamarin.Forms;

using DataBindingDemos.Models;

namespace DataBindingDemos.Views
{
    public partial class RelativeSourceSelfPage : ContentPage
    {
        public Person Person { get; } = new Person
        {
            Forename = "John",
            Surname = "Doe"
        };

        public RelativeSourceSelfPage()
        {
            InitializeComponent();
        }
    }
}
