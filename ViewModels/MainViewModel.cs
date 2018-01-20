using SimpleWpf.ViewModels;
using SimpleWpf.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWpf.ViewModels
{
    public sealed class MainViewModel : BaseViewModel
    {
        public ObservableCollection<PersonViewModel> Repository { get; set; } = new ObservableCollection<PersonViewModel>();
        private PersonViewModel _currItem = new PersonViewModel(new Models.PersonModel());

        public PersonViewModel CurrentItem
        {
            get { return _currItem; }
            set { _currItem = value; OnPropertyChanged(); }
        }

        private ActionCommand _add;
        private ActionCommand _remove;

        public ActionCommand Add
        {
            get
            {
                return _add ?? 
                    (_add = new ActionCommand((o) => { Repository.Add(new PersonViewModel(CurrentItem)); },
                                              (o) => {
                                                  return !string.IsNullOrEmpty(CurrentItem.FirstName) && !string.IsNullOrEmpty(CurrentItem.SecondName);
                                              }));
            }
        }

        public ActionCommand Remove
        {
            get { return _remove ?? (_remove = new ActionCommand((o) => { Repository.RemoveAt(Repository.Count-1); }, (o) => { return Repository.Count != 0; })); }
        }
    }
}
