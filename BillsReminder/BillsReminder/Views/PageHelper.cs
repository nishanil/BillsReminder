using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BillsReminder
{
    static class PageHelper
    {
        public static readonly Thickness PagePadding =
            new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);
    }
}
