using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BillsReminder
{
    public class ViewModelBase : ObservableObject, IViewModel
    {
        private string pageTitle;

        public string PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value;
                OnPropertyChanged();
            }
        }

        private string icon;

        public string Icon
        {
            get { return icon; }
            set { icon = value;
                OnPropertyChanged();
            }
        }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value;
                OnPropertyChanged();
            }
        }
        
        
        
    }
}
