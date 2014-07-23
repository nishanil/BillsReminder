using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BillsReminder
{
    public class PageBase : ContentPage
    {
        public void SetupPage()
        {
            ViewModelBase vmBase;
            if (Content != null && (vmBase = Content.BindingContext as ViewModelBase) != null)
            {
                Title = vmBase.PageTitle;
                Padding = PageHelper.PagePadding;
            }
        }
    }
}
