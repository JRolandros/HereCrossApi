using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HereCrossApi.Abstractions
{
	public class CrossHereMap : ContentPage
	{
		public CrossHereMap()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello Page" }
				}
			};
		}
	}
}
