using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BillsReminder
{
	public class App
	{
		public static Page GetMainPage()
		{
		    return new CategoryPage();
		    //return new ContentPage
		    //{
		    //    Content = new Label {
		    //        Text = "Hello, Forms !",
		    //        VerticalOptions = LayoutOptions.CenterAndExpand,
		    //        HorizontalOptions = LayoutOptions.CenterAndExpand,
		    //    },
		    //};
		}
	}
}
