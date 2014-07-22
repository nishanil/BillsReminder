using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BillsReminder
{
    public class ViewBase<TViewModel> : ContentPage, IView<TViewModel> where TViewModel : ViewModelBase
    {
        private ViewBase()
        { }

        public ViewBase(TViewModel tViewModel)
        {
            ViewModel = tViewModel;
            SetBinding(Page.TitleProperty, new Binding(tViewModel.PageTitle));
            SetBinding(Page.IconProperty, new Binding(tViewModel.Icon));

        }

        /// <summary>
        /// Sets or Gets the BindingContext
        /// </summary>
        public TViewModel ViewModel
        {
            get
            {
                return (TViewModel)BindingContext;
            }
            private set
            {
                BindingContext = value;
            }
        }
    }


    //public class ViewBase : ContentPage
    //{}
}
