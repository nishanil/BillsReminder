using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BillsReminder
{
    public class ViewBase<TViewModel> : ContentView, IView<TViewModel> where TViewModel : ViewModelBase, new()
    {
        public ViewBase()
        {
            ViewModel = new TViewModel();
            
            //SetBinding(Page.TitleProperty, new Binding(ViewModelBase.PageTitlePropertyName));
            //SetBinding(Page.IconProperty, new Binding(TViewModel.Icon));
        }

        public ViewBase(TViewModel tViewModel) : this()
        {
            ViewModel = tViewModel;
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
}
