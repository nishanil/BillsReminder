using System;
using System.Collections.Generic;
using System.Text;

namespace BillsReminder
{
    public class Category : ModelBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;
                OnPropertyChanged();
            }
        }
        
        
    }
}
