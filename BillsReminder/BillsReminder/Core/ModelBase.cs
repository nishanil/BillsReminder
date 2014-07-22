using System;
using System.Collections.Generic;
using System.Text;

namespace BillsReminder
{
    public class ModelBase : ObservableObject
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value;
                OnPropertyChanged();
            }
        }
        
    }
}
