using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BillsReminder
{
    public class CategoryPageViewModel : ViewModelBase
    {
        public CategoryPageViewModel()
        {
            PageTitle = "Nish";
            Categories = new ObservableCollection<Category>(new [] {new Category() { Name = "Bank", Notes = "All Bank related" }, new Category() { Name = "Credit Card", Notes = "All Credit Card Related" }});

        }
        private ObservableCollection<Category> categories;

        public ObservableCollection<Category> Categories
        {
            get { return categories; }
            set { categories = value; OnPropertyChanged(); }
        }
        

        
    }
}
