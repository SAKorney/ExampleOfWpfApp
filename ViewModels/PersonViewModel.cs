using SimpleWpf.Models;
using SimpleWpf.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWpf.ViewModels
{
    public class PersonViewModel : BaseViewModel
    {
        public readonly PersonModel Model;

        public PersonViewModel(PersonViewModel viewModel)
        {
            Model = viewModel.Model;
        }

        public PersonViewModel(PersonModel model)
        {
            Model = model;
        }

        public string FirstName
        {
            get { return Model.FirstName; }
            set { Model.FirstName = value; OnPropertyChanged(); }
        }

        public string SecondName
        {
            get { return Model.SecondName; }
            set { Model.SecondName = value; OnPropertyChanged(); }
        }
    }
}
