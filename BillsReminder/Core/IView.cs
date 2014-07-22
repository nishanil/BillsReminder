using System;
using System.Collections.Generic;
using System.Text;

namespace BillsReminder
{
    public interface IView<out TViewModel> where TViewModel : IViewModel
    {
        /// <summary>
        /// ViewModel
        /// </summary>
        TViewModel ViewModel { get; }
    }
}
